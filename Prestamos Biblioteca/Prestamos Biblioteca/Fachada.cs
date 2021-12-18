using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prestamos_Biblioteca.Dominio;
using Prestamos_Biblioteca.Encriptacion;

namespace Prestamos_Biblioteca
{
    /// <summary>
    /// Clase que se encarga de controlar todo lo que el <see cref="UsuarioAdmin"/> hace en la GUI
    /// </summary>
    public static class Fachada
    {
        #region Creacion Usuario Admin

        /// <summary>
        /// Registra un nuevo <see cref="Usuario"/> y lo deberia cargar en la base de datos
        /// </summary>
        /// <param name="pNombre">Nombre del usuario</param>
        /// <param name="pApellido">Apellido del usuario</param>
        /// <param name="pFechaNacimiento">Fecha de nacimiento del usuario</param>
        /// <param name="pNombreUsuario">Nombre de usuario del usuario</param>
        /// <param name="pContrasenia">Contraseña del usuario</param>
        public static void RegistrarUsuarioAdmin(string pNombre, string pApellido, 
            string pNombreUsuario, string pContrasenia)
        {
            // Encripta el nombre de usuario y la contraseña para guardarlo en la base de datos
            string nombreUsuarioEncriptado = EncriptarFrase("HASH256", pNombreUsuario);
            string contraseniaEncriptada = EncriptarFrase("HASH256", pContrasenia);

            // Crea un instancia de UsuarioAdmin
            UsuarioAdmin unUsuarioAdmin = new UsuarioAdmin(pNombre, pApellido, 
                nombreUsuarioEncriptado, contraseniaEncriptada);

            // TODO: Cargar un nuevo usuario administrador en la base de datos

        }

        #endregion

        #region Creacion Usuario

        public static void RegistrarUsuario(string pNombre, string pApellido, string pDNI, DateTime pFechaNacimiento, string pEmail)
        {
            // Por ahora que nose como convertir DateTime a TimeSpan (Cambiar despues)
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            // Crea un instancia de Usuario
            Usuario unUsuario = new Usuario(pDNI, pNombre, pApellido, pEmail, currentTime);

            // TODO: Cargar un nuevo usuario administrador en la base de datos


        }

        #endregion


        #region Region General

        /// <summary>
        /// Consulta a la base de datos si el nombreUsuario y al constraseña corresponden
        /// </summary>
        /// <param name="nombreUsuario">El nombre de usuario a verificar</param>
        /// <param name="contrasenia">La constraseña a verificar</param>
        public static bool VerificarUsuarioYContrasenia(string pNombreUsuario, string pContrasenia)
        {
            // Encripta el nombre de usuario y la contraseña para consultarlo con lo guardado en la base de datos
            string nombreUsuarioEncriptado = EncriptarFrase("HASH256", pNombreUsuario);
            string contraseniaEncriptada = EncriptarFrase("HASH256", pContrasenia);

            // Para probar (Cambiar mas adelante)
            return false;

            // TODO: Consultar a la base de datos si el nombre de usuario y la contraseña ingresadas coinciden

        }

        #endregion

        #region Encriptacion

        /// <summary>
        /// Encripta una cadena
        /// </summary>
        /// <param name="pNombreEncriptador">Nombre del Encriptador a utilizar</param>
        /// <param name="pFraseAEncriptar">Cadena a encriptar</param>
        /// <returns>Cadena encriptada</returns>
        public static string EncriptarFrase(string pNombreEncriptador, string pFraseAEncriptar)
        {
            FabricaEncriptadores instancia = FabricaEncriptadores.GetInstance();
            IEncriptador encriptadorActual = instancia.getEncriptador(pNombreEncriptador);
            string fraseEncriptada = encriptadorActual.Encriptar(pFraseAEncriptar);
            return fraseEncriptada;
        }

        #endregion

    }
}
