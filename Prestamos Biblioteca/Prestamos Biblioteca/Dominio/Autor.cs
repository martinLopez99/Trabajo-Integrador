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
        private string iNombreApellido;

        public Autor(int pId, string pNombreApellido)
        {
            this.iId = pId;
            this.iNombreApellido = pNombreApellido;
        }
        
        public int Id {
            get { return this.iId; } 
            private set { }
        }

        public string NombreApellido { get
            { return this.iNombreApellido;  }
            private set  { } 
        }
    }
}
