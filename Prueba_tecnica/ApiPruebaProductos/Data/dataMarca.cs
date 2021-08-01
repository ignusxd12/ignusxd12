using ApiPruebaProductos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPruebaProductos.Data
{
    public class dataMarca
    {
        public List<marca> getListMarca(string id_categoria,string id_subCategoria)
        {

            List<marca> lstMarca= new List<marca>();

            //Categoria_SubCategoria_Marca ==> Lenceria_mujer_marcas
            lstMarca.Add(new marca { id_marca = "1", nombre_marca = "Kayser",id_categoria="1",id_subCategoria="1" });
            lstMarca.Add(new marca { id_marca = "2", nombre_marca = "Dakota", id_categoria = "1", id_subCategoria = "1" });
            lstMarca.Add(new marca { id_marca = "3", nombre_marca = "Flores", id_categoria = "1", id_subCategoria = "1" });
            lstMarca.Add(new marca { id_marca = "4", nombre_marca = "Dafiti", id_categoria = "1", id_subCategoria = "1" });

            //Categoria_SubCategoria_Marca ==> Lenceria_hombre_marcas
            lstMarca.Add(new marca { id_marca = "5", nombre_marca = "Palmers", id_categoria = "1", id_subCategoria = "2" });
            lstMarca.Add(new marca { id_marca = "6", nombre_marca = "Calvin Klein", id_categoria = "1", id_subCategoria = "2" });
            lstMarca.Add(new marca { id_marca = "7", nombre_marca = "Lacoste", id_categoria = "1", id_subCategoria = "2" });
            lstMarca.Add(new marca { id_marca = "8", nombre_marca = "Giorgio Armani", id_categoria = "1", id_subCategoria = "2" });

            //Categoria_SubCategoria_Marca ==> Lenceria_niño o niña_marcas
            lstMarca.Add(new marca { id_marca = "9", nombre_marca = "Polemic", id_categoria = "1", id_subCategoria ="3" });
            lstMarca.Add(new marca { id_marca = "10", nombre_marca = "Monarch",  id_categoria = "1", id_subCategoria = "3" });
            lstMarca.Add(new marca { id_marca = "11", nombre_marca = "Babyland", id_categoria = "1", id_subCategoria = "3" });
            lstMarca.Add(new marca { id_marca = "12", nombre_marca = "TOP",  id_categoria = "1", id_subCategoria = "3" });          

            //Categoria_SubCategoria_Marca ==> Ropa_mujer_marcas
            lstMarca.Add(new marca { id_marca = "13", nombre_marca = "Regatta", id_categoria = "2", id_subCategoria = "1" });
            lstMarca.Add(new marca { id_marca = "14", nombre_marca = "Index Mujer", id_categoria = "2", id_subCategoria = "1" });
            lstMarca.Add(new marca { id_marca = "15", nombre_marca = "Dafiti", id_categoria = "2", id_subCategoria = "1" });
            lstMarca.Add(new marca { id_marca = "16", nombre_marca = "Dakota", id_categoria = "2", id_subCategoria = "1" });

            //Categoria_SubCategoria_Marca ==> Ropa_hombre_marcas
            lstMarca.Add(new marca { id_marca = "17", nombre_marca = "J.J.O", id_categoria = "2", id_subCategoria = "2" });
            lstMarca.Add(new marca { id_marca = "18", nombre_marca = "Index Hombre", id_categoria = "2", id_subCategoria = "2" });
            lstMarca.Add(new marca { id_marca = "19", nombre_marca = "Lacoste", id_categoria = "2", id_subCategoria = "2" });
            lstMarca.Add(new marca { id_marca = "20", nombre_marca = "Maui", id_categoria = "2", id_subCategoria = "2" });

            //Categoria_SubCategoria_Marca ==> Ropa_niño o niña_marcas
            lstMarca.Add(new marca { id_marca = "21", nombre_marca = "Polemic", id_categoria = "2", id_subCategoria = "3" });
            lstMarca.Add(new marca { id_marca = "22", nombre_marca = "Adidas", id_categoria = "2", id_subCategoria = "3" });
            lstMarca.Add(new marca { id_marca = "23", nombre_marca = "Index niño", id_categoria = "2", id_subCategoria = "3" });
            lstMarca.Add(new marca { id_marca = "24", nombre_marca = "Nike", id_categoria = "2", id_subCategoria = "3" });            

            //Categoria_SubCategoria_Marca ==> Zapatos_mujer_marcas
            lstMarca.Add(new marca { id_marca = "26", nombre_marca = "Dakota", id_categoria = "3", id_subCategoria = "1" });
            lstMarca.Add(new marca { id_marca = "27", nombre_marca = "Sckechers", id_categoria = "3", id_subCategoria = "1" });
            lstMarca.Add(new marca { id_marca = "28", nombre_marca = "Gacel", id_categoria = "3", id_subCategoria = "1" });
            lstMarca.Add(new marca { id_marca = "29", nombre_marca = "Dafiti", id_categoria = "3", id_subCategoria = "1" });

            //Categoria_SubCategoria_Marca ==> Zapatos_hombre_marcas
            lstMarca.Add(new marca { id_marca = "5", nombre_marca = "Guante", id_categoria = "3", id_subCategoria = "2" });
            lstMarca.Add(new marca { id_marca = "6", nombre_marca = "Lacoste", id_categoria = "3", id_subCategoria = "2" });
            lstMarca.Add(new marca { id_marca = "7", nombre_marca = "Sckechers", id_categoria = "3", id_subCategoria = "2" });
            lstMarca.Add(new marca { id_marca = "8", nombre_marca = "Clavin Klein", id_categoria = "3", id_subCategoria = "2" });

            //Categoria_SubCategoria_Marca ==> Zapatos_niño o niña_marcas
            lstMarca.Add(new marca { id_marca = "30", nombre_marca = "Bubble Gummers", id_categoria = "3", id_subCategoria = "3" });
            lstMarca.Add(new marca { id_marca = "31", nombre_marca = "Sckechers", id_categoria = "3", id_subCategoria = "3" });
            lstMarca.Add(new marca { id_marca = "32", nombre_marca = "Babyland", id_categoria = "3", id_subCategoria = "3" });
            lstMarca.Add(new marca { id_marca = "33", nombre_marca = "TOP", id_categoria = "3", id_subCategoria = "3" });          

            try
            {

               lstMarca = lstMarca.FindAll(x => x.id_categoria.Contains(id_categoria));
                lstMarca = lstMarca.FindAll(x => x.id_subCategoria.Contains(id_subCategoria));
            }
            catch (Exception e)
            {

                throw;
            }
            return lstMarca;

        }
    }
}