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

namespace GUIPrestamosBiblioteca
{
    public partial class IniciarSesion : Form
    {
        #region Constructor

        public IniciarSesion()
        {
            InitializeComponent();
        }

        #endregion


        #region Botones

        /// <summary>
        /// Consulta si el nombreUsuario se corresponde con la constraseña y abre una ventana del tipo <see cref="MenuPrincipal"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iniciarSesionBoton_Click(object sender, EventArgs e)
        {
            try
            {
                // Recolecta los datos ingresados por el usuario
                string nombreUsuario = nombreUsuarioTextbox.Text;
                string contrasenia = contraseniaTextbox.Text;

                // Variable que almacena si el usuario fue autenticado o no
                bool usuarioVerificado = Fachada.VerificarUsuarioYContrasenia(nombreUsuario, contrasenia);

                // *****************************************************************
                // Para poder ingresar a la otra ventana a hacer pruebas se pone la
                // variable en True, hay que cambiarlo despues (TODO)
                usuarioVerificado = true;
                // *****************************************************************

                if (!usuarioVerificado)
                    throw new InvalidOperationException("El usuario o la contraseña no son correctos, intente nuevamente");
                else
                {
                    // Escondemos esta ventana
                    this.Hide();

                    // Creamos una instancia de la ventana MenuPrincipal
                    MenuPrincipal unMenu = new MenuPrincipal();

                    // Mostramos la instancia de la ventana creada
                    unMenu.ShowDialog();

                    // Cuando se cierra la instancia anterior, volvemos a mostrar la ventana de IniciarSesion
                    this.Show();
                }

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

        /// <summary>
        /// Consulta si el nombreUsuario se corresponde con la constraseña y abre una ventana del tipo <see cref="NuevoUsuarioAdmin"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevoUsuarioBoton_Click(object sender, EventArgs e)
        {
            try
            {
                // Recolecta los datos ingresados por el usuario
                string nombreUsuario = nombreUsuarioTextbox.Text;
                string contrasenia = contraseniaTextbox.Text;

                // Variable que almacena si el usuario fue autenticado
                bool usuarioVerificado = Fachada.VerificarUsuarioYContrasenia(nombreUsuario, contrasenia);

                // *****************************************************************
                // Para poder ingresar a la otra ventana a hacer pruebas se pone la
                // variable en True, hay que cambiarlo despues (TODO)
                usuarioVerificado = true;
                // *****************************************************************

                if (!usuarioVerificado)
                    throw new InvalidOperationException("El usuario o la contraseña no son correctos, intente nuevamente");
                else
                {
                    // Escondemos esta ventana
                    this.Hide();

                    // Creamos una instancia de la ventana NuevoUsuario
                    NuevoUsuarioAdmin unMenu = new NuevoUsuarioAdmin();

                    // Mostramos la instancia de la ventana creada
                    unMenu.ShowDialog();

                    // Cuando se cierra la instancia anterior, volvemos a mostrar la ventana de IniciarSesion
                    this.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        #endregion

    }
}
