using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prestamos_Biblioteca.Dominio;

namespace Prestamos_Biblioteca
{
    public static class Fachada
    {
        #region Region General

        /// <summary>
        /// Registra un nuevo <see cref="Usuario"/> y lo deberia cargar en la base de datos
        /// </summary>
        /// <param name="pNombre">Nombre del usuario</param>
        /// <param name="pApellido">Apellido del usuario</param>
        /// <param name="pFechaNacimiento">Fecha de nacimiento del usuario</param>
        /// <param name="pNombreUsuario">Nombre de usuario del usuario</param>
        /// <param name="pContrasenia">Contraseña del usuario</param>
        public static void RegistrarUsuario(string pNombre, string pApellido, TimeSpan pFechaNacimiento, string pNombreUsuario, string pContrasenia)
        {
            Usuario unUsuario = new Usuario(pNombre, pApellido, pFechaNacimiento, pNombreUsuario, pContrasenia);

        }

        #endregion

    }
}
