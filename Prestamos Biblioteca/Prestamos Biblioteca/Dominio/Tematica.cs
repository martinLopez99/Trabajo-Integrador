using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
    public class Tematica
    {
        private int iId; 
        private string iNombre;
        public Tematica(int pId, string pNombre)
        {
            this.iId = pId ;
            this.iNombre = pNombre;
        }
        public int IdTematica 
        {
            get {return this.iId; }
            private set { } 
        }
        public string Nombre 
        { get { return this.iNombre; }
            private set { } 
        }
    }
}
