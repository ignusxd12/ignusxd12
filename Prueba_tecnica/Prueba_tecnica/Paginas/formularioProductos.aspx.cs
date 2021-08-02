using Entidades;
using Prueba_tecnica.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba_tecnica.Paginas
{
    public partial class formularioProductos : System.Web.UI.Page
    {
        public static int contadorIdP=0;
        public enum ValorInicial
        {
            Todos = 0,
            Seleccionar = 1
        }
        public static datosApiGeneral datosApi = new datosApiGeneral();
        public static dataApiProducto datosApiP = new dataApiProducto(); 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
               
                this.CargaCategorias();
                this.CargaSubCategorias();
                


            }
        }

        public void BtnAgrega_Click(object sender, EventArgs e)
        {
            var id_categoria = ddlCate.SelectedValue.ToString();
            var id_subCategoria = ddlSubcate.SelectedValue.ToString();
            var id_marca = ddlMarca.SelectedValue.ToString();
            var nombreProducto = txtNombreProducto.Text.ToString();
            contadorIdP = contadorIdP + 1;
            producto p = new producto
            {
                id_producto = contadorIdP.ToString(),
                nombre_producto = nombreProducto,
                id_categoria = id_categoria,
                id_subCategoria = id_subCategoria,
                id_marca = id_marca
            };

           bool estado = datosApiP.insertProducto(p);
            if (estado)
            {
                this.getGrillaProductos();
            }
        }       
        public void DdlSubcate_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CargaMarcas();
        }
      
        protected void CargaCategorias()
        {
            this.Cargar(this.ddlCate, datosApi.getCategorias() , "nombre_categoria", "id_categoria");
        }
        protected void CargaSubCategorias()
        {
            this.Cargar(this.ddlSubcate, datosApi.getSubCategorias(), "nombre_subCategoria", "id_subCategoria");

        }
        protected void CargaMarcas()
        {
            var id_subCategoria = ddlSubcate.SelectedValue.ToString();
            var id_categoria = ddlCate.SelectedValue.ToString();
            this.Cargar(this.ddlMarca, datosApi.getMarcas(id_categoria,id_subCategoria), "nombre_marca", "id_marca");

        }
        protected void getGrillaProductos()
        {
            try
            {
                    var listaDetalle = datosApiP.getProductos();
                        if (listaDetalle.Count != 0)
                        {
                            
                            this.CagaTablaProductos(this.gvData, listaDetalle);
                    //This replaces <td> with <th> and adds the scope attribute

                    //This will add the <thead> and <tbody> elements
                            gvData.HeaderRow.TableSection = TableRowSection.TableHeader;
                            ScriptManager.RegisterStartupScript(this, GetType(), Guid.NewGuid().ToString(),
                                                          "javascript: $(document).ready(function () {" +
                            "$('#" + gvData.ClientID + "').dataTable(" +
                            "{" +
                               " 'lengthMenu': [5]," +
                               " 'pagingType': 'full_numbers'," +
                               " 'bLengthChange': false," +
                               " 'order': []," +
                                "'language':" +
                                "{" +
                                    "decimal: ',' ," +
                                     "thousands: '.'," +
                                     "processing: 'Procesando...'," +
                                      "search: ''," +
                                      "lengthMenu: 'Mostrar _MENU_ registros'," +
                                       "info: '_START_ - _END_ de _TOTAL_'," +
                                        "infoEmpty: ''," +
                                          "infoFiltered: '(filtrado de un total de _MAX_ registros)'," +
                                           "infoPostFix: ''," +
                                            "loadingRecords: 'Cargando...'," +
                                            "zeroRecords: 'No se encontraron resultados'," +
                                             "emptyTable: 'Ningún dato disponible en la tabla'," +
                                        "paginate:" +
                                        "{" +
                                               "first: ''," +
                                             " previous: 'Anterior'," +
                                                        "next: 'Siguiente'," +
                                                        "last: ''" +
                                        "}," +
                                        "aria:" +
                                        "{" +
                                                "sortAscending: ': Activar para ordenar la columna de manera ascendente'," +
                                                "sortDescending: ': Activar para ordenar la columna de manera descendente'," +
                                        "}" +
                        "}" +
                        "});" +
                        "var p = $('#" + gvData.ClientID + "');" +
                        "var i = p.find('input');" +
                        "i.addClass('form-control');" +
                        "i.attr('placeholder', 'Buscar');" +
                        "p.attr('style', 'padding-right: 8px;');" +
                           "});  ", true);

                            ScriptManager.RegisterStartupScript(this, GetType(), Guid.NewGuid().ToString(), "javascript:$('#divTabla').show();$('#divTablaMensaje').hide();", true);
                        }
                   
                
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public void CagaTablaProductos(GridView grProducto, List<producto> lstProducto)
        {
            try
            {
                DataTable tableProducto = new DataTable();

                tableProducto.Columns.Add("id_producto");
                tableProducto.Columns.Add("nombre_producto");
                tableProducto.Columns.Add("id_categoria");
                tableProducto.Columns.Add("id_marca");
                tableProducto.Columns.Add("id_subCategoria");


                foreach (var item in lstProducto)
                {
                    tableProducto.Rows.Add(item.id_producto, item.nombre_producto, item.id_categoria, item.id_subCategoria, item.id_marca);
                }

                grProducto.DataSource = tableProducto;
                grProducto.DataBind();
            }
            catch
            {
                throw;
            }
        }
        public void Cargar(DropDownList drop, object source, string texto, string valor, ValorInicial inicial = ValorInicial.Seleccionar)
        {
            drop.DataTextField = texto;
            drop.DataValueField = valor;
            drop.DataSource = source;
            drop.DataBind();

            drop.Enabled = (drop.Items.Count > 0);
            if (drop.Items.Count > 0)
            {
                if (drop.Items.Count == 1)
                    drop.SelectedIndex = 0;

                if (inicial == ValorInicial.Seleccionar)
                    drop.Items.Insert(0, new ListItem("--Seleccione opción--", string.Empty));
                else
                    drop.Items.Insert(0, new ListItem("--Todos--", string.Empty));
            }
            else
                drop.Items.Insert(0, new ListItem("--Sin datos--", string.Empty));
        }
    }
}