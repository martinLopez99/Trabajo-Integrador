using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
    /// <summary>
    /// Es la tematica que tiene cada <see cref="Libro"/>, se puede usar como criterio de busqueda de Libros
    /// </summary>
    public class Tematica
    {
        #region Atributos Privados

        private int iId; 
        private string iNombre;

        #endregion

        #region Constructor

        public Tematica(int pId, string pNombre)
        {
            this.iId = pId ;
            this.iNombre = pNombre;
        }

        #endregion

        #region Propiedades Publicas

        public int IdTematica 
        {
            get {return this.iId; }
            private set { } 
        }

        public string Nombre 
        { get { return this.iNombre; }
            private set { } 
        }

        #endregion
    }
}
