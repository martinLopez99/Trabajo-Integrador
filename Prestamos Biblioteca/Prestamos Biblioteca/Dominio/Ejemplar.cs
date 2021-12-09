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

        public Ejemplar (int pId)
        {
            this.iId = pId;
        }
        public int Id
        {
            get { return this.iId; }
            private set { }  
        }

    }
}
