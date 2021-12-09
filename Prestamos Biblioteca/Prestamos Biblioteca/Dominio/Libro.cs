using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
    public class Libro
    {

        private int iISBN10;
        private string iTitulo;
        private string iSubtitulo;

        public Libro(int pISBN10, string pTitulo, string pSubtitulo)
        {
            this.iISBN10 = pISBN10;
            this.iTitulo = pTitulo;
            this.iSubtitulo = pSubtitulo;
        }

        public int ISBN10 
        {
            get { return this.iISBN10; }
            private set { }
        }

        public string Titulo 
        {
            get { return this.iTitulo; }

            private set { }
        }

        public string Subtitulo 
        {
            get { return this.iSubtitulo; } 
            private set { }
        }

        public List<Autor> Autores { get; set; }

        public List<Publicador> Publicadores { get; set; }

        public List<Tematica> Tematicas { get; set; }

        public List<Ejemplar> Ejemplares { get; set; }

    }
}
