using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
    public class Autor
    {
        private int iId;
        private string iNombreYApellido;

        public Autor(int pId, string pNombreYApellido)
        {
            this.iId = pId;
            this.iNombreYApellido = pNombreYApellido;
        }
        
        public int Id {
            get { return this.iId; } 
            private set { }
        }

        public string NombreApellido { get
            { return this.iNombreYApellido;  }
            private set  { } 
        }
    }
}
