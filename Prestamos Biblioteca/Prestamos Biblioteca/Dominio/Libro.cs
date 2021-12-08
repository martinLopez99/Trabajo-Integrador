using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{
    public class Libro
    {


        public int ISBN10 { get; set; }

        public string Titulo { get; set; }

        public string SubTitulo { get; set; }

        public List<Autor> Autores { get; set; }

        public List<Publicador> Publicadores { get; set; }

        public List<Tematica> Tematicas { get; set; }

        public List<Ejemplar> Ejemplares { get; set; }

    }
}
