using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.DAL.EntityFramework
{
    public class LibroManagerDbContext : DbContext
    {
        public DbSet<Dominio.Autor> Autores { get; set; }

        public DbSet<Dominio.Publicador> Publicadores { get; set; }

        public DbSet<Dominio.Libro> Libro { get; set; }
    }
}
