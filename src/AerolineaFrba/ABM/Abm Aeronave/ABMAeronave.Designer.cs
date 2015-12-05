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
            this.components = new System.ComponentModel.Container();
            this.aeronaveDataGrid = new System.Windows.Forms.DataGridView();
            this.NuevoAeronave = new System.Windows.Forms.Button();
            this.ModificarAeronave = new System.Windows.Forms.Button();
            this.bajaAeronave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tipoServicioTodosCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoServicioCombo = new System.Windows.Forms.ComboBox();
            this.tipoServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet8 = new AerolineaFrba.GD2C2015DataSet8();
            this.bajaLabel = new System.Windows.Forms.Label();
            this.bajaInput = new System.Windows.Forms.ComboBox();
            this.butacasInput = new System.Windows.Forms.NumericUpDown();
            this.butacasLabel = new System.Windows.Forms.Label();
            this.kilogramosInput = new System.Windows.Forms.NumericUpDown();
            this.kilogramosLabel = new System.Windows.Forms.Label();
            this.fabricanteLabel = new System.Windows.Forms.Label();
            this.modeloLabel = new System.Windows.Forms.Label();
            this.matriculaInput = new System.Windows.Forms.TextBox();
            this.matriculaLabel = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.gD2C2015DataSet1 = new AerolineaFrba.GD2C2015DataSet1();
            this.altaAeronave = new System.Windows.Forms.Button();
            this.tipo_ServicioTableAdapter = new AerolineaFrba.GD2C2015DataSet8TableAdapters.Tipo_ServicioTableAdapter();
            this.modeloCombo = new System.Windows.Forms.ComboBox();
            this.fabricanteCombo = new System.Windows.Forms.ComboBox();
            this.gD2C2015DataSet9 = new AerolineaFrba.GD2C2015DataSet9();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloTableAdapter = new AerolineaFrba.GD2C2015DataSet9TableAdapters.ModeloTableAdapter();
            this.gD2C2015DataSet10 = new AerolineaFrba.GD2C2015DataSet10();
            this.fabricanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabricanteTableAdapter = new AerolineaFrba.GD2C2015DataSet10TableAdapters.FabricanteTableAdapter();
            this.modeloTodos = new System.Windows.Forms.CheckBox();
            this.fabricanteTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butacasInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kilogramosInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricanteBindingSource)).BeginInit();
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
            this.aeronaveDataGrid.Size = new System.Drawing.Size(878, 235);
            this.aeronaveDataGrid.TabIndex = 0;
            // 
            // NuevoAeronave
            // 
            this.NuevoAeronave.Location = new System.Drawing.Point(896, 109);
            this.NuevoAeronave.Name = "NuevoAeronave";
            this.NuevoAeronave.Size = new System.Drawing.Size(75, 23);
            this.NuevoAeronave.TabIndex = 1;
            this.NuevoAeronave.Text = "Nuevo";
            this.NuevoAeronave.UseVisualStyleBackColor = true;
            this.NuevoAeronave.Click += new System.EventHandler(this.NuevoAeronave_Click);
            // 
            // ModificarAeronave
            // 
            this.ModificarAeronave.Location = new System.Drawing.Point(897, 138);
            this.ModificarAeronave.Name = "ModificarAeronave";
            this.ModificarAeronave.Size = new System.Drawing.Size(75, 23);
            this.ModificarAeronave.TabIndex = 2;
            this.ModificarAeronave.Text = "Modificar";
            this.ModificarAeronave.UseVisualStyleBackColor = true;
            this.ModificarAeronave.Click += new System.EventHandler(this.ModificarAeronave_Click);
            // 
            // bajaAeronave
            // 
            this.bajaAeronave.Location = new System.Drawing.Point(897, 167);
            this.bajaAeronave.Name = "bajaAeronave";
            this.bajaAeronave.Size = new System.Drawing.Size(75, 23);
            this.bajaAeronave.TabIndex = 3;
            this.bajaAeronave.Text = "Baja";
            this.bajaAeronave.UseVisualStyleBackColor = true;
            this.bajaAeronave.Click += new System.EventHandler(this.bajaAeronave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fabricanteTodos);
            this.panel1.Controls.Add(this.modeloTodos);
            this.panel1.Controls.Add(this.fabricanteCombo);
            this.panel1.Controls.Add(this.modeloCombo);
            this.panel1.Controls.Add(this.tipoServicioTodosCheckBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tipoServicioCombo);
            this.panel1.Controls.Add(this.bajaLabel);
            this.panel1.Controls.Add(this.bajaInput);
            this.panel1.Controls.Add(this.butacasInput);
            this.panel1.Controls.Add(this.butacasLabel);
            this.panel1.Controls.Add(this.kilogramosInput);
            this.panel1.Controls.Add(this.kilogramosLabel);
            this.panel1.Controls.Add(this.fabricanteLabel);
            this.panel1.Controls.Add(this.modeloLabel);
            this.panel1.Controls.Add(this.matriculaInput);
            this.panel1.Controls.Add(this.matriculaLabel);
            this.panel1.Controls.Add(this.Buscar);
            this.panel1.Controls.Add(this.Limpiar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 91);
            this.panel1.TabIndex = 8;
            // 
            // tipoServicioTodosCheckBox
            // 
            this.tipoServicioTodosCheckBox.AutoSize = true;
            this.tipoServicioTodosCheckBox.Checked = true;
            this.tipoServicioTodosCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tipoServicioTodosCheckBox.Location = new System.Drawing.Point(641, 33);
            this.tipoServicioTodosCheckBox.Name = "tipoServicioTodosCheckBox";
            this.tipoServicioTodosCheckBox.Size = new System.Drawing.Size(56, 17);
            this.tipoServicioTodosCheckBox.TabIndex = 23;
            this.tipoServicioTodosCheckBox.Text = "Todos";
            this.tipoServicioTodosCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tipo de Servicio";
            // 
            // tipoServicioCombo
            // 
            this.tipoServicioCombo.DataSource = this.tipoServicioBindingSource;
            this.tipoServicioCombo.DisplayMember = "descripcion";
            this.tipoServicioCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoServicioCombo.FormattingEnabled = true;
            this.tipoServicioCombo.Location = new System.Drawing.Point(405, 30);
            this.tipoServicioCombo.Name = "tipoServicioCombo";
            this.tipoServicioCombo.Size = new System.Drawing.Size(140, 21);
            this.tipoServicioCombo.TabIndex = 20;
            this.tipoServicioCombo.ValueMember = "id";
            // 
            // tipoServicioBindingSource
            // 
            this.tipoServicioBindingSource.DataMember = "Tipo_Servicio";
            this.tipoServicioBindingSource.DataSource = this.gD2C2015DataSet8;
            // 
            // gD2C2015DataSet8
            // 
            this.gD2C2015DataSet8.DataSetName = "GD2C2015DataSet8";
            this.gD2C2015DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bajaLabel
            // 
            this.bajaLabel.AutoSize = true;
            this.bajaLabel.Location = new System.Drawing.Point(551, 6);
            this.bajaLabel.Name = "bajaLabel";
            this.bajaLabel.Size = new System.Drawing.Size(60, 13);
            this.bajaLabel.TabIndex = 19;
            this.bajaLabel.Text = "Ultima Baja";
            // 
            // bajaInput
            // 
            this.bajaInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bajaInput.FormattingEnabled = true;
            this.bajaInput.Items.AddRange(new object[] {
            "Todas las aeronaves",
            "Fuera de servicio",
            "Baja definitiva"});
            this.bajaInput.Location = new System.Drawing.Point(405, 3);
            this.bajaInput.Name = "bajaInput";
            this.bajaInput.Size = new System.Drawing.Size(140, 21);
            this.bajaInput.TabIndex = 18;
            // 
            // butacasInput
            // 
            this.butacasInput.Location = new System.Drawing.Point(405, 58);
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
            this.butacasLabel.Location = new System.Drawing.Point(511, 60);
            this.butacasLabel.Name = "butacasLabel";
            this.butacasLabel.Size = new System.Drawing.Size(103, 13);
            this.butacasLabel.TabIndex = 16;
            this.butacasLabel.Text = "Butacas Disponibles";
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
            // kilogramosLabel
            // 
            this.kilogramosLabel.AutoSize = true;
            this.kilogramosLabel.Location = new System.Drawing.Point(284, 6);
            this.kilogramosLabel.Name = "kilogramosLabel";
            this.kilogramosLabel.Size = new System.Drawing.Size(115, 13);
            this.kilogramosLabel.TabIndex = 14;
            this.kilogramosLabel.Text = "Kilogramos Disponibles";
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
            this.Buscar.Location = new System.Drawing.Point(772, 40);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(103, 23);
            this.Buscar.TabIndex = 4;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(772, 65);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(103, 23);
            this.Limpiar.TabIndex = 5;
            this.Limpiar.Text = "Limpiar Campos";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // gD2C2015DataSet1
            // 
            this.gD2C2015DataSet1.DataSetName = "GD2C2015DataSet1";
            this.gD2C2015DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // altaAeronave
            // 
            this.altaAeronave.Location = new System.Drawing.Point(897, 196);
            this.altaAeronave.Name = "altaAeronave";
            this.altaAeronave.Size = new System.Drawing.Size(75, 23);
            this.altaAeronave.TabIndex = 9;
            this.altaAeronave.Text = "Alta";
            this.altaAeronave.UseVisualStyleBackColor = true;
            // 
            // tipo_ServicioTableAdapter
            // 
            this.tipo_ServicioTableAdapter.ClearBeforeFill = true;
            // 
            // modeloCombo
            // 
            this.modeloCombo.DataSource = this.modeloBindingSource;
            this.modeloCombo.DisplayMember = "descripcion";
            this.modeloCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeloCombo.FormattingEnabled = true;
            this.modeloCombo.Location = new System.Drawing.Point(3, 29);
            this.modeloCombo.Name = "modeloCombo";
            this.modeloCombo.Size = new System.Drawing.Size(100, 21);
            this.modeloCombo.TabIndex = 24;
            this.modeloCombo.ValueMember = "id";
            // 
            // fabricanteCombo
            // 
            this.fabricanteCombo.DataSource = this.fabricanteBindingSource;
            this.fabricanteCombo.DisplayMember = "descripcion";
            this.fabricanteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fabricanteCombo.FormattingEnabled = true;
            this.fabricanteCombo.Location = new System.Drawing.Point(3, 56);
            this.fabricanteCombo.Name = "fabricanteCombo";
            this.fabricanteCombo.Size = new System.Drawing.Size(100, 21);
            this.fabricanteCombo.TabIndex = 25;
            this.fabricanteCombo.ValueMember = "id";
            // 
            // gD2C2015DataSet9
            // 
            this.gD2C2015DataSet9.DataSetName = "GD2C2015DataSet9";
            this.gD2C2015DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataMember = "Modelo";
            this.modeloBindingSource.DataSource = this.gD2C2015DataSet9;
            // 
            // modeloTableAdapter
            // 
            this.modeloTableAdapter.ClearBeforeFill = true;
            // 
            // gD2C2015DataSet10
            // 
            this.gD2C2015DataSet10.DataSetName = "GD2C2015DataSet10";
            this.gD2C2015DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fabricanteBindingSource
            // 
            this.fabricanteBindingSource.DataMember = "Fabricante";
            this.fabricanteBindingSource.DataSource = this.gD2C2015DataSet10;
            // 
            // fabricanteTableAdapter
            // 
            this.fabricanteTableAdapter.ClearBeforeFill = true;
            // 
            // modeloTodos
            // 
            this.modeloTodos.AutoSize = true;
            this.modeloTodos.Checked = true;
            this.modeloTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modeloTodos.Location = new System.Drawing.Point(178, 29);
            this.modeloTodos.Name = "modeloTodos";
            this.modeloTodos.Size = new System.Drawing.Size(56, 17);
            this.modeloTodos.TabIndex = 26;
            this.modeloTodos.Text = "Todos";
            this.modeloTodos.UseVisualStyleBackColor = true;
            // 
            // fabricanteTodos
            // 
            this.fabricanteTodos.AutoSize = true;
            this.fabricanteTodos.Checked = true;
            this.fabricanteTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fabricanteTodos.Location = new System.Drawing.Point(178, 56);
            this.fabricanteTodos.Name = "fabricanteTodos";
            this.fabricanteTodos.Size = new System.Drawing.Size(56, 17);
            this.fabricanteTodos.TabIndex = 27;
            this.fabricanteTodos.Text = "Todos";
            this.fabricanteTodos.UseVisualStyleBackColor = true;
            // 
            // ABMAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 394);
            this.Controls.Add(this.altaAeronave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bajaAeronave);
            this.Controls.Add(this.ModificarAeronave);
            this.Controls.Add(this.NuevoAeronave);
            this.Controls.Add(this.aeronaveDataGrid);
            this.Name = "ABMAeronave";
            this.Text = "ABM Aeronave";
            this.Load += new System.EventHandler(this.ABMAeronave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butacasInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kilogramosInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricanteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView aeronaveDataGrid;
        private System.Windows.Forms.Button NuevoAeronave;
        private System.Windows.Forms.Button ModificarAeronave;
        private System.Windows.Forms.Button bajaAeronave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label kilogramosLabel;
        private System.Windows.Forms.Label fabricanteLabel;
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
        private System.Windows.Forms.Button altaAeronave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipoServicioCombo;
        private GD2C2015DataSet8 gD2C2015DataSet8;
        private System.Windows.Forms.BindingSource tipoServicioBindingSource;
        private GD2C2015DataSet8TableAdapters.Tipo_ServicioTableAdapter tipo_ServicioTableAdapter;
        private System.Windows.Forms.CheckBox tipoServicioTodosCheckBox;
        private System.Windows.Forms.ComboBox fabricanteCombo;
        private System.Windows.Forms.ComboBox modeloCombo;
        private GD2C2015DataSet9 gD2C2015DataSet9;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private GD2C2015DataSet9TableAdapters.ModeloTableAdapter modeloTableAdapter;
        private GD2C2015DataSet10 gD2C2015DataSet10;
        private System.Windows.Forms.BindingSource fabricanteBindingSource;
        private GD2C2015DataSet10TableAdapters.FabricanteTableAdapter fabricanteTableAdapter;
        private System.Windows.Forms.CheckBox fabricanteTodos;
        private System.Windows.Forms.CheckBox modeloTodos;
    }
}