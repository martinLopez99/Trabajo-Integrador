using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.API
{
    public class LibroProcessor
    {
        public async Task<Dominio.Libro> CargarLibro(int pISBN)
        {
            //Ver de usar el pISBN
            string url = "http://openlibrary.org/search.json";

            using (HttpResponseMessage respuesta = await APIHelper.ApiClient.GetAsync(url))
            {
                if (respuesta.IsSuccessStatusCode)
                {
                    Dominio.Libro libro = await respuesta.Content.ReadAsAsync<Dominio.Libro>();
                    return libro;
                }
                else
                {
                    throw new Exception(respuesta.ReasonPhrase);
                }
            }
        }
    }
}


