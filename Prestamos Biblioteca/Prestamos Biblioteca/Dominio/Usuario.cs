using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{

    public class Usuario
    {
        private int iDNI;
        private string iNombre;
        private string iApellido;
        private string iEmail;
        private TimeSpan iFechaNacimiento;
        private bool iEsAdminsitrador;

        public Usuario(int pDNI, string pNombre, string pApellido, string pEmail, TimeSpan pFechaNacimiento, bool pEsAdministrador)
        {
            this.iDNI = pDNI;
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iEmail = pEmail;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iEsAdminsitrador = pEsAdministrador;
        }

        public int DNI
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

        public bool EsAdministrador
        {
            get { return this.iEsAdminsitrador; }
            private set { }
        }

    }

}
