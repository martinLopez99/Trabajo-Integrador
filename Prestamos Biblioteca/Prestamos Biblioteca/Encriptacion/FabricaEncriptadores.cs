using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Encriptacion
{
    /// <summary>
    /// Implementa el patron Singleton, responsable de crear y mantener una instancia de 
    /// cada implementación de la interface IEncriptador.
    /// </summary>
    class FabricaEncriptadores
    {
        #region Atributos Privados
        // Variable estática para la instancia, se necesita utilizar una función lambda ya que el constructor es privado
        private static FabricaEncriptadores cInstancia;
        private static Dictionary<string, Encriptador> iEncriptadores = new Dictionary<string, Encriptador>();
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor privado para evitar la instanciación directa
        /// </summary>
        private FabricaEncriptadores()
        {
            iEncriptadores.Add("HASH256", new EncriptadorHASH256());
            iEncriptadores.Add("Null", new EncriptadorNulo());
        }

        #endregion

        #region Metodos Publicos
        /// <summary>
        /// Metodo para acceder a la instancia
        /// </summary>
        /// <returns>La instancia de la FabricaEncriptadores</returns>
        public static FabricaEncriptadores GetInstance()
        {
            if (cInstancia == null)
            {
                cInstancia = new FabricaEncriptadores();
            }
            return cInstancia;
        }


        /// <summary>
        /// Devuelve la instancia de IEncriptador cuyo nombre coincide con el parámetro proporcionado
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        public IEncriptador getEncriptador(string pNombre)
        {
            if (!iEncriptadores.ContainsKey(pNombre)) return iEncriptadores.GetValueOrDefault("Null");

            else return iEncriptadores.GetValueOrDefault(pNombre);
        }

        #endregion
    }
}
