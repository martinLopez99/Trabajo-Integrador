using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPrestamosBiblioteca
{
    public partial class MenuPrincipal : Form
    {
        #region Constructor

        public MenuPrincipal()
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
        private void cerrarSesionBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Abre una nueva ventana <see cref="NuevoUsuario"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrarUsuarioBoton_Click(object sender, EventArgs e)
        {
            // Escondemos esta ventana
            this.Hide();

            // Creamos una instancia de la ventana MenuPrincipal
            NuevoUsuario unMenu = new NuevoUsuario();

            // Mostramos la instancia de la ventana creada
            unMenu.ShowDialog();

            // Cuando se cierra la instancia anterior, volvemos a mostrar la ventana de MenuPrincipal
            this.Show();
        }


        private void buscarEnSistemaBoton_Click(object sender, EventArgs e)
        {

        }


        private void registrarPrestamoBoton_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
