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
    public class categoriaController : ApiController
    {
        public static dataCategorias dataCat = new dataCategorias();
        // GET: api/categoria
        public IEnumerable<categoria> Get()
        {
            return dataCat.getListCategorias();
        }

    }
}
