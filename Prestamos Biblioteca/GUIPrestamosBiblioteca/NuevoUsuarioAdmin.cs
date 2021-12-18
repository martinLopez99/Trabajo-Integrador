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
using Prestamos_Biblioteca.Funciones_Auxiliares;

namespace GUIPrestamosBiblioteca
{
    /// <summary>
    /// GUI encargada de recolectar informacion sobre un nuevo usuario administrador
    /// </summary>
    public partial class NuevoUsuarioAdmin : Form
    {
        #region Constructor

        public NuevoUsuarioAdmin()
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
        /// Recolecta la informacion ingresada por el usuario y la envia a la fachada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrarUsuarioBoton_Click(object sender, EventArgs e)
        {
            try
            {
                // Recolecta la informacion ingresada y la almacena en variables temporales           
                string nombre = nombreTextbox.Text;
                string apellido = apellidoTextbox.Text;
                string nombreUsuario = nombreUsuarioTextbox.Text;
                string contrasenia = contraseniaTextbox.Text;
                string contrasenia2 = contrasenia2Textbox.Text;

                // Chequea si los datos ingresados son validos
                if (CheckStrings.ChequearPorCaracteresEspecialesYNumeros(nombre))
                    throw new InvalidOperationException("El campo de nombre solo puede contener letras (A-Z ; a-z)");

                if (CheckStrings.ChequearPorCaracteresEspecialesYNumeros(apellido))
                    throw new InvalidOperationException("El campo de apellido solo puede contener letras (A-Z ; a-z)");

                if (CheckStrings.ChequearPorCaracteresEspeciales(nombreUsuario))
                    throw new InvalidOperationException("El campo de nombre de usuario solo puede contener letras o numeros (A-Z ; a-z ; 0-9)");

                // Chequea si las contraseñas coinciden
                if (contrasenia != contrasenia2)
                    throw new InvalidOperationException("Las contraseñas no coinciden");

                // Enavia la informacion a la Fachada
                Fachada.RegistrarUsuarioAdmin(nombre, apellido, nombreUsuario, contrasenia);

                // Muestra mensaje en pantalla avisando al usuario 
                MessageBox.Show("El usuario ha sido creado con exito, inicie sesion desde la pantalla de inicio");

                // Cierra la pantalla de inicio de sesion
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
