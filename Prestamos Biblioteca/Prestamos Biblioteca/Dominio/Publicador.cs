using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
    /// <summary>
    /// Es la entidad que publica los libros, se puede usar como criterio de busquedade Libros
    /// </summary>
    public class Publicador
    {
        #region Atributos Privados

        private int iId;
        private string iNombre;
        private string iDescripcion;

        #endregion

        #region Constructor

        public Publicador(int pId, string pNombre, string pDescripcion)
        {
            this.iId = pId;
            this.iNombre = pNombre;
            this.iDescripcion = pDescripcion;
        }

        #endregion

        #region Propiedades Publicas

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

        #endregion

    }
}
