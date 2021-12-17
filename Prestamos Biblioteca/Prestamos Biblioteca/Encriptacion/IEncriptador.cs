using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Encriptacion
{
    /// <summary>
    /// Establece el contrato mínimo que deben cumplir todos los algoritmos de encriptación.
    /// </summary>
    public interface IEncriptador
    {
        #region Metodos a Implementar por las clases

        /// <summary>
        /// Encripta la cadena de entrada
        /// </summary>
        /// <param name="pCadena">La cadena a encriptar</param>
        /// <returns>La cadena encriptada</returns>
        string Encriptar(string pCadena);


        #endregion
    }
}
