﻿using ApiPruebaProductos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPruebaProductos.Data
{
    public class dataSubCategoria
    {
        public List<subCategoria> getListSubCategorias(string id_categoriaa)
        {

            List<subCategoria> lstsubCategoria = new List<subCategoria>();
            lstsubCategoria.Add(new subCategoria { id_subCategoria = "1", nombre_subCategoria = "Mujer", id_categoria="1" });
            lstsubCategoria.Add(new subCategoria { id_subCategoria = "2", nombre_subCategoria = "Hombre",id_categoria = "2" });
            lstsubCategoria.Add(new subCategoria { id_subCategoria = "3", nombre_subCategoria = "Niño o Niña",  id_categoria = "3" });
            
            try
            {

               var id= lstsubCategoria.Find(x => x.id_categoria.Contains(id_categoriaa));
            }
            catch (Exception e)
            {

                throw;
            }
            return lstsubCategoria;

        }
    }
}