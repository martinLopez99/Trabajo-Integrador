using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Encriptacion
{
    class EncriptadorNulo : Encriptador
    {
        public EncriptadorNulo()
            : base("Null")
        {

        }

        public override string Encriptar(string pCadena)
        {
            return pCadena;
        }

    }
}
