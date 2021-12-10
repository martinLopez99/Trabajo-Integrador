using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.DAL
{
    public interface IUnitOfWork : IDisposable
    {

        ILibroRepository LibroRepository { get; }
        IUsuarioRepository UsuarioRepository { get; }

        void Complete();
    }
}
