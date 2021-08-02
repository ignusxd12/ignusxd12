using ApiPruebaProductos.Data;
using Entidades;
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
        public IEnumerable<subCategoria> Get()
        {
            return  dataSub.getListSubCategorias();
        }

       
    }
}
