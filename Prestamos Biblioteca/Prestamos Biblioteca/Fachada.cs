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
        public static void RegistrarUsuario(string pNombre, string pApellido, TimeSpan pFechaNacimiento, string pNombreUsuario, string pContrasenia)
        {
            Usuario unUsuario = new Usuario(pNombre, pApellido, pFechaNacimiento, pNombreUsuario, pContrasenia);

        }
    }
}
