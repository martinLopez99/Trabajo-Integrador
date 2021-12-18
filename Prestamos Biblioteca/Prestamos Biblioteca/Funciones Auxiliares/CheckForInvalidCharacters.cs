using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Prestamos_Biblioteca.Funciones_Auxiliares
{
    /// <summary>
    /// Se encarga de checkear si las cadenas de entrada poseen algun caracter especial o siguen algun formato
    /// </summary>
    public static class CheckStrings
    {
        #region Chequeos de Caracteres

        /// <summary>
        /// Chequea si la cadena ingresada contiene caracteres especiales
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>Devuelve true si la cadena contiene caracteres especiales</returns>
        public static bool ChequearPorCaracteresEspeciales(string pCadena)
        {
            // Expresion regular para controlar que la cadena no tenga caracteres especiales 
            Regex rgx = new Regex("[^A-Za-z0-9]");

            // Chequea si la cadena se ajusta a la expresion regular, devuelve true si no se ajusta
            return rgx.IsMatch(pCadena);
        }

        /// <summary>
        /// Chequea si la cadena ingresada contiene caracteres especiales o numeros
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>Devuelve true si la cadena contiene caracteres especiales o numeros</returns>
        public static bool ChequearPorCaracteresEspecialesYNumeros(string pCadena)
        {
            // Expresion regular para controlar que la cadena no tenga caracteres especiales o numeros
            Regex rgx = new Regex("[^A-Za-z]");

            // Chequea si la cadena se ajusta a la expresion regular
            return rgx.IsMatch(pCadena);
        }

        /// <summary>
        /// Chequea si la cadena ingresada contiene caracteres especiales o letras
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>Devuelve true si la cadena contiene caracteres especiales o letras</returns>
        public static bool ChequearPorCaracteresEspecialesYLetras(string pCadena)
        {
            // Expresion regular para controlar que la cadena no tenga caracteres especiales o numeros
            Regex rgx = new Regex("[^0-9]");

            // Chequea si la cadena se ajusta a la expresion regular
            return rgx.IsMatch(pCadena);
        }

        #endregion

        #region Chequeos de Formatos

        /// <summary>
        /// Chequea si la cadena ingresada tiene un formato de Email
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>Devuelve true si la cadena tiene el fromato de Email</returns>
        public static bool ChequearSiTieneFormatoEmail(string pCadena)
        {
            // Expresion regular para controlar que la cadena no tenga caracteres especiales o numeros
            Regex rgx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            // Chequea si la cadena se ajusta a la expresion regular, devuelve true si no se ajusta
            return !rgx.IsMatch(pCadena);
        }

        #endregion
    }
}
