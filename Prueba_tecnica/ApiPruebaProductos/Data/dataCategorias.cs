using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPruebaProductos.Data
{
    public class dataCategorias
    {
        public List<categoria> getListCategorias()
        {

            List<categoria> lstCategoria = new List<categoria>();
           
            try
            {

                lstCategoria.Add(new categoria { id_categoria = "1", nombre_categoria = "Lenceria" });
                lstCategoria.Add(new categoria { id_categoria = "2", nombre_categoria = "Ropa" });
                lstCategoria.Add(new categoria { id_categoria = "3", nombre_categoria = "Zapatos" });
               
            }
            catch (Exception e)
            {

                throw;
            }
            return lstCategoria;

        }
    }
}