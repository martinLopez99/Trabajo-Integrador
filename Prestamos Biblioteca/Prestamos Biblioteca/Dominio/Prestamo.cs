using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
    public class Prestamo
    {
        public int Numero { get; set; }

        public TimeSpan FechaInicio { get; set; }
        public TimeSpan FechaDevolucionEstimada { get; set; }
        public TimeSpan FechaDevolucionEfectiva { get; set; }
        public EstadoDevolucion CondicionDevolucion { get; set; }
        public string Comentario { get; set; }
    }
}
