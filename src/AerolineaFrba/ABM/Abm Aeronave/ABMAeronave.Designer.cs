namespace AerolineaFrba.Abm_Aeronave {
    partial class ABMAeronave {
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
            this.aeronaveDataGrid = new System.Windows.Forms.DataGridView();
            this.NuevoAeronave = new System.Windows.Forms.Button();
            this.ModificarAeronave = new System.Windows.Forms.Button();
            this.EliminarAeronave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kilogramosLabel = new System.Windows.Forms.Label();
            this.fabricanteInput = new System.Windows.Forms.TextBox();
            this.fabricanteLabel = new System.Windows.Forms.Label();
            this.modeloInput = new System.Windows.Forms.TextBox();
            this.modeloLabel = new System.Windows.Forms.Label();
            this.matriculaInput = new System.Windows.Forms.TextBox();
            this.matriculaLabel = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.kilogramosInput = new System.Windows.Forms.NumericUpDown();
            this.butacasInput = new System.Windows.Forms.NumericUpDown();
            this.butacasLabel = new System.Windows.Forms.Label();
            this.bajaInput = new System.Windows.Forms.ComboBox();
            this.bajaLabel = new System.Windows.Forms.Label();
            this.gD2C2015DataSet1 = new AerolineaFrba.GD2C2015DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kilogramosInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butacasInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // aeronaveDataGrid
            // 
            this.aeronaveDataGrid.AllowUserToAddRows = false;
            this.aeronaveDataGrid.AllowUserToDeleteRows = false;
            this.aeronaveDataGrid.AllowUserToResizeColumns = false;
            this.aeronaveDataGrid.AllowUserToResizeRows = false;
            this.aeronaveDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aeronaveDataGrid.Location = new System.Drawing.Point(12, 109);
            this.aeronaveDataGrid.Name = "aeronaveDataGrid";
            this.aeronaveDataGrid.ReadOnly = true;
            this.aeronaveDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aeronaveDataGrid.Size = new System.Drawing.Size(814, 235);
            this.aeronaveDataGrid.TabIndex = 0;
            // 
            // NuevoAeronave
            // 
            this.NuevoAeronave.Location = new System.Drawing.Point(832, 109);
            this.NuevoAeronave.Name = "NuevoAeronave";
            this.NuevoAeronave.Size = new System.Drawing.Size(75, 23);
            this.NuevoAeronave.TabIndex = 1;
            this.NuevoAeronave.Text = "Nuevo";
            this.NuevoAeronave.UseVisualStyleBackColor = true;
            this.NuevoAeronave.Click += new System.EventHandler(this.NuevoAeronave_Click);
            // 
            // ModificarAeronave
            // 
            this.ModificarAeronave.Location = new System.Drawing.Point(832, 159);
            this.ModificarAeronave.Name = "ModificarAeronave";
            this.ModificarAeronave.Size = new System.Drawing.Size(75, 23);
            this.ModificarAeronave.TabIndex = 2;
            this.ModificarAeronave.Text = "Modificar";
            this.ModificarAeronave.UseVisualStyleBackColor = true;
            this.ModificarAeronave.Click += new System.EventHandler(this.ModificarAeronave_Click);
            // 
            // EliminarAeronave
            // 
            this.EliminarAeronave.Location = new System.Drawing.Point(832, 207);
            this.EliminarAeronave.Name = "EliminarAeronave";
            this.EliminarAeronave.Size = new System.Drawing.Size(75, 23);
            this.EliminarAeronave.TabIndex = 3;
            this.EliminarAeronave.Text = "Eliminar";
            this.EliminarAeronave.UseVisualStyleBackColor = true;
            this.EliminarAeronave.Click += new System.EventHandler(this.EliminarAeronave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bajaLabel);
            this.panel1.Controls.Add(this.bajaInput);
            this.panel1.Controls.Add(this.butacasInput);
            this.panel1.Controls.Add(this.butacasLabel);
            this.panel1.Controls.Add(this.kilogramosInput);
            this.panel1.Controls.Add(this.kilogramosLabel);
            this.panel1.Controls.Add(this.fabricanteInput);
            this.panel1.Controls.Add(this.fabricanteLabel);
            this.panel1.Controls.Add(this.modeloInput);
            this.panel1.Controls.Add(this.modeloLabel);
            this.panel1.Controls.Add(this.matriculaInput);
            this.panel1.Controls.Add(this.matriculaLabel);
            this.panel1.Controls.Add(this.Buscar);
            this.panel1.Controls.Add(this.Limpiar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 91);
            this.panel1.TabIndex = 8;
            // 
            // kilogramosLabel
            // 
            this.kilogramosLabel.AutoSize = true;
            this.kilogramosLabel.Location = new System.Drawing.Point(284, 6);
            this.kilogramosLabel.Name = "kilogramosLabel";
            this.kilogramosLabel.Size = new System.Drawing.Size(115, 13);
            this.kilogramosLabel.TabIndex = 14;
            this.kilogramosLabel.Text = "Kilogramos Disponibles";
            // 
            // fabricanteInput
            // 
            this.fabricanteInput.Location = new System.Drawing.Point(3, 55);
            this.fabricanteInput.Name = "fabricanteInput";
            this.fabricanteInput.Size = new System.Drawing.Size(100, 20);
            this.fabricanteInput.TabIndex = 13;
            // 
            // fabricanteLabel
            // 
            this.fabricanteLabel.AutoSize = true;
            this.fabricanteLabel.Location = new System.Drawing.Point(109, 58);
            this.fabricanteLabel.Name = "fabricanteLabel";
            this.fabricanteLabel.Size = new System.Drawing.Size(57, 13);
            this.fabricanteLabel.TabIndex = 12;
            this.fabricanteLabel.Text = "Fabricante";
            // 
            // modeloInput
            // 
            this.modeloInput.Location = new System.Drawing.Point(3, 29);
            this.modeloInput.Name = "modeloInput";
            this.modeloInput.Size = new System.Drawing.Size(100, 20);
            this.modeloInput.TabIndex = 11;
            // 
            // modeloLabel
            // 
            this.modeloLabel.AutoSize = true;
            this.modeloLabel.Location = new System.Drawing.Point(109, 32);
            this.modeloLabel.Name = "modeloLabel";
            this.modeloLabel.Size = new System.Drawing.Size(42, 13);
            this.modeloLabel.TabIndex = 10;
            this.modeloLabel.Text = "Modelo";
            // 
            // matriculaInput
            // 
            this.matriculaInput.Location = new System.Drawing.Point(3, 3);
            this.matriculaInput.Name = "matriculaInput";
            this.matriculaInput.Size = new System.Drawing.Size(100, 20);
            this.matriculaInput.TabIndex = 8;
            // 
            // matriculaLabel
            // 
            this.matriculaLabel.AutoSize = true;
            this.matriculaLabel.Location = new System.Drawing.Point(109, 6);
            this.matriculaLabel.Name = "matriculaLabel";
            this.matriculaLabel.Size = new System.Drawing.Size(52, 13);
            this.matriculaLabel.TabIndex = 6;
            this.matriculaLabel.Text = "Matrícula";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(708, 40);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(103, 23);
            this.Buscar.TabIndex = 4;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(708, 65);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(103, 23);
            this.Limpiar.TabIndex = 5;
            this.Limpiar.Text = "Limpiar Campos";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // kilogramosInput
            // 
            this.kilogramosInput.Location = new System.Drawing.Point(178, 4);
            this.kilogramosInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.kilogramosInput.Name = "kilogramosInput";
            this.kilogramosInput.Size = new System.Drawing.Size(100, 20);
            this.kilogramosInput.TabIndex = 15;
            // 
            // butacasInput
            // 
            this.butacasInput.Location = new System.Drawing.Point(178, 30);
            this.butacasInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.butacasInput.Name = "butacasInput";
            this.butacasInput.Size = new System.Drawing.Size(100, 20);
            this.butacasInput.TabIndex = 17;
            // 
            // butacasLabel
            // 
            this.butacasLabel.AutoSize = true;
            this.butacasLabel.Location = new System.Drawing.Point(284, 32);
            this.butacasLabel.Name = "butacasLabel";
            this.butacasLabel.Size = new System.Drawing.Size(103, 13);
            this.butacasLabel.TabIndex = 16;
            this.butacasLabel.Text = "Butacas Disponibles";
            // 
            // bajaInput
            // 
            this.bajaInput.FormattingEnabled = true;
            this.bajaInput.Items.AddRange(new object[] {
            "Ninguna",
            "Fuera de servicio",
            "Baja definitiva"});
            this.bajaInput.Location = new System.Drawing.Point(405, 3);
            this.bajaInput.Name = "bajaInput";
            this.bajaInput.Size = new System.Drawing.Size(121, 21);
            this.bajaInput.TabIndex = 18;
            // 
            // bajaLabel
            // 
            this.bajaLabel.AutoSize = true;
            this.bajaLabel.Location = new System.Drawing.Point(532, 6);
            this.bajaLabel.Name = "bajaLabel";
            this.bajaLabel.Size = new System.Drawing.Size(60, 13);
            this.bajaLabel.TabIndex = 19;
            this.bajaLabel.Text = "Ultima Baja";
            // 
            // gD2C2015DataSet1
            // 
            this.gD2C2015DataSet1.DataSetName = "GD2C2015DataSet1";
            this.gD2C2015DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ABMAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EliminarAeronave);
            this.Controls.Add(this.ModificarAeronave);
            this.Controls.Add(this.NuevoAeronave);
            this.Controls.Add(this.aeronaveDataGrid);
            this.Name = "ABMAeronave";
            this.Text = "ABM Aeronave";
            this.Load += new System.EventHandler(this.ABMAeronave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kilogramosInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butacasInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView aeronaveDataGrid;
        private System.Windows.Forms.Button NuevoAeronave;
        private System.Windows.Forms.Button ModificarAeronave;
        private System.Windows.Forms.Button EliminarAeronave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label kilogramosLabel;
        private System.Windows.Forms.TextBox fabricanteInput;
        private System.Windows.Forms.Label fabricanteLabel;
        private System.Windows.Forms.TextBox modeloInput;
        private System.Windows.Forms.Label modeloLabel;
        private System.Windows.Forms.TextBox matriculaInput;
        private System.Windows.Forms.Label matriculaLabel;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.NumericUpDown kilogramosInput;
        private System.Windows.Forms.NumericUpDown butacasInput;
        private System.Windows.Forms.Label butacasLabel;
        private System.Windows.Forms.Label bajaLabel;
        private System.Windows.Forms.ComboBox bajaInput;
        private GD2C2015DataSet1 gD2C2015DataSet1;
    }
}