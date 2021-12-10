using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
    public class Ejemplar
    {
        private int iId;
        private Libro iLibro;

        public Ejemplar(int pId, Libro pLibro)
        {
            this.iId = pId;
            this.iLibro = pLibro;
        }
        public int Id
        {
            get { return this.iId; }
            private set { }
        }

        public Libro Libro
        {
            get { return this.iLibro; }
            private set { }
        }

    }
}
