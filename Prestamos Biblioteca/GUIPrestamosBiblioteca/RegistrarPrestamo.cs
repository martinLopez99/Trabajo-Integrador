using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prestamos_Biblioteca;
using Prestamos_Biblioteca.Dominio;
using Prestamos_Biblioteca.Funciones_Auxiliares;

namespace GUIPrestamosBiblioteca
{
    public partial class RegistrarPrestamo : Form
    {
        #region Constructor

        public RegistrarPrestamo()
        {
            InitializeComponent();
        }

        #endregion


        #region Botones

        /// <summary>
        /// Cierra la ventana actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Recolecta el DNI ingresado por el usuario y busca al <see cref="Usuario"/> correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buscarUsuarioBoton_Click(object sender, EventArgs e)
        {
            try
            {
                // Recolecta la informacion ingresada y la almacena en una variable temporal
                string dniUsuario = dniBusquedaTextbox.Text;

                // Chequea que el dato ingresado solo contiene numeros
                if (CheckStrings.ChequearPorCaracteresEspecialesYLetras(dniUsuario))
                    throw new InvalidOperationException("El campo de DNI solo puede contener numeros (0-9)");

                // Busca al usuario correspondiente con el dni ingresado
                Usuario usuarioActual = Fachada.BuscarUsuario(dniUsuario);

                // Asigna a las etiquetas en pantalla los datos del usuario
                this.nombreResultadoLabel.Text = usuarioActual.Nombre;
                this.apellidoResultadoLabel.Text = usuarioActual.Apellido;
                this.emailResultadoLabel.Text = usuarioActual.Email;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        /// <summary>
        /// Recolecta el ISBN ingresado por el usuario y busca al <see cref="Libro"/> correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buscarLibroBoton_Click(object sender, EventArgs e)
        {
            try
            {
                // Recolecta la informacion ingresada y la almacena en una variable temporal
                string isbnLibro = isbnBusquedaTextbox.Text;

                // Chequea que el dato ingresado solo contiene numeros
                if (CheckStrings.ChequearPorCaracteresEspeciales(isbnLibro))
                    throw new InvalidOperationException("El campo de ISBN solo puede contener numeros o letras (A-Z, a-z, 0-9)");

                // Busca el libro correspondiente con el isbn ingresado
                Libro libroActual = Fachada.BuscarLibro(isbnLibro);

                // Asigna a las etiquetas en pantalla los datos del usuario
                this.tituloResultadoLabel.Text = libroActual.title;
                this.subtituloResultadoLabel.Text = libroActual.subtitle;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

        }

        /// <summary>
        /// Recolecta la informacion ingresada por el usuario y la envia a la fachada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrarPrestamoBoton_Click(object sender, EventArgs e)
        {
            try
            {
                // Recolecta la informacion ingresada y la almacena en variables temporales           
                DateTime fechaInicio = fechaInicioPicker.Value;
                DateTime fechaFinEstimada = fechaEstimadaFinPicker.Value;

                // Chequea que las fechas no sean menor a la fecha actual
                if (fechaInicio < DateTime.Now || fechaFinEstimada < DateTime.Now)
                    throw new InvalidOperationException("La Fecha de Inicio y la Fecha Estimada de fin del Prestamo no " +
                        "pueden ser menores a la fecha de hoy");

                // Chequea que la fecha estimada de devolucion no sea menor a la fecha de inicio del prestamo
                if (fechaInicio >= fechaFinEstimada)
                    throw new InvalidOperationException("La Fecha de Inicio del Prestamo no " +
                        "puede ser mayor a la Fecha Estimada de Fin del Prestamo");

                // TODO: Recolecta el usuario ingresado

                // TODO: Recolecta el libro ingresado

                // Envia la informacion a la Fachada
                Fachada.RegistrarPrestamo(fechaInicio, fechaFinEstimada);

                // Muestra mensaje en pantalla avisando al usuario 
                MessageBox.Show("El Prestamo ha sido registrado con exito");

                // Cierra la pantalla actual
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        #endregion
    }
}
