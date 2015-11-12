namespace AerolineaFrba.ABM.Abm_Ruta {
    partial class ABMRuta {
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
            this.components = new System.ComponentModel.Container();
            this.rutaDataGrid = new System.Windows.Forms.DataGridView();
            this.rutaNuevo = new System.Windows.Forms.Button();
            this.rutaModificar = new System.Windows.Forms.Button();
            this.rutaEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.origenTodosCheckBox = new System.Windows.Forms.CheckBox();
            this.destinoTodosCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.origenCombo = new System.Windows.Forms.ComboBox();
            this.ciudadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet6 = new AerolineaFrba.GD2C2015DataSet6();
            this.label5 = new System.Windows.Forms.Label();
            this.destinoCombo = new System.Windows.Forms.ComboBox();
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet5 = new AerolineaFrba.GD2C2015DataSet5();
            this.basePasajeInput = new System.Windows.Forms.NumericUpDown();
            this.basePasajeLabel = new System.Windows.Forms.Label();
            this.baseKgInput = new System.Windows.Forms.NumericUpDown();
            this.baseKgLabel = new System.Windows.Forms.Label();
            this.codigoInput = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.ciudadTableAdapter = new AerolineaFrba.GD2C2015DataSet5TableAdapters.CiudadTableAdapter();
            this.ciudadTableAdapter1 = new AerolineaFrba.GD2C2015DataSet6TableAdapters.CiudadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rutaDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basePasajeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseKgInput)).BeginInit();
            this.SuspendLayout();
            // 
            // rutaDataGrid
            // 
            this.rutaDataGrid.AllowUserToAddRows = false;
            this.rutaDataGrid.AllowUserToDeleteRows = false;
            this.rutaDataGrid.AllowUserToResizeColumns = false;
            this.rutaDataGrid.AllowUserToResizeRows = false;
            this.rutaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rutaDataGrid.Location = new System.Drawing.Point(12, 114);
            this.rutaDataGrid.Name = "rutaDataGrid";
            this.rutaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rutaDataGrid.Size = new System.Drawing.Size(769, 253);
            this.rutaDataGrid.TabIndex = 0;
            // 
            // rutaNuevo
            // 
            this.rutaNuevo.Location = new System.Drawing.Point(787, 114);
            this.rutaNuevo.Name = "rutaNuevo";
            this.rutaNuevo.Size = new System.Drawing.Size(75, 23);
            this.rutaNuevo.TabIndex = 1;
            this.rutaNuevo.Text = "Nuevo";
            this.rutaNuevo.UseVisualStyleBackColor = true;
            this.rutaNuevo.Click += new System.EventHandler(this.rutaNuevo_Click);
            // 
            // rutaModificar
            // 
            this.rutaModificar.Location = new System.Drawing.Point(787, 161);
            this.rutaModificar.Name = "rutaModificar";
            this.rutaModificar.Size = new System.Drawing.Size(75, 23);
            this.rutaModificar.TabIndex = 2;
            this.rutaModificar.Text = "Modificar";
            this.rutaModificar.UseVisualStyleBackColor = true;
            this.rutaModificar.Click += new System.EventHandler(this.rutaModificar_Click);
            // 
            // rutaEliminar
            // 
            this.rutaEliminar.Location = new System.Drawing.Point(787, 206);
            this.rutaEliminar.Name = "rutaEliminar";
            this.rutaEliminar.Size = new System.Drawing.Size(75, 23);
            this.rutaEliminar.TabIndex = 3;
            this.rutaEliminar.Text = "Eliminar";
            this.rutaEliminar.UseVisualStyleBackColor = true;
            this.rutaEliminar.Click += new System.EventHandler(this.rutaEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.origenTodosCheckBox);
            this.panel1.Controls.Add(this.destinoTodosCheckBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.origenCombo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.destinoCombo);
            this.panel1.Controls.Add(this.basePasajeInput);
            this.panel1.Controls.Add(this.basePasajeLabel);
            this.panel1.Controls.Add(this.baseKgInput);
            this.panel1.Controls.Add(this.baseKgLabel);
            this.panel1.Controls.Add(this.codigoInput);
            this.panel1.Controls.Add(this.codigoLabel);
            this.panel1.Controls.Add(this.Buscar);
            this.panel1.Controls.Add(this.Limpiar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 91);
            this.panel1.TabIndex = 9;
            // 
            // origenTodosCheckBox
            // 
            this.origenTodosCheckBox.AutoSize = true;
            this.origenTodosCheckBox.Checked = true;
            this.origenTodosCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.origenTodosCheckBox.Location = new System.Drawing.Point(644, 31);
            this.origenTodosCheckBox.Name = "origenTodosCheckBox";
            this.origenTodosCheckBox.Size = new System.Drawing.Size(56, 17);
            this.origenTodosCheckBox.TabIndex = 23;
            this.origenTodosCheckBox.Text = "Todos";
            this.origenTodosCheckBox.UseVisualStyleBackColor = true;
            // 
            // destinoTodosCheckBox
            // 
            this.destinoTodosCheckBox.AutoSize = true;
            this.destinoTodosCheckBox.Checked = true;
            this.destinoTodosCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.destinoTodosCheckBox.Location = new System.Drawing.Point(644, 6);
            this.destinoTodosCheckBox.Name = "destinoTodosCheckBox";
            this.destinoTodosCheckBox.Size = new System.Drawing.Size(56, 17);
            this.destinoTodosCheckBox.TabIndex = 22;
            this.destinoTodosCheckBox.Text = "Todos";
            this.destinoTodosCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Origen";
            // 
            // origenCombo
            // 
            this.origenCombo.DataSource = this.ciudadBindingSource1;
            this.origenCombo.DisplayMember = "descripcion";
            this.origenCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origenCombo.FormattingEnabled = true;
            this.origenCombo.Location = new System.Drawing.Point(424, 30);
            this.origenCombo.Name = "origenCombo";
            this.origenCombo.Size = new System.Drawing.Size(155, 21);
            this.origenCombo.TabIndex = 20;
            this.origenCombo.ValueMember = "id";
            // 
            // ciudadBindingSource1
            // 
            this.ciudadBindingSource1.DataMember = "Ciudad";
            this.ciudadBindingSource1.DataSource = this.gD2C2015DataSet6;
            // 
            // gD2C2015DataSet6
            // 
            this.gD2C2015DataSet6.DataSetName = "GD2C2015DataSet6";
            this.gD2C2015DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Destino";
            // 
            // destinoCombo
            // 
            this.destinoCombo.DataSource = this.ciudadBindingSource;
            this.destinoCombo.DisplayMember = "descripcion";
            this.destinoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinoCombo.FormattingEnabled = true;
            this.destinoCombo.Location = new System.Drawing.Point(424, 4);
            this.destinoCombo.Name = "destinoCombo";
            this.destinoCombo.Size = new System.Drawing.Size(155, 21);
            this.destinoCombo.TabIndex = 18;
            this.destinoCombo.ValueMember = "id";
            // 
            // ciudadBindingSource
            // 
            this.ciudadBindingSource.DataMember = "Ciudad";
            this.ciudadBindingSource.DataSource = this.gD2C2015DataSet5;
            // 
            // gD2C2015DataSet5
            // 
            this.gD2C2015DataSet5.DataSetName = "GD2C2015DataSet5";
            this.gD2C2015DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // basePasajeInput
            // 
            this.basePasajeInput.Location = new System.Drawing.Point(178, 30);
            this.basePasajeInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.basePasajeInput.Name = "basePasajeInput";
            this.basePasajeInput.Size = new System.Drawing.Size(100, 20);
            this.basePasajeInput.TabIndex = 17;
            // 
            // basePasajeLabel
            // 
            this.basePasajeLabel.AutoSize = true;
            this.basePasajeLabel.Location = new System.Drawing.Point(284, 32);
            this.basePasajeLabel.Name = "basePasajeLabel";
            this.basePasajeLabel.Size = new System.Drawing.Size(129, 13);
            this.basePasajeLabel.TabIndex = 16;
            this.basePasajeLabel.Text = "Hasta Precio base Pasaje";
            // 
            // baseKgInput
            // 
            this.baseKgInput.Location = new System.Drawing.Point(178, 4);
            this.baseKgInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.baseKgInput.Name = "baseKgInput";
            this.baseKgInput.Size = new System.Drawing.Size(100, 20);
            this.baseKgInput.TabIndex = 15;
            // 
            // baseKgLabel
            // 
            this.baseKgLabel.AutoSize = true;
            this.baseKgLabel.Location = new System.Drawing.Point(284, 6);
            this.baseKgLabel.Name = "baseKgLabel";
            this.baseKgLabel.Size = new System.Drawing.Size(110, 13);
            this.baseKgLabel.TabIndex = 14;
            this.baseKgLabel.Text = "Hasta Precio base Kg";
            // 
            // codigoInput
            // 
            this.codigoInput.Location = new System.Drawing.Point(3, 3);
            this.codigoInput.Name = "codigoInput";
            this.codigoInput.Size = new System.Drawing.Size(100, 20);
            this.codigoInput.TabIndex = 8;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(109, 6);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(40, 13);
            this.codigoLabel.TabIndex = 6;
            this.codigoLabel.Text = "Código";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(744, 6);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(103, 23);
            this.Buscar.TabIndex = 4;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(744, 31);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(103, 23);
            this.Limpiar.TabIndex = 5;
            this.Limpiar.Text = "Limpiar Campos";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // ciudadTableAdapter
            // 
            this.ciudadTableAdapter.ClearBeforeFill = true;
            // 
            // ciudadTableAdapter1
            // 
            this.ciudadTableAdapter1.ClearBeforeFill = true;
            // 
            // ABMRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rutaEliminar);
            this.Controls.Add(this.rutaModificar);
            this.Controls.Add(this.rutaNuevo);
            this.Controls.Add(this.rutaDataGrid);
            this.Name = "ABMRuta";
            this.Text = "ABM Ruta";
            this.Load += new System.EventHandler(this.ABMRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rutaDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basePasajeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseKgInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView rutaDataGrid;
        private System.Windows.Forms.Button rutaNuevo;
        private System.Windows.Forms.Button rutaModificar;
        private System.Windows.Forms.Button rutaEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown basePasajeInput;
        private System.Windows.Forms.Label basePasajeLabel;
        private System.Windows.Forms.NumericUpDown baseKgInput;
        private System.Windows.Forms.Label baseKgLabel;
        private System.Windows.Forms.TextBox codigoInput;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.ComboBox destinoCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox origenCombo;
        private GD2C2015DataSet5 gD2C2015DataSet5;
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        private GD2C2015DataSet5TableAdapters.CiudadTableAdapter ciudadTableAdapter;
        private GD2C2015DataSet6 gD2C2015DataSet6;
        private System.Windows.Forms.BindingSource ciudadBindingSource1;
        private GD2C2015DataSet6TableAdapters.CiudadTableAdapter ciudadTableAdapter1;
        private System.Windows.Forms.CheckBox origenTodosCheckBox;
        private System.Windows.Forms.CheckBox destinoTodosCheckBox;
    }
}