using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
   public class Usuario
    {
        #region Atributos Privados

        private string iDNI;
        private string iNombre;
        private string iApellido;
        private string iEmail;
        private TimeSpan iFechaNacimiento;
        private int iPuntaje;

        #endregion

        #region Constructores

        public Usuario( string pDNI, string pNombre, string pApellido, string pEmail, TimeSpan pFechaNacimiento)
        {
            this.iDNI = pDNI;
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iEmail = pEmail;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iPuntaje = 0;
        }

        #endregion

        #region Propiedades Publicas

        public string DNI
        {
            get { return this.iDNI; }
            private set { }
        }

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

        public string Email
        {
            get { return this.iEmail; }
            private set { }
        }

        public TimeSpan FechaNacimiento
        {
            get { return this.iFechaNacimiento; }
            private set { }
        }

        public int Puntaje
        {
            get { return this.iPuntaje; }
            set { this.iPuntaje = value; }
        }

        #endregion

    }

}
