using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
    public class UsuarioAdmin
    {
        #region Atributos Privados

        private string iNombre;
        private string iApellido;
        private string nombreUsuario;
        private string contrasenia;

        #endregion

        #region Constructores

        public UsuarioAdmin(string pNombre, string pApellido, string pNombreUsuario, string pContrasenia)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.nombreUsuario = pNombreUsuario;
            this.contrasenia = pContrasenia;
        }

        #endregion

        #region Propiedades Publicas

        public string Nombre
        {
            get { return this.iNombre; }
            private set { }
        }

        public string Apellido
        {
            get { return this.iApellido; }
            private set { }
        }

        public string NombreUsuario
        {
            get { return this.nombreUsuario; }
            private set { }
        }

        public string Contrasenia
        {
            get { return this.contrasenia; }
            private set { }
        }

        #endregion


    }
}
