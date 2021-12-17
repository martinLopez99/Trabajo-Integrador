using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Prestamos_Biblioteca.Encriptacion
{
    /// <summary>
    /// Se encarga de hashear las cadenas ingresadas
    /// </summary>
    class EncriptadorHASH256 : Encriptador
    {
        #region Constructor

        public EncriptadorHASH256()
            : base("HASH256")
        {

        }

        #endregion

        #region Metodos Publicos de la Interfaz 

        /// <summary>
        /// Recibe una cadena y devuelve el hash correspondiente
        /// </summary>
        /// <param name="pCadena">La cadena a hashear</param>
        /// <returns></returns>
        public override string Encriptar(string pCadena)
        {
            if (String.IsNullOrEmpty(pCadena))
                return String.Empty;

            using (var sha = new SHA256Managed())
            {
                byte[] textData = Encoding.UTF8.GetBytes(pCadena);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        #endregion

    }
}
