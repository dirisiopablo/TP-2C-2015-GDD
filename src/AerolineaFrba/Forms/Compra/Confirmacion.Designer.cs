namespace AerolineaFrba.Forms.Compra {
    partial class Confirmacion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.medioDePagoCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.documentoTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.apellidoTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.direccionTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fechaNacimientoPicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numeroTextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.codigoTextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.vencimientoTextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cuotasCombo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.detalleTextbox = new System.Windows.Forms.TextBox();
            this.confirmarButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tipoCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // medioDePagoCombo
            // 
            this.medioDePagoCombo.FormattingEnabled = true;
            this.medioDePagoCombo.Location = new System.Drawing.Point(424, 137);
            this.medioDePagoCombo.Name = "medioDePagoCombo";
            this.medioDePagoCombo.Size = new System.Drawing.Size(110, 21);
            this.medioDePagoCombo.TabIndex = 0;
            this.medioDePagoCombo.SelectedIndexChanged += new System.EventHandler(this.medioDePagoCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medio de Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Documento:";
            // 
            // documentoTextbox
            // 
            this.documentoTextbox.Location = new System.Drawing.Point(92, 56);
            this.documentoTextbox.Name = "documentoTextbox";
            this.documentoTextbox.Size = new System.Drawing.Size(126, 20);
            this.documentoTextbox.TabIndex = 3;
            this.documentoTextbox.TextChanged += new System.EventHandler(this.documentoTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // nombreTextbox
            // 
            this.nombreTextbox.Location = new System.Drawing.Point(297, 56);
            this.nombreTextbox.Name = "nombreTextbox";
            this.nombreTextbox.Size = new System.Drawing.Size(189, 20);
            this.nombreTextbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido:";
            // 
            // apellidoTextbox
            // 
            this.apellidoTextbox.Location = new System.Drawing.Point(580, 56);
            this.apellidoTextbox.Name = "apellidoTextbox";
            this.apellidoTextbox.Size = new System.Drawing.Size(173, 20);
            this.apellidoTextbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección:";
            // 
            // direccionTextbox
            // 
            this.direccionTextbox.Location = new System.Drawing.Point(92, 100);
            this.direccionTextbox.Name = "direccionTextbox";
            this.direccionTextbox.Size = new System.Drawing.Size(192, 20);
            this.direccionTextbox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email:";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(91, 137);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(193, 20);
            this.emailTextbox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha de Nacimiento:";
            // 
            // fechaNacimientoPicker
            // 
            this.fechaNacimientoPicker.Location = new System.Drawing.Point(424, 100);
            this.fechaNacimientoPicker.Name = "fechaNacimientoPicker";
            this.fechaNacimientoPicker.Size = new System.Drawing.Size(204, 20);
            this.fechaNacimientoPicker.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Datos del comprador";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Datos de la tarjeta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Número:";
            // 
            // numeroTextbox
            // 
            this.numeroTextbox.Location = new System.Drawing.Point(92, 214);
            this.numeroTextbox.Name = "numeroTextbox";
            this.numeroTextbox.Size = new System.Drawing.Size(162, 20);
            this.numeroTextbox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Código de Seguridad:";
            // 
            // codigoTextbox
            // 
            this.codigoTextbox.Location = new System.Drawing.Point(375, 214);
            this.codigoTextbox.Name = "codigoTextbox";
            this.codigoTextbox.Size = new System.Drawing.Size(49, 20);
            this.codigoTextbox.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Vencimiento (MMAA):";
            // 
            // vencimientoTextbox
            // 
            this.vencimientoTextbox.Location = new System.Drawing.Point(555, 214);
            this.vencimientoTextbox.Name = "vencimientoTextbox";
            this.vencimientoTextbox.Size = new System.Drawing.Size(70, 20);
            this.vencimientoTextbox.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(227, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Cuotas:";
            // 
            // cuotasCombo
            // 
            this.cuotasCombo.FormattingEnabled = true;
            this.cuotasCombo.Location = new System.Drawing.Point(276, 249);
            this.cuotasCombo.Name = "cuotasCombo";
            this.cuotasCombo.Size = new System.Drawing.Size(56, 21);
            this.cuotasCombo.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Detalle de compra";
            // 
            // detalleTextbox
            // 
            this.detalleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalleTextbox.Location = new System.Drawing.Point(27, 340);
            this.detalleTextbox.Multiline = true;
            this.detalleTextbox.Name = "detalleTextbox";
            this.detalleTextbox.ReadOnly = true;
            this.detalleTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detalleTextbox.Size = new System.Drawing.Size(746, 192);
            this.detalleTextbox.TabIndex = 25;
            // 
            // confirmarButton
            // 
            this.confirmarButton.Location = new System.Drawing.Point(297, 553);
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Size = new System.Drawing.Size(166, 46);
            this.confirmarButton.TabIndex = 26;
            this.confirmarButton.Text = "Confirmar Pago";
            this.confirmarButton.UseVisualStyleBackColor = true;
            this.confirmarButton.Click += new System.EventHandler(this.confirmarButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(50, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Tipo:";
            // 
            // tipoCombo
            // 
            this.tipoCombo.FormattingEnabled = true;
            this.tipoCombo.Location = new System.Drawing.Point(91, 249);
            this.tipoCombo.Name = "tipoCombo";
            this.tipoCombo.Size = new System.Drawing.Size(108, 21);
            this.tipoCombo.TabIndex = 28;
            this.tipoCombo.SelectedIndexChanged += new System.EventHandler(this.tipoCombo_SelectedIndexChanged);
            // 
            // Confirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(797, 616);
            this.Controls.Add(this.tipoCombo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.confirmarButton);
            this.Controls.Add(this.detalleTextbox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cuotasCombo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.vencimientoTextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.codigoTextbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numeroTextbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fechaNacimientoPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.direccionTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.apellidoTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombreTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.documentoTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medioDePagoCombo);
            this.Name = "Confirmacion";
            this.Text = "Confirmacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox medioDePagoCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox documentoTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox apellidoTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox direccionTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fechaNacimientoPicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox numeroTextbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox codigoTextbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox vencimientoTextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cuotasCombo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox detalleTextbox;
        private System.Windows.Forms.Button confirmarButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox tipoCombo;
    }
}