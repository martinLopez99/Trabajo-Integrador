
namespace GUIPrestamosBiblioteca
{
    partial class RegistrarPrestamo
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
            this.fechaInicioPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.salirBoton = new System.Windows.Forms.Button();
            this.registrarPrestamoBoton = new System.Windows.Forms.Button();
            this.tituloPrincipal = new System.Windows.Forms.Label();
            this.fechaEstimadaFinPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dniBusquedaTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nombreResultadoLabel = new System.Windows.Forms.Label();
            this.apellidoResultadoLabel = new System.Windows.Forms.Label();
            this.emailResultadoLabel = new System.Windows.Forms.Label();
            this.buscarUsuarioBoton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buscarLibroBoton = new System.Windows.Forms.Button();
            this.subtituloResultadoLabel = new System.Windows.Forms.Label();
            this.tituloResultadoLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.isbnBusquedaTextbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fechaInicioPicker
            // 
            this.fechaInicioPicker.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fechaInicioPicker.Location = new System.Drawing.Point(167, 90);
            this.fechaInicioPicker.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.fechaInicioPicker.MinDate = new System.DateTime(2021, 12, 18, 0, 0, 0, 0);
            this.fechaInicioPicker.Name = "fechaInicioPicker";
            this.fechaInicioPicker.Size = new System.Drawing.Size(309, 27);
            this.fechaInicioPicker.TabIndex = 10;
            this.fechaInicioPicker.Value = new System.DateTime(2021, 12, 18, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(62, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 87;
            this.label4.Text = "Fecha Inicio:";
            // 
            // salirBoton
            // 
            this.salirBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.salirBoton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salirBoton.Location = new System.Drawing.Point(1017, 492);
            this.salirBoton.Name = "salirBoton";
            this.salirBoton.Size = new System.Drawing.Size(88, 33);
            this.salirBoton.TabIndex = 80;
            this.salirBoton.Text = "Volver";
            this.salirBoton.UseVisualStyleBackColor = true;
            this.salirBoton.Click += new System.EventHandler(this.salirBoton_Click);
            // 
            // registrarPrestamoBoton
            // 
            this.registrarPrestamoBoton.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registrarPrestamoBoton.Location = new System.Drawing.Point(465, 461);
            this.registrarPrestamoBoton.Name = "registrarPrestamoBoton";
            this.registrarPrestamoBoton.Size = new System.Drawing.Size(169, 41);
            this.registrarPrestamoBoton.TabIndex = 70;
            this.registrarPrestamoBoton.Text = "Registrar Prestamo";
            this.registrarPrestamoBoton.UseVisualStyleBackColor = true;
            this.registrarPrestamoBoton.Click += new System.EventHandler(this.registrarPrestamoBoton_Click);
            // 
            // tituloPrincipal
            // 
            this.tituloPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tituloPrincipal.AutoSize = true;
            this.tituloPrincipal.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloPrincipal.Location = new System.Drawing.Point(424, 9);
            this.tituloPrincipal.Name = "tituloPrincipal";
            this.tituloPrincipal.Size = new System.Drawing.Size(245, 33);
            this.tituloPrincipal.TabIndex = 78;
            this.tituloPrincipal.Text = "Registrar Nuevo Prestamo";
            // 
            // fechaEstimadaFinPicker
            // 
            this.fechaEstimadaFinPicker.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fechaEstimadaFinPicker.Location = new System.Drawing.Point(717, 90);
            this.fechaEstimadaFinPicker.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.fechaEstimadaFinPicker.MinDate = new System.DateTime(2021, 12, 18, 0, 0, 0, 0);
            this.fechaEstimadaFinPicker.Name = "fechaEstimadaFinPicker";
            this.fechaEstimadaFinPicker.Size = new System.Drawing.Size(309, 27);
            this.fechaEstimadaFinPicker.TabIndex = 20;
            this.fechaEstimadaFinPicker.Value = new System.DateTime(2021, 12, 18, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(556, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 90;
            this.label1.Text = "Fecha Estimada Fin:";
            // 
            // dniBusquedaTextbox
            // 
            this.dniBusquedaTextbox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dniBusquedaTextbox.Location = new System.Drawing.Point(167, 157);
            this.dniBusquedaTextbox.Name = "dniBusquedaTextbox";
            this.dniBusquedaTextbox.Size = new System.Drawing.Size(309, 27);
            this.dniBusquedaTextbox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 92;
            this.label2.Text = "DNI Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(109, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 96;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(94, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 94;
            this.label6.Text = "Apellido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(96, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 93;
            this.label7.Text = "Nombre:";
            // 
            // nombreResultadoLabel
            // 
            this.nombreResultadoLabel.AutoSize = true;
            this.nombreResultadoLabel.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreResultadoLabel.Location = new System.Drawing.Point(167, 292);
            this.nombreResultadoLabel.Name = "nombreResultadoLabel";
            this.nombreResultadoLabel.Size = new System.Drawing.Size(18, 19);
            this.nombreResultadoLabel.TabIndex = 97;
            this.nombreResultadoLabel.Text = "...";
            // 
            // apellidoResultadoLabel
            // 
            this.apellidoResultadoLabel.AutoSize = true;
            this.apellidoResultadoLabel.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apellidoResultadoLabel.Location = new System.Drawing.Point(167, 334);
            this.apellidoResultadoLabel.Name = "apellidoResultadoLabel";
            this.apellidoResultadoLabel.Size = new System.Drawing.Size(18, 19);
            this.apellidoResultadoLabel.TabIndex = 98;
            this.apellidoResultadoLabel.Text = "...";
            // 
            // emailResultadoLabel
            // 
            this.emailResultadoLabel.AutoSize = true;
            this.emailResultadoLabel.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailResultadoLabel.Location = new System.Drawing.Point(167, 374);
            this.emailResultadoLabel.Name = "emailResultadoLabel";
            this.emailResultadoLabel.Size = new System.Drawing.Size(18, 19);
            this.emailResultadoLabel.TabIndex = 99;
            this.emailResultadoLabel.Text = "...";
            // 
            // buscarUsuarioBoton
            // 
            this.buscarUsuarioBoton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buscarUsuarioBoton.Location = new System.Drawing.Point(250, 190);
            this.buscarUsuarioBoton.Name = "buscarUsuarioBoton";
            this.buscarUsuarioBoton.Size = new System.Drawing.Size(127, 30);
            this.buscarUsuarioBoton.TabIndex = 40;
            this.buscarUsuarioBoton.Text = "Buscar Usuario";
            this.buscarUsuarioBoton.UseVisualStyleBackColor = true;
            this.buscarUsuarioBoton.Click += new System.EventHandler(this.buscarUsuarioBoton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(167, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 101;
            this.label3.Text = "Datos del Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(717, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 19);
            this.label8.TabIndex = 111;
            this.label8.Text = "Datos del Libro";
            // 
            // buscarLibroBoton
            // 
            this.buscarLibroBoton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buscarLibroBoton.Location = new System.Drawing.Point(800, 190);
            this.buscarLibroBoton.Name = "buscarLibroBoton";
            this.buscarLibroBoton.Size = new System.Drawing.Size(127, 30);
            this.buscarLibroBoton.TabIndex = 60;
            this.buscarLibroBoton.Text = "Buscar Libro";
            this.buscarLibroBoton.UseVisualStyleBackColor = true;
            this.buscarLibroBoton.Click += new System.EventHandler(this.buscarLibroBoton_Click);
            // 
            // subtituloResultadoLabel
            // 
            this.subtituloResultadoLabel.AutoSize = true;
            this.subtituloResultadoLabel.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtituloResultadoLabel.Location = new System.Drawing.Point(717, 334);
            this.subtituloResultadoLabel.Name = "subtituloResultadoLabel";
            this.subtituloResultadoLabel.Size = new System.Drawing.Size(18, 19);
            this.subtituloResultadoLabel.TabIndex = 108;
            this.subtituloResultadoLabel.Text = "...";
            // 
            // tituloResultadoLabel
            // 
            this.tituloResultadoLabel.AutoSize = true;
            this.tituloResultadoLabel.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tituloResultadoLabel.Location = new System.Drawing.Point(717, 292);
            this.tituloResultadoLabel.Name = "tituloResultadoLabel";
            this.tituloResultadoLabel.Size = new System.Drawing.Size(18, 19);
            this.tituloResultadoLabel.TabIndex = 107;
            this.tituloResultadoLabel.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(644, 334);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 19);
            this.label13.TabIndex = 105;
            this.label13.Text = "Subtitulo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(664, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 19);
            this.label14.TabIndex = 104;
            this.label14.Text = "Titulo:";
            // 
            // isbnBusquedaTextbox
            // 
            this.isbnBusquedaTextbox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isbnBusquedaTextbox.Location = new System.Drawing.Point(717, 157);
            this.isbnBusquedaTextbox.Name = "isbnBusquedaTextbox";
            this.isbnBusquedaTextbox.Size = new System.Drawing.Size(309, 27);
            this.isbnBusquedaTextbox.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(612, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 19);
            this.label15.TabIndex = 103;
            this.label15.Text = "ISBN Libro:";
            // 
            // RegistrarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 537);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buscarLibroBoton);
            this.Controls.Add(this.subtituloResultadoLabel);
            this.Controls.Add(this.tituloResultadoLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.isbnBusquedaTextbox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buscarUsuarioBoton);
            this.Controls.Add(this.emailResultadoLabel);
            this.Controls.Add(this.apellidoResultadoLabel);
            this.Controls.Add(this.nombreResultadoLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dniBusquedaTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaEstimadaFinPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaInicioPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salirBoton);
            this.Controls.Add(this.registrarPrestamoBoton);
            this.Controls.Add(this.tituloPrincipal);
            this.Name = "RegistrarPrestamo";
            this.Text = "RegistrarPrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaInicioPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button salirBoton;
        private System.Windows.Forms.Button registrarPrestamoBoton;
        private System.Windows.Forms.Label tituloPrincipal;
        private System.Windows.Forms.DateTimePicker fechaEstimadaFinPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dniBusquedaTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nombreResultadoLabel;
        private System.Windows.Forms.Label apellidoResultadoLabel;
        private System.Windows.Forms.Label emailResultadoLabel;
        private System.Windows.Forms.Button buscarUsuarioBoton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buscarLibroBoton;
        private System.Windows.Forms.Label subtituloResultadoLabel;
        private System.Windows.Forms.Label tituloResultadoLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox isbnBusquedaTextbox;
        private System.Windows.Forms.Label label15;
    }
}