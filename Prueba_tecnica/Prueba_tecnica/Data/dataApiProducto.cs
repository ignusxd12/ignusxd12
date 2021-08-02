using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;

namespace Prueba_tecnica.Data
{
    public class dataApiProducto
    {
       public static List<producto> listado = new List<producto>();
        public List<producto> getProductos()
        {
            HttpClient httpClient = new HttpClient();
            
            try
            {
                httpClient.BaseAddress = new Uri("http://localhost:61493/");
                var request = httpClient.GetAsync("api/producto").Result;
               
                if (request.IsSuccessStatusCode)
                {
                    var resultString = request.Content.ReadAsStringAsync().Result;
                    listado = JsonConvert.DeserializeObject<List<producto>>(resultString);
                }

            }
            catch (Exception e)
            {

                throw;
            }

            return listado;

        }

        public bool insertProducto(producto p)
        {
            bool estado = false;
            HttpClient httpClient = new HttpClient();
            
            try
            {
                httpClient.BaseAddress = new Uri("http://localhost:61493/");
                var serializeProducto = JsonConvert.SerializeObject(p);
                var content = new StringContent(serializeProducto, Encoding.UTF8, "application/json");
                var request=httpClient.PostAsync("api/producto",content);

                estado = true;
            }
            catch (Exception e)
            {

                throw;
            }

            return estado;
        }
    }
}