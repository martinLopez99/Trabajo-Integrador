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
        #region Usuarios Admin

        /// <summary>
        /// Registra un nuevo <see cref="UsuarioAdmin"/> y lo deberia cargar en la base de datos
        /// </summary>
        /// <param name="pNombre">Nombre del usuario administrador</param>
        /// <param name="pApellido">Apellido del usuario administrador</param>
        /// <param name="pNombreUsuario">Nombre de usuario del usuario administrador</param>
        /// <param name="pContrasenia">Contraseña del usuario administrador</param>
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

        #region Libros

        /// <summary>
        /// Busca el <see cref="Libro"/>, chequea si existen ejemplares disponibles y si los hay,
        /// lo devuelve (Tal vez habria que devolver solo los datos y no la entidad en si)
        /// </summary>
        /// <param name="isbnLibro">El ISBN del libro a buscar</param>
        /// <returns></returns>
        public static Libro BuscarLibro(string isbnLibro)
        {
            // TODO: Buscar en la base de datos el Libro con el ISBN

            // Libro de prueba
            Libro unLibro = new Libro("1234567890", "Don Quijote de la Mancha", "Una Aventura Loca");

            // TODO: Chequea que existan Ejemplares disponibles del Libro buscado

            return unLibro;
        }

        #endregion


        #region Usuarios

        /// <summary>
        /// Registra el nuevo <see cref="Usuario"/> y lo deberia cargar en la base de datos
        /// </summary>
        /// <param name="pNombre">Nombre del Usuario</param>
        /// <param name="pApellido">Apellido del Usuario</param>
        /// <param name="pDNI">DNI del Usuario</param>
        /// <param name="pFechaNacimiento">Fecha de Nacimiento del Usuario</param>
        /// <param name="pEmail">Email del usuario</param>
        public static void RegistrarUsuario(string pNombre, string pApellido, string pDNI, DateTime pFechaNacimiento, string pEmail)
        {
            // Crea una instancia de Usuario
            Usuario unUsuario = new Usuario(pDNI, pNombre, pApellido, pEmail, pFechaNacimiento);

            // TODO: Cargar un nuevo usuario en la base de datos

        }

        /// <summary>
        /// Busca el <see cref="Usuario"/> y lo devuelve (Tal vez habria que devolver solo los datos y no la entidad en si)
        /// </summary>
        /// <param name="dniUsuario">DNI del Usuario a buscar</param>
        public static Usuario BuscarUsuario(string dniUsuario)
        {
            // Buscar en la base de datos el Usuario con el dni

            // Usuario de prueba
            Usuario unUsuario = new Usuario("95889617", "Renato", "Corbellini", "renatocorbellini@hotmail.com", new DateTime(2000, 05, 03));

            return unUsuario;

        }

        #endregion

        #region Prestamos

        public static void RegistrarPrestamo(DateTime fechaInicio, DateTime fechaFinEstimada)
        {
            throw new NotImplementedException();
        }

        #endregion


        #region Region General

        /// <summary>
        /// Consulta a la base de datos si el nombreUsuario y al constraseña corresponden
        /// </summary>
        /// <param name="nombreUsuario">El nombre de usuario a verificar</param>
        /// <param name="contrasenia">La constraseña a verificar</param>
        /// <returns>Devuelve true si el nombre de usuario y la contraseña coiniciden con los almacenados en la base de datos</returns>
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
