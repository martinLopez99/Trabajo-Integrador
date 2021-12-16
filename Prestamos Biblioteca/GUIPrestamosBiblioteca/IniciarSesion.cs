﻿using System;
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
        #region Constructor

        public IniciarSesion()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Loader

        /// <summary>
        /// Carga la Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Botones

        /// <summary>
        /// Abrimos una ventana del tipo <see cref="MenuPrincipal"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iniciarSesionBoton_Click(object sender, EventArgs e)
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
        /// Abrimos una ventana del tipo <see cref="NuevoUsuario"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevoUsuarioBoton_Click(object sender, EventArgs e)
        {
            // Escondemos esta ventana
            this.Hide();

            // Creamos una instancia de la ventana NuevoUsuario
            NuevoUsuario unMenu = new NuevoUsuario();

            // Mostramos la instancia de la ventana creada
            unMenu.ShowDialog();

            // Cuando se cierra la instancia anterior, volvemos a mostrar la ventana de IniciarSesion
            this.Show();
        }

        #endregion
    }
}
