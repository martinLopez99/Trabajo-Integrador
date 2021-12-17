using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.DAL.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly LibroManagerDbContext iDbContext;

        private bool iDisposedValue = false;

        public UnitOfWork(LibroManagerDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new NotImplementedException();
            }

            this.iDbContext = pDbContext;
            //this.LibroRepository = new LibroRepository(pDbContext);
            //this.UsuarioRepository = new UsuarioRepository(pDbContext);
        }

        public ILibroRepository LibroRepository { get; private set; }

        public IUsuarioRepository UsuarioRepository { get; private set; }

        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }

        protected virtual void Dispose(bool pDisposing)
        {
            if (!this.iDisposedValue)
            {
                if (pDisposing)
                {
                    this.iDbContext.Dispose();
                }

                this.iDisposedValue = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

    }
}
