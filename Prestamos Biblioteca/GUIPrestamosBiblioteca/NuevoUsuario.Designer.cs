
namespace GUIPrestamosBiblioteca
{
    partial class NuevoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tituloPrincipal = new System.Windows.Forms.Label();
            this.contraseniaTextbox = new System.Windows.Forms.TextBox();
            this.nombreUsuarioTextbox = new System.Windows.Forms.TextBox();
            this.contrasenia = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.nombreTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.apellidoTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contrasenia2Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registrarUsuarioBoton = new System.Windows.Forms.Button();
            this.salirBoton = new System.Windows.Forms.Button();
            this.fechaNacimientoDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tituloPrincipal
            // 
            this.tituloPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tituloPrincipal.AutoSize = true;
            this.tituloPrincipal.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloPrincipal.Location = new System.Drawing.Point(207, 9);
            this.tituloPrincipal.Name = "tituloPrincipal";
            this.tituloPrincipal.Size = new System.Drawing.Size(220, 33);
            this.tituloPrincipal.TabIndex = 11;
            this.tituloPrincipal.Text = "Crear un Nuevo Usuario";
            // 
            // contraseniaTextbox
            // 
            this.contraseniaTextbox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contraseniaTextbox.Location = new System.Drawing.Point(269, 267);
            this.contraseniaTextbox.Name = "contraseniaTextbox";
            this.contraseniaTextbox.PasswordChar = '*';
            this.contraseniaTextbox.Size = new System.Drawing.Size(271, 27);
            this.contraseniaTextbox.TabIndex = 40;
            this.contraseniaTextbox.UseSystemPasswordChar = true;
            // 
            // nombreUsuarioTextbox
            // 
            this.nombreUsuarioTextbox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreUsuarioTextbox.Location = new System.Drawing.Point(269, 219);
            this.nombreUsuarioTextbox.Name = "nombreUsuarioTextbox";
            this.nombreUsuarioTextbox.Size = new System.Drawing.Size(271, 27);
            this.nombreUsuarioTextbox.TabIndex = 30;
            // 
            // contrasenia
            // 
            this.contrasenia.AutoSize = true;
            this.contrasenia.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contrasenia.Location = new System.Drawing.Point(166, 270);
            this.contrasenia.Name = "contrasenia";
            this.contrasenia.Size = new System.Drawing.Size(97, 19);
            this.contrasenia.TabIndex = 13;
            this.contrasenia.Text = "Contraseña:";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreUsuario.Location = new System.Drawing.Point(109, 222);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(154, 19);
            this.nombreUsuario.TabIndex = 12;
            this.nombreUsuario.Text = "Nombre de Usuario:";
            // 
            // nombreTextbox
            // 
            this.nombreTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextbox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreTextbox.Location = new System.Drawing.Point(269, 77);
            this.nombreTextbox.Name = "nombreTextbox";
            this.nombreTextbox.Size = new System.Drawing.Size(271, 27);
            this.nombreTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(191, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // apellidoTextbox
            // 
            this.apellidoTextbox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apellidoTextbox.Location = new System.Drawing.Point(269, 122);
            this.apellidoTextbox.Name = "apellidoTextbox";
            this.apellidoTextbox.Size = new System.Drawing.Size(271, 27);
            this.apellidoTextbox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(191, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(98, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // contrasenia2Textbox
            // 
            this.contrasenia2Textbox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contrasenia2Textbox.Location = new System.Drawing.Point(269, 313);
            this.contrasenia2Textbox.Name = "contrasenia2Textbox";
            this.contrasenia2Textbox.PasswordChar = '*';
            this.contrasenia2Textbox.Size = new System.Drawing.Size(271, 27);
            this.contrasenia2Textbox.TabIndex = 50;
            this.contrasenia2Textbox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(111, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Repetir contraseña:";
            // 
            // registrarUsuarioBoton
            // 
            this.registrarUsuarioBoton.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registrarUsuarioBoton.Location = new System.Drawing.Point(269, 374);
            this.registrarUsuarioBoton.Name = "registrarUsuarioBoton";
            this.registrarUsuarioBoton.Size = new System.Drawing.Size(150, 33);
            this.registrarUsuarioBoton.TabIndex = 60;
            this.registrarUsuarioBoton.Text = "Crear Usuario";
            this.registrarUsuarioBoton.UseVisualStyleBackColor = true;
            this.registrarUsuarioBoton.Click += new System.EventHandler(this.registrarUsuarioBoton_Click);
            // 
            // salirBoton
            // 
            this.salirBoton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salirBoton.Location = new System.Drawing.Point(584, 421);
            this.salirBoton.Name = "salirBoton";
            this.salirBoton.Size = new System.Drawing.Size(88, 33);
            this.salirBoton.TabIndex = 70;
            this.salirBoton.Text = "Volver";
            this.salirBoton.UseVisualStyleBackColor = true;
            this.salirBoton.Click += new System.EventHandler(this.salirBoton_Click);
            // 
            // fechaNacimientoDatePicker
            // 
            this.fechaNacimientoDatePicker.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fechaNacimientoDatePicker.Location = new System.Drawing.Point(269, 172);
            this.fechaNacimientoDatePicker.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.fechaNacimientoDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fechaNacimientoDatePicker.Name = "fechaNacimientoDatePicker";
            this.fechaNacimientoDatePicker.Size = new System.Drawing.Size(271, 26);
            this.fechaNacimientoDatePicker.TabIndex = 20;
            this.fechaNacimientoDatePicker.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // NuevoUsuario
            // 
            this.AcceptButton = this.salirBoton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 466);
            this.Controls.Add(this.fechaNacimientoDatePicker);
            this.Controls.Add(this.salirBoton);
            this.Controls.Add(this.registrarUsuarioBoton);
            this.Controls.Add(this.contrasenia2Textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apellidoTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraseniaTextbox);
            this.Controls.Add(this.nombreUsuarioTextbox);
            this.Controls.Add(this.contrasenia);
            this.Controls.Add(this.nombreUsuario);
            this.Controls.Add(this.tituloPrincipal);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 505);
            this.Name = "NuevoUsuario";
            this.Text = "NuevoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloPrincipal;
        private System.Windows.Forms.TextBox contraseniaTextbox;
        private System.Windows.Forms.TextBox nombreUsuarioTextbox;
        private System.Windows.Forms.Label contrasenia;
        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.TextBox nombreTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apellidoTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contrasenia2Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registrarUsuarioBoton;
        private System.Windows.Forms.Button salirBoton;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDatePicker;
    }
}