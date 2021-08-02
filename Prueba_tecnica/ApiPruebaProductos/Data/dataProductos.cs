using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPruebaProductos.Data
{
    public class dataProductos
    {
        public static List<producto> lstProducto = new List<producto>();
        public List<producto> getListProducto()
        {
           return lstProducto;
        }

        public bool insertListaProducto(producto p)
        {
            bool estado = false;
            try
            {
                lstProducto.Add(
                    new producto {
                    id_producto =p.id_producto,
                    nombre_producto =p.nombre_producto,
                    id_categoria =p.id_categoria,
                    id_subCategoria =p.id_subCategoria,
                    id_marca =p.id_marca });
                estado = true;
            }           
            catch (Exception e)
            {

                throw;
            }
            return estado;
        }

        public List<producto> getLisByidProducto(string id_producto)
        {
            List<producto> lstBusqueda = new List<producto>();
            try
            {
                lstBusqueda = lstProducto.FindAll(x => x.id_producto.Contains(id_producto));
            }
            catch (Exception e)
            {

                throw;
            }

            return lstBusqueda;

        }

        public void upDateProducto(producto p)
        {
            try
            {
                var replaceItem = new producto
                {
                    id_producto = p.id_producto,
                    nombre_producto = p.nombre_producto,
                    id_categoria = p.id_categoria,
                    id_subCategoria = p.id_subCategoria,
                    id_marca = p.id_marca
                };
               
                var element = lstProducto.FirstOrDefault(i => i.id_producto == replaceItem.id_producto);
                lstProducto.Remove(element);
                lstProducto.Add(
                   new producto
                   {
                       id_producto = p.id_producto,
                       nombre_producto = p.nombre_producto,
                       id_categoria = p.id_categoria,
                       id_subCategoria = p.id_subCategoria,
                       id_marca = p.id_marca
                   });
            }
            catch (Exception e)
            {

                throw;
            }

        }

        public void deleteProducto(string id_producto)
        {
            var element = lstProducto.FirstOrDefault(i => i.id_producto == id_producto);
            lstProducto.Remove(element);
        }

    }
}