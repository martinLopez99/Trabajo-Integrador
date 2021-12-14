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
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iniciarSesionBoton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal unMenu = new MenuPrincipal();
            unMenu.ShowDialog();
            this.Show();
        }

        private void salirBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
