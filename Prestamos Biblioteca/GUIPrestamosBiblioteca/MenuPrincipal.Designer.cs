
namespace GUIPrestamosBiblioteca
{
    partial class MenuPrincipal
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
            this.cerrarSesionBoton = new System.Windows.Forms.Button();
            this.registrarPrestamoBoton = new System.Windows.Forms.Button();
            this.registrarUsuarioBoton = new System.Windows.Forms.Button();
            this.buscarEnSistemaBoton = new System.Windows.Forms.Button();
            this.tituloPrincipal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cerrarSesionBoton
            // 
            this.cerrarSesionBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarSesionBoton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cerrarSesionBoton.Location = new System.Drawing.Point(711, 428);
            this.cerrarSesionBoton.Name = "cerrarSesionBoton";
            this.cerrarSesionBoton.Size = new System.Drawing.Size(111, 33);
            this.cerrarSesionBoton.TabIndex = 40;
            this.cerrarSesionBoton.Text = "Cerrar Sesión";
            this.cerrarSesionBoton.UseVisualStyleBackColor = true;
            this.cerrarSesionBoton.Click += new System.EventHandler(this.cerrarSesionBoton_Click);
            // 
            // registrarPrestamoBoton
            // 
            this.registrarPrestamoBoton.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registrarPrestamoBoton.Location = new System.Drawing.Point(59, 195);
            this.registrarPrestamoBoton.Name = "registrarPrestamoBoton";
            this.registrarPrestamoBoton.Size = new System.Drawing.Size(251, 43);
            this.registrarPrestamoBoton.TabIndex = 20;
            this.registrarPrestamoBoton.Text = "Registrar un Nuevo Prestamo";
            this.registrarPrestamoBoton.UseVisualStyleBackColor = true;
            // 
            // registrarUsuarioBoton
            // 
            this.registrarUsuarioBoton.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registrarUsuarioBoton.Location = new System.Drawing.Point(59, 113);
            this.registrarUsuarioBoton.Name = "registrarUsuarioBoton";
            this.registrarUsuarioBoton.Size = new System.Drawing.Size(251, 43);
            this.registrarUsuarioBoton.TabIndex = 10;
            this.registrarUsuarioBoton.Text = "Registrar un Nuevo Usuario";
            this.registrarUsuarioBoton.UseVisualStyleBackColor = true;
            // 
            // buscarEnSistemaBoton
            // 
            this.buscarEnSistemaBoton.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buscarEnSistemaBoton.Location = new System.Drawing.Point(532, 113);
            this.buscarEnSistemaBoton.Name = "buscarEnSistemaBoton";
            this.buscarEnSistemaBoton.Size = new System.Drawing.Size(198, 43);
            this.buscarEnSistemaBoton.TabIndex = 30;
            this.buscarEnSistemaBoton.Text = "Buscar en el Sistema";
            this.buscarEnSistemaBoton.UseVisualStyleBackColor = true;
            // 
            // tituloPrincipal
            // 
            this.tituloPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tituloPrincipal.AutoSize = true;
            this.tituloPrincipal.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloPrincipal.Location = new System.Drawing.Point(252, 26);
            this.tituloPrincipal.Name = "tituloPrincipal";
            this.tituloPrincipal.Size = new System.Drawing.Size(368, 33);
            this.tituloPrincipal.TabIndex = 10;
            this.tituloPrincipal.Text = "Seleccione la accion que desea realizar";
            // 
            // MenuPrincipal
            // 
            this.AcceptButton = this.cerrarSesionBoton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 473);
            this.Controls.Add(this.tituloPrincipal);
            this.Controls.Add(this.buscarEnSistemaBoton);
            this.Controls.Add(this.registrarUsuarioBoton);
            this.Controls.Add(this.registrarPrestamoBoton);
            this.Controls.Add(this.cerrarSesionBoton);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cerrarSesionBoton;
        private System.Windows.Forms.Button registrarPrestamoBoton;
        private System.Windows.Forms.Button registrarUsuarioBoton;
        private System.Windows.Forms.Button buscarEnSistemaBoton;
        private System.Windows.Forms.Label tituloPrincipal;
    }
}