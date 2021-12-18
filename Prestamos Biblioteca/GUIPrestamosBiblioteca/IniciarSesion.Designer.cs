
namespace GUIPrestamosBiblioteca
{
    partial class IniciarSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tituloPrincipal = new System.Windows.Forms.Label();
            this.iniciarSesionBoton = new System.Windows.Forms.Button();
            this.salirBoton = new System.Windows.Forms.Button();
            this.nombreUsuarioTextbox = new System.Windows.Forms.TextBox();
            this.contrasenia = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.contraseniaTextbox = new System.Windows.Forms.TextBox();
            this.nuevoUsuarioBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tituloPrincipal
            // 
            this.tituloPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tituloPrincipal.AutoSize = true;
            this.tituloPrincipal.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloPrincipal.Location = new System.Drawing.Point(139, 9);
            this.tituloPrincipal.Name = "tituloPrincipal";
            this.tituloPrincipal.Size = new System.Drawing.Size(497, 35);
            this.tituloPrincipal.TabIndex = 0;
            this.tituloPrincipal.Text = "Bienvenido a la App de Prestamos de la Biblioteca";
            // 
            // iniciarSesionBoton
            // 
            this.iniciarSesionBoton.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iniciarSesionBoton.Location = new System.Drawing.Point(357, 184);
            this.iniciarSesionBoton.Name = "iniciarSesionBoton";
            this.iniciarSesionBoton.Size = new System.Drawing.Size(130, 43);
            this.iniciarSesionBoton.TabIndex = 30;
            this.iniciarSesionBoton.Text = "Iniciar Sesión";
            this.iniciarSesionBoton.UseVisualStyleBackColor = true;
            this.iniciarSesionBoton.Click += new System.EventHandler(this.iniciarSesionBoton_Click);
            // 
            // salirBoton
            // 
            this.salirBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.salirBoton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salirBoton.Location = new System.Drawing.Point(710, 268);
            this.salirBoton.Name = "salirBoton";
            this.salirBoton.Size = new System.Drawing.Size(88, 33);
            this.salirBoton.TabIndex = 50;
            this.salirBoton.Text = "Salir";
            this.salirBoton.UseVisualStyleBackColor = true;
            this.salirBoton.Click += new System.EventHandler(this.salirBoton_Click);
            // 
            // nombreUsuarioTextbox
            // 
            this.nombreUsuarioTextbox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreUsuarioTextbox.Location = new System.Drawing.Point(342, 82);
            this.nombreUsuarioTextbox.Name = "nombreUsuarioTextbox";
            this.nombreUsuarioTextbox.Size = new System.Drawing.Size(196, 27);
            this.nombreUsuarioTextbox.TabIndex = 10;
            // 
            // contrasenia
            // 
            this.contrasenia.AutoSize = true;
            this.contrasenia.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contrasenia.Location = new System.Drawing.Point(239, 133);
            this.contrasenia.Name = "contrasenia";
            this.contrasenia.Size = new System.Drawing.Size(97, 19);
            this.contrasenia.TabIndex = 4;
            this.contrasenia.Text = "Contraseña:";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreUsuario.Location = new System.Drawing.Point(182, 85);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(154, 19);
            this.nombreUsuario.TabIndex = 3;
            this.nombreUsuario.Text = "Nombre de Usuario:";
            // 
            // contraseniaTextbox
            // 
            this.contraseniaTextbox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contraseniaTextbox.Location = new System.Drawing.Point(342, 130);
            this.contraseniaTextbox.Name = "contraseniaTextbox";
            this.contraseniaTextbox.PasswordChar = '*';
            this.contraseniaTextbox.Size = new System.Drawing.Size(196, 27);
            this.contraseniaTextbox.TabIndex = 20;
            this.contraseniaTextbox.UseSystemPasswordChar = true;
            // 
            // nuevoUsuarioBoton
            // 
            this.nuevoUsuarioBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nuevoUsuarioBoton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nuevoUsuarioBoton.ForeColor = System.Drawing.Color.Black;
            this.nuevoUsuarioBoton.Location = new System.Drawing.Point(26, 268);
            this.nuevoUsuarioBoton.Name = "nuevoUsuarioBoton";
            this.nuevoUsuarioBoton.Size = new System.Drawing.Size(186, 33);
            this.nuevoUsuarioBoton.TabIndex = 40;
            this.nuevoUsuarioBoton.Text = "Crear un Usuario Administrador";
            this.nuevoUsuarioBoton.UseVisualStyleBackColor = true;
            this.nuevoUsuarioBoton.Click += new System.EventHandler(this.nuevoUsuarioBoton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 57);
            this.label1.TabIndex = 51;
            this.label1.Text = "Para crear un nuevo Usuario \r\nAdministrador, debe ingresar \r\nsus credenciales pri" +
    "mero";
            // 
            // IniciarSesion
            // 
            this.AcceptButton = this.salirBoton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(810, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuevoUsuarioBoton);
            this.Controls.Add(this.contraseniaTextbox);
            this.Controls.Add(this.nombreUsuarioTextbox);
            this.Controls.Add(this.contrasenia);
            this.Controls.Add(this.nombreUsuario);
            this.Controls.Add(this.salirBoton);
            this.Controls.Add(this.iniciarSesionBoton);
            this.Controls.Add(this.tituloPrincipal);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(825, 350);
            this.Name = "IniciarSesion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloPrincipal;
        private System.Windows.Forms.Button iniciarSesionBoton;
        private System.Windows.Forms.Button salirBoton;
        private System.Windows.Forms.TextBox nombreUsuarioTextbox;
        private System.Windows.Forms.Label contrasenia;
        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.TextBox contraseniaTextbox;
        private System.Windows.Forms.Button nuevoUsuarioBoton;
        private System.Windows.Forms.Label label1;
    }
}

