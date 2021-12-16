using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Prestamos_Biblioteca.Dominio
{
    /// <summary>
    /// Una entidad central de la aplicacion
    /// </summary>
    public class Libro
    {
        #region Atributos Privados

        private int iISBN10;
        private string iTitulo;
        private string iSubtitulo;

        #endregion

        #region Constructor
        public Libro(int pISBN10, string pTitulo, string pSubtitulo)
        {
            this.iISBN10 = pISBN10;
            this.iTitulo = pTitulo;
            this.iSubtitulo = pSubtitulo;
        }
        #endregion

        #region Propiedades Publicas

        public int isbn
        {
            get { return this.iISBN10; }
            private set { }
        }

        public string title
        {
            get { return this.iTitulo; }

            private set { }
        }

        public string subtitle
        {
            get { return this.iSubtitulo; }
            private set { }
        }

        public int first_publish_year { get; private set; }
        public List<Autor> author_name { get; set; }

        public List<Publicador> publisher { get; set; }

        public List<Tematica> subject { get; set; }

        //public List<Ejemplar> Ejemplares { get; set; }

        #endregion

    }
}