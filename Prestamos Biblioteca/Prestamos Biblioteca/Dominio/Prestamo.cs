using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Biblioteca.Dominio
{

    public class Prestamo
    {
        private int iNumero;
        private Usuario iUsuario;
        private Ejemplar iEjemplar;
        private TimeSpan iFechaInicio;
        private TimeSpan iFechaDevolucionEstimada;
        private TimeSpan? iFechaDevolucionEfectiva;
        private EstadoDevolucion iCondicionDevolucion;
        private string iComentarios;


        public Prestamo(int pNumero, Usuario pUsuario, Ejemplar pEjemplar, TimeSpan pFechaInicio, TimeSpan pFechaDevolucionEstimada)
        {
            this.iNumero = pNumero;
            this.iUsuario = pUsuario;
            this.iEjemplar = pEjemplar;
            this.iFechaInicio = pFechaInicio;
            this.iFechaDevolucionEstimada = pFechaDevolucionEstimada;
            this.iFechaDevolucionEfectiva = null;
            this.iCondicionDevolucion = EstadoDevolucion.sinDevolver;
            this.iComentarios = "";
        }

        public int Numero
        {
            get { return this.iNumero; }
            private set { }
        }
        public Usuario Usuario
        {
            get { return this.iUsuario; }
            private set { }
        }

        public Ejemplar Ejemplar
        {
            get { return this.iEjemplar; }
            private set { }
        }

        public TimeSpan FechaInicio
        {
            get { return this.iFechaInicio; }
            private set { }
        }

        public TimeSpan FechaDevolucionEstimada
        {
            get { return this.iFechaDevolucionEstimada; }
            private set { }
        }

        public TimeSpan? FechaDevolucionEfectiva
        {
            get { return this.iFechaDevolucionEfectiva; }
            private set { }
        }

        public EstadoDevolucion CondicionDevolucion
        {
            get { return this.iCondicionDevolucion; }
            private set { }
        }

        public string Comentarios
        {
            get { return this.iComentarios; }
            private set { }
        }

        public void AsignarFechaDevolucionEfectiva(TimeSpan pFechaDevolucionEfectiva)
        {
            this.FechaDevolucionEfectiva = pFechaDevolucionEfectiva;
        }

        public void AgregarComentarios(string pComentarios)
        {
            this.iComentarios = pComentarios;
        }

        public void AsignarCondicionDevolucion(EstadoDevolucion pCondicionDevolucion)
        {
            this.iCondicionDevolucion = pCondicionDevolucion;
        }
    }

}
