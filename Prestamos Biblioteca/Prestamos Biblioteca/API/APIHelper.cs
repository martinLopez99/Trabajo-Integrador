using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Prestamos_Biblioteca.API
{
    public static class APIHelper
    {
        public static HttpClient ApiClient { get; set; }
        public static void InicializarCliente()
        {
            ApiClient = new HttpClient();
            //ApiClient.BaseAddress = new Uri("");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
        }
    }
}