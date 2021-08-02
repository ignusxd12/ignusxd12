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
    public class marcaController : ApiController
    {
        public static dataMarca datosmarca = new dataMarca();
        // GET: api/marca
        public IEnumerable<marca> Get(string id_categoria, string id_subCategoria)
        {
            return datosmarca.getListMarca(id_categoria,id_subCategoria);
        }

      
    }
}
