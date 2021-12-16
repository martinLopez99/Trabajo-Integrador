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
using System.Text.RegularExpressions;

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
            // Recolecta la informacion ingresada y la almacena en variables temporales           
            string nombre = nombreTextbox.Text;
            string apellido = apellidoTextbox.Text;
            TimeSpan fechaNacimiento = TimeSpan.Parse(fechaNacimientoDatePicker.Text);
            string nombreUsuario = nombreUsuarioTextbox.Text;
            string contrasenia = contraseniaTextbox.Text;
            string contrasenia2 = contrasenia2Textbox.Text;

            try
            {
                // Chequea si los datos ingresados son validos
                if (ChequearPorCaracteresEspecialesYNumeros(nombre))
                    throw new InvalidOperationException("El campo de nombre solo puede contener letras (A-Z ; a-z)");

                if (ChequearPorCaracteresEspecialesYNumeros(apellido))
                    throw new InvalidOperationException("El campo de nombre solo puede contener letras (A-Z ; a-z)");

                if (ChequearPorCaracteresEspeciales(nombreUsuario))
                    throw new InvalidOperationException("El campo de nombre solo puede contener letras o numeros (A-Z ; a-z ; 0-9)");

                //Chequeamos si las contraseñas coinciden
                if (contrasenia != contrasenia2)
                    throw new InvalidOperationException("Las contraseñas no coinciden");

                Fachada.RegistrarUsuario(nombre, apellido, fechaNacimiento, nombreUsuario, contrasenia);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                throw;
            }
            
        }

        #region Metodos Privados Auxiliares

        /// <summary>
        /// Chequea si la cadena ingresada contiene caracteres especiales
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>Devuelve true si la cadena contiene caracteres especiales</returns>
        private bool ChequearPorCaracteresEspeciales(string pCadena)
        {
            // Expresion regular para controlar que la cadena no tenga caracteres especiales 
            Regex rgx = new Regex("[A-Za-z0-9]");

            // Chequea si la cadena se ajusta a la expresion regular
            bool containsSpecialChars = rgx.IsMatch(pCadena);

            return containsSpecialChars;
        }

        /// <summary>
        /// Chequea si la cadena ingresada contiene caracteres especiales o numeros
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>Devuelve true si la cadena contiene caracteres especiales o numeros</returns>
        private bool ChequearPorCaracteresEspecialesYNumeros(string pCadena)
        {
            // Expresion regular para controlar que la cadena no tenga caracteres especiales o numeros
            Regex rgx = new Regex("[A-Za-z]");

            // Chequea si la cadena se ajusta a la expresion regular
            bool containsSpecialCharsOrNums = rgx.IsMatch(pCadena);

            return containsSpecialCharsOrNums;
        }


        #endregion
    }
}
