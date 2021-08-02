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
    public class productoController : ApiController
    {
        public static dataProductos dataPro = new dataProductos();
        // GET: api/producto
        public IEnumerable<producto> Get()
        {
            return dataPro.getListProducto();
        }

        // GET: api/producto/5
        public IEnumerable<producto> Get(string id_producto)
        {
            return dataPro.getLisByidProducto(id_producto);
        }

        // POST: api/producto
        public bool Post([FromBody]producto pro)
        {
            return dataPro.insertListaProducto(pro);
        }

        // PUT: api/producto/5
        public void Put([FromBody]producto pro)
        {
            dataPro.upDateProducto(pro);
        }

        // DELETE: api/producto/5
        public void Delete(string id_producto)
        {
            dataPro.deleteProducto(id_producto);
        }
    }
}
