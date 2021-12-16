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
    public partial class NuevoUsuario : Form
    {
        #region Constructor

        public NuevoUsuario()
        {
            InitializeComponent();
        }

        #endregion

        #region Botones

        private void label1_Click(object sender, EventArgs e)
        {

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

        #endregion

        /// <summary>
        /// Recolecta la informacion ingresada por el usuario y la envia a la fachada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrarUsuarioBoton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
