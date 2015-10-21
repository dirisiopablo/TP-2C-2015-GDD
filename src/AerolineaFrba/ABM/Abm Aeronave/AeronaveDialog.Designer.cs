namespace AerolineaFrba.ABM.Abm_Aeronave {
    partial class AeronaveDialog {
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
            this.matriculaTextbox = new System.Windows.Forms.TextBox();
            this.modeloTextbox = new System.Windows.Forms.TextBox();
            this.fabricanteTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guardarAeronave = new System.Windows.Forms.Button();
            this.cancelarAeronave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descripcionGeneral = new System.Windows.Forms.Label();
            this.kgTextbox = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.primerPiso = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.segundoPiso = new System.Windows.Forms.Label();
            this.cantidadPasillo1Input = new System.Windows.Forms.NumericUpDown();
            this.cantidadVentana1Input = new System.Windows.Forms.NumericUpDown();
            this.cantidadPasillo2Input = new System.Windows.Forms.NumericUpDown();
            this.cantidadVentana2Input = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadPasillo1Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadVentana1Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadPasillo2Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadVentana2Input)).BeginInit();
            this.SuspendLayout();
            // 
            // matriculaTextbox
            // 
            this.matriculaTextbox.Location = new System.Drawing.Point(129, 34);
            this.matriculaTextbox.Name = "matriculaTextbox";
            this.matriculaTextbox.Size = new System.Drawing.Size(148, 20);
            this.matriculaTextbox.TabIndex = 0;
            // 
            // modeloTextbox
            // 
            this.modeloTextbox.Location = new System.Drawing.Point(129, 72);
            this.modeloTextbox.Name = "modeloTextbox";
            this.modeloTextbox.Size = new System.Drawing.Size(148, 20);
            this.modeloTextbox.TabIndex = 1;
            // 
            // fabricanteTextbox
            // 
            this.fabricanteTextbox.Location = new System.Drawing.Point(129, 152);
            this.fabricanteTextbox.Name = "fabricanteTextbox";
            this.fabricanteTextbox.Size = new System.Drawing.Size(148, 20);
            this.fabricanteTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kg Disponibles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fabricante";
            // 
            // guardarAeronave
            // 
            this.guardarAeronave.Location = new System.Drawing.Point(522, 245);
            this.guardarAeronave.Name = "guardarAeronave";
            this.guardarAeronave.Size = new System.Drawing.Size(98, 26);
            this.guardarAeronave.TabIndex = 8;
            this.guardarAeronave.Text = "Guardar";
            this.guardarAeronave.UseVisualStyleBackColor = true;
            this.guardarAeronave.Click += new System.EventHandler(this.guardarAeronave_Click);
            // 
            // cancelarAeronave
            // 
            this.cancelarAeronave.Location = new System.Drawing.Point(337, 245);
            this.cancelarAeronave.Name = "cancelarAeronave";
            this.cancelarAeronave.Size = new System.Drawing.Size(102, 26);
            this.cancelarAeronave.TabIndex = 9;
            this.cancelarAeronave.Text = "Cancelar";
            this.cancelarAeronave.UseVisualStyleBackColor = true;
            this.cancelarAeronave.Click += new System.EventHandler(this.cancelarAeronave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.descripcionGeneral);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.matriculaTextbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.modeloTextbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fabricanteTextbox);
            this.panel1.Controls.Add(this.kgTextbox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 214);
            this.panel1.TabIndex = 10;
            // 
            // descripcionGeneral
            // 
            this.descripcionGeneral.AutoSize = true;
            this.descripcionGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionGeneral.Location = new System.Drawing.Point(3, 0);
            this.descripcionGeneral.Name = "descripcionGeneral";
            this.descripcionGeneral.Size = new System.Drawing.Size(162, 18);
            this.descripcionGeneral.TabIndex = 9;
            this.descripcionGeneral.Text = "Descripción General";
            // 
            // kgTextbox
            // 
            this.kgTextbox.Location = new System.Drawing.Point(129, 113);
            this.kgTextbox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.kgTextbox.Name = "kgTextbox";
            this.kgTextbox.Size = new System.Drawing.Size(148, 20);
            this.kgTextbox.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(337, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.primerPiso);
            this.splitContainer1.Panel1.Controls.Add(this.cantidadPasillo1Input);
            this.splitContainer1.Panel1.Controls.Add(this.cantidadVentana1Input);
            this.splitContainer1.Panel1MinSize = 105;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.segundoPiso);
            this.splitContainer1.Panel2.Controls.Add(this.cantidadPasillo2Input);
            this.splitContainer1.Panel2.Controls.Add(this.cantidadVentana2Input);
            this.splitContainer1.Panel2MinSize = 105;
            this.splitContainer1.Size = new System.Drawing.Size(283, 214);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cantidad Ventana";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad Pasillo";
            // 
            // primerPiso
            // 
            this.primerPiso.AutoSize = true;
            this.primerPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primerPiso.Location = new System.Drawing.Point(3, 0);
            this.primerPiso.Name = "primerPiso";
            this.primerPiso.Size = new System.Drawing.Size(97, 18);
            this.primerPiso.TabIndex = 10;
            this.primerPiso.Text = "Primer Piso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cantidad Ventana";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cantidad Pasillo";
            // 
            // segundoPiso
            // 
            this.segundoPiso.AutoSize = true;
            this.segundoPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundoPiso.Location = new System.Drawing.Point(3, 0);
            this.segundoPiso.Name = "segundoPiso";
            this.segundoPiso.Size = new System.Drawing.Size(113, 18);
            this.segundoPiso.TabIndex = 11;
            this.segundoPiso.Text = "Segundo Piso";
            // 
            // cantidadPasillo1Input
            // 
            this.cantidadPasillo1Input.Location = new System.Drawing.Point(106, 31);
            this.cantidadPasillo1Input.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cantidadPasillo1Input.Name = "cantidadPasillo1Input";
            this.cantidadPasillo1Input.Size = new System.Drawing.Size(148, 20);
            this.cantidadPasillo1Input.TabIndex = 15;
            // 
            // cantidadVentana1Input
            // 
            this.cantidadVentana1Input.Location = new System.Drawing.Point(106, 70);
            this.cantidadVentana1Input.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cantidadVentana1Input.Name = "cantidadVentana1Input";
            this.cantidadVentana1Input.Size = new System.Drawing.Size(148, 20);
            this.cantidadVentana1Input.TabIndex = 16;
            // 
            // cantidadPasillo2Input
            // 
            this.cantidadPasillo2Input.Location = new System.Drawing.Point(106, 34);
            this.cantidadPasillo2Input.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cantidadPasillo2Input.Name = "cantidadPasillo2Input";
            this.cantidadPasillo2Input.Size = new System.Drawing.Size(148, 20);
            this.cantidadPasillo2Input.TabIndex = 17;
            // 
            // cantidadVentana2Input
            // 
            this.cantidadVentana2Input.Location = new System.Drawing.Point(106, 72);
            this.cantidadVentana2Input.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cantidadVentana2Input.Name = "cantidadVentana2Input";
            this.cantidadVentana2Input.Size = new System.Drawing.Size(148, 20);
            this.cantidadVentana2Input.TabIndex = 19;
            // 
            // AeronaveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 283);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.cancelarAeronave);
            this.Controls.Add(this.guardarAeronave);
            this.Controls.Add(this.panel1);
            this.Name = "AeronaveDialog";
            this.Text = "Aeronave";
            this.Load += new System.EventHandler(this.AeronaveDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgTextbox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadPasillo1Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadVentana1Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadPasillo2Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadVentana2Input)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox matriculaTextbox;
        private System.Windows.Forms.TextBox modeloTextbox;
        private System.Windows.Forms.TextBox fabricanteTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button guardarAeronave;
        private System.Windows.Forms.Button cancelarAeronave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown kgTextbox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label descripcionGeneral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label primerPiso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label segundoPiso;
        private System.Windows.Forms.NumericUpDown cantidadPasillo1Input;
        private System.Windows.Forms.NumericUpDown cantidadVentana1Input;
        private System.Windows.Forms.NumericUpDown cantidadPasillo2Input;
        private System.Windows.Forms.NumericUpDown cantidadVentana2Input;
    }
}