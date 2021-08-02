<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/Site2.Master" AutoEventWireup="true" CodeBehind="formularioProductos.aspx.cs" Inherits="Prueba_tecnica.Paginas.formularioProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <link rel="stylesheet" href="https://cdn.datatables.net/1.10.23/css/dataTables.bootstrap4.min.css">
  
    <div class="container">
        <div class="row">
          

            <div class="row">
                <div class="col-12 col-md-12">
                    <h2 class="font-weight-normal mb-2">Ingresa tu Producto</h2>
                </div>
                <div class="col-12 col-md-12">
                    <p>Debe completar los siguientes datos para ingresar su producto.</p>
                </div>
            </div>
            <asp:UpdatePanel runat="server" ID="UpProducto" class="col-md-12 col-lg-12 col-sm-12">
                <ContentTemplate>
                    <div class="row col-md-12 col-lg-12 col-sm-12 py-5">
                        <div class="col-md-12 col-lg-12 col-sm-12">

                            <div class="row">
                                <div class="col-12 col-md-4">
                                    <div class="form-group">
                                        <label for="ddlCategoria">Categoria</label>
                                        <asp:DropDownList class="form-control" ID="ddlCate"  runat="server" />
                                                                               
                                    </div>
                                </div>
                                  <div class="col-12 col-md-4">
                                    <div class="form-group">
                                        <label for="ddlSubCategoria">Sub-Categoria</label>
                                        <asp:DropDownList ID="ddlSubcate" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="DdlSubcate_SelectedIndexChanged" runat="server" />
                                                                               
                                    </div>
                                </div>
                                 <div class="col-12 col-md-4">
                                    <div class="form-group">
                                        <label for="ddlMarca">Marca</label>
                                        <asp:DropDownList class="form-control" ID="ddlMarca" runat="server" />                                       
                                    </div>
                                </div>

                            </div>

                            <div class="row">                            
                                <div class="col-12 col-md-4">
                                    <div class="form-group">
                                        <label for="txtNombreProducto">Fecha de Pago</label>
                                        <asp:TextBox runat="server" type="text" class="form-control" ID="txtNombreProducto" aria-describedby="" />
                                        
                                    </div>
                                </div>
                               
                                <div class="col-12 col-md-12 d-flex align-items-right justify-content-end ">
                                    <asp:Button runat="server" ID="btnLimpiar"  class="btn btn-outline-primary ml-2" Style="margin-right: 10px;" type="button" Text="Limpiar Campos" />
                                    <asp:Button ID="btnAgrega" type="button" runat="server" OnClick="BtnAgrega_Click"  class="btn btn-primary" Text="Agregar Producto" />
                                    <asp:Button ID="btnModifica" type="button" runat="server" OnClick="BtnModifica_Click"  class="btn btn-primary" Text="Modificar Nómina" Visible="false" />
                                </div>
                            </div>

                        </div>


                    </div>

                    <div class="row col-md-12 col-lg-12 col-sm-12 py-5">
                        <div class="col-md-12 col-lg-12 col-sm-12">
                            <asp:GridView ID="gvData" runat="server" CssClass="table table-striped border " HeaderStyle-Font-Size="10pt" RowStyle-Font-Size="10pt" GridLines="Horizontal" AutoGenerateColumns="false">
                                <HeaderStyle Wrap="true" />
                                <AlternatingRowStyle Wrap="true" />
                                <RowStyle Wrap="true" />
                                <Columns>
                                    <asp:BoundField HeaderText="id" DataField="id_producto" />
                                    <asp:BoundField HeaderText="Nombre Producto" DataField="nombre_producto" />                          
                                    <asp:BoundField HeaderText="N° categoria" DataField="id_categoria" Visible="false" />
                                    <asp:BoundField HeaderText="N° categoria" DataField="id_marca" Visible="false" />
                                    <asp:BoundField HeaderText="N° categoria" DataField="id_subCategoria" Visible="false" />

                                    <asp:TemplateField HeaderText="Acciones" Visible="true">
                                        <ItemTemplate>
                                            <a class="d-inline-block px-1" id="btnEdita" onclick="EditaDatos(<%# Eval("id_producto") %>)" style="cursor: pointer;">
                                                Editar
                                            </a>
                                            <a class="d-inline-block px-1" id="btnElimina" onclick="Eliminadatos(<%# Eval("id_producto") %>);" style="cursor: pointer;">
                                                Eliminar
                                            </a>                                            
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="1%" />
                                    </asp:TemplateField>
                                </Columns>
                                <PagerSettings Mode="NumericFirstLast" />
                                <PagerStyle HorizontalAlign="Center" />
                            </asp:GridView>
                        </div>
                    </div>

                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
        <script src="https://cdn.datatables.net/1.10.23/js/dataTables.bootstrap4.min.js"></script>
       

     <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>

    <script >
        function EditaDatos(parameter) {
            __doPostBack('btnEdita', parameter+"_"+"A");
        }
        function Eliminadatos(parameter) {
            __doPostBack('btnElimina', parameter+"_"+"E");
        }
    </script>
</asp:Content>
