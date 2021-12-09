using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
    public class Publicador
    {
        private int iId;
        private string iNombre;
        private string iDescripcion;

        public Publicador(int pId, string pNombre, string pDescripcion)
        {
            this.iId = pId;
            this.iNombre = pNombre;
            this.iDescripcion = pDescripcion;
        }

        public int Id
        {
            get { return this.iId; }
            private set { }
        }

        public string Nombre
        {
            get { return this.iNombre; }
            private set { }
        }

        public string Descripcion
        {
            get { return this.iDescripcion;  }
            private set { }
        }

    }
}
