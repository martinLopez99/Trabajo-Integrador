using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prestamos_Biblioteca.Funciones_Auxiliares;
using Prestamos_Biblioteca;

namespace GUIPrestamosBiblioteca
{
    public partial class NuevoUsuario : Form
    {
        #region Constructor        

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        #endregion


        private void registrarUsuarioBoton_Click(object sender, EventArgs e)
        {
            try
            {
                // Recolecta la informacion ingresada y la almacena en variables temporales           
                string nombre = nombreTextbox.Text;
                string apellido = apellidoTextbox.Text;
                string dni = dniTextbox.Text;
                DateTime fechaNacimiento = fechaNacimientoPicker.Value;
                string email = emailTextbox.Text;

                // Chequea si los datos ingresados son validos
                if (CheckStrings.ChequearPorCaracteresEspecialesYNumeros(nombre))
                    throw new InvalidOperationException("El campo de nombre solo puede contener letras (A-Z ; a-z)");

                if (CheckStrings.ChequearPorCaracteresEspecialesYNumeros(apellido))
                    throw new InvalidOperationException("El campo de apellido solo puede contener letras (A-Z ; a-z)");

                if (CheckStrings.ChequearPorCaracteresEspecialesYLetras(dni))
                    throw new InvalidOperationException("El campo de DNI solo puede contener numeros (0-9)");

                if (CheckStrings.ChequearSiTieneFormatoEmail(email))
                    throw new InvalidOperationException("El email no tiene el formato correcto (ejemplo@email.com)");

                // Envia la informacion a la Fachada
                Fachada.RegistrarUsuario(nombre, apellido, dni, fechaNacimiento, email);

                // Muestra mensaje en pantalla avisando al usuario 
                MessageBox.Show("El usuario ha sido creado con exito");

                // Cierra la pantalla de inicio de sesion
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        /// <summary>
        /// Cierra la ventana actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
