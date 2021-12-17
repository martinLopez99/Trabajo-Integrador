using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Encriptacion
{
    /// <summary>
    /// Sirve como clase de base para los diferentes encriptadores que se deseen implementar
    /// </summary>
    abstract class Encriptador : IEncriptador
    {
        #region Atributos Privados
        private string iNombre;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        /// <param name="pNombre"></param>
        public Encriptador(string pNombre)
        {
            this.iNombre = pNombre;
        }
        #endregion

        #region Propiedades Publicas

        public string Nombre
        {
            get { return this.iNombre; }
            private set { }
        }

        #endregion

        #region Metodos Publicos

        public abstract string Encriptar(string pCadena);

        #endregion
    }
}
