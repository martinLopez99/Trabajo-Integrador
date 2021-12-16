using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
    /// <summary>
    /// Un <see cref="Libro"/> tiene varios ejemplares
    /// </summary>
    public class Ejemplar
    {

        #region Atributos Privados

        private int iId;
        private Libro iLibro;

        #endregion

        #region Constructor

        public Ejemplar(int pId, Libro pLibro)
        {
            this.iId = pId;
            this.iLibro = pLibro;
        }

        #endregion

        #region Propiedades Publicas

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

        #endregion

    }
}
