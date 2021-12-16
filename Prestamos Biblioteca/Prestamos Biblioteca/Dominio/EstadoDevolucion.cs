using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
    /// <summary>
    /// Un tipo de estado en el que un <see cref="Ejemplar"/> fue devuelto
    /// </summary>
    public enum EstadoDevolucion
    {
        enBuenEstado,
        enMalEstado,
        sinDevolver             //Cuando el ejemplar todavia no ha sido devuelto
    }
}
