using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.DAL.EntityFramework
{
    public class LibroRepository : Repository<Dominio.Libro, LibroManagerDbContext>,ILibroRepository
    {
        public LibroRepository(LibroManagerDbContext pDbContext) : base(pDbContext)
        {

        }
    }
}
