using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
    public class Usuario
    {
        public int DNI { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public TimeSpan FechaDeNacimiento { get; set; }

        public bool EsAdministrador { get; set; }

    }
}
