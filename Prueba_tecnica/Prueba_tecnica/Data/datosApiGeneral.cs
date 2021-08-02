using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI.WebControls;

namespace Prueba_tecnica.Data
{
    public class datosApiGeneral
    {

        public List<categoria> getCategorias()
        {
            HttpClient httpClient = new HttpClient();
            List<categoria> listado = new List<categoria>();
            try
            {
                httpClient.BaseAddress = new Uri("http://localhost:61493/");
                var request = httpClient.GetAsync("api/categoria").Result;
                if (request.IsSuccessStatusCode)
                {
                    var resultString = request.Content.ReadAsStringAsync().Result;
                    listado = JsonConvert.DeserializeObject<List<categoria>>(resultString);
                }

            }
            catch (Exception e)
            {

                throw;
            }

            return listado;
        }

        public List<subCategoria> getSubCategorias()
        {
            HttpClient httpClient = new HttpClient();
            List<subCategoria> listado = new List<subCategoria>();
            try
            {
                httpClient.BaseAddress = new Uri("http://localhost:61493/");
                var request = httpClient.GetAsync("api/subCategoria").Result;
                if (request.IsSuccessStatusCode)
                {
                    var resultString = request.Content.ReadAsStringAsync().Result;
                    listado = JsonConvert.DeserializeObject<List<subCategoria>>(resultString);
                }

            }
            catch (Exception e)
            {

                throw;
            }

            return listado;
        }
        public List<marca> getMarcas(string id_categoria,string id_subCategoria)
        {
            HttpClient httpClient = new HttpClient();
            List<marca> listado = new List<marca>();
            try
            {
                httpClient.BaseAddress = new Uri("http://localhost:61493/");
                var request = httpClient.GetAsync("api/marca?id_categoria="+ id_categoria + "&id_subCategoria="+id_subCategoria+"").Result;
                if (request.IsSuccessStatusCode)
                {
                    var resultString = request.Content.ReadAsStringAsync().Result;
                    listado = JsonConvert.DeserializeObject<List<marca>>(resultString);
                }

            }
            catch (Exception e)
            {

                throw;
            }

            return listado;
        }





    }
}