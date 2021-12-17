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
        
        #endregion 

    }
}
