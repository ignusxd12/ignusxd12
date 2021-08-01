using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPruebaProductos.Models
{
    public class producto
    {
        public string id_producto { get; set; }
        public string nombre_producto { get; set; }
        public string id_categoria { get; set; }
        public string id_marca { get; set; }
        public string id_subCategoria { get; set; }

    }
}