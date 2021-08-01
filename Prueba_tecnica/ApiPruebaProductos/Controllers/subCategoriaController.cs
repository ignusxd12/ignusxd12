using ApiPruebaProductos.Data;
using ApiPruebaProductos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiPruebaProductos.Controllers
{
    public class subCategoriaController : ApiController
    {
        public static dataSubCategoria dataSub = new dataSubCategoria();
        // GET: api/subCategoria
        public IEnumerable<subCategoria> Get(string id_categoria)
        {
            return  dataSub.getListSubCategorias(id_categoria);
        }

       
    }
}
