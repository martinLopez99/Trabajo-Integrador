using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
    /// <summary>
    /// Es el autor de un <see cref="Libro"/>, se puede usar como criterio de busqueda de Libros
    /// </summary>
    public class Autor
    {
        #region Atributos Privados

        private int iId;
        private string iNombreApellido;

        #endregion

        #region Constructor

        public Autor(int pId, string pNombreApellido)
        {
            this.iId = pId;
            this.iNombreApellido = pNombreApellido;
        }

        #endregion

        #region Propiedades Publicas

        public int Id
        {
            get { return this.iId; }
            private set { }
        }

        public string NombreApellido
        {
            get
            { return this.iNombreApellido; }
            private set { }
        }

        #endregion

    }
}
