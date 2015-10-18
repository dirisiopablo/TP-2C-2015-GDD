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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilogramosdisponiblesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeronaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAeronave = new AerolineaFrba.DataSetAeronave();
            this.aeronaveTableAdapter = new AerolineaFrba.DataSetAeronaveTableAdapters.AeronaveTableAdapter();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.NuevoAeronave = new System.Windows.Forms.Button();
            this.ModificarAeronave = new System.Windows.Forms.Button();
            this.EliminarAeronave = new System.Windows.Forms.Button();
            this.BuscarAeronave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAeronave)).BeginInit();
            this.SuspendLayout();
            // 
            // aeronaveDataGrid
            // 
            this.aeronaveDataGrid.AllowUserToAddRows = false;
            this.aeronaveDataGrid.AllowUserToDeleteRows = false;
            this.aeronaveDataGrid.AllowUserToResizeColumns = false;
            this.aeronaveDataGrid.AllowUserToResizeRows = false;
            this.aeronaveDataGrid.AutoGenerateColumns = false;
            this.aeronaveDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aeronaveDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.kilogramosdisponiblesDataGridViewTextBoxColumn,
            this.fabricanteDataGridViewTextBoxColumn});
            this.aeronaveDataGrid.DataSource = this.aeronaveBindingSource;
            this.aeronaveDataGrid.Location = new System.Drawing.Point(12, 109);
            this.aeronaveDataGrid.Name = "aeronaveDataGrid";
            this.aeronaveDataGrid.ReadOnly = true;
            this.aeronaveDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aeronaveDataGrid.Size = new System.Drawing.Size(569, 235);
            this.aeronaveDataGrid.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kilogramosdisponiblesDataGridViewTextBoxColumn
            // 
            this.kilogramosdisponiblesDataGridViewTextBoxColumn.DataPropertyName = "kilogramos_disponibles";
            this.kilogramosdisponiblesDataGridViewTextBoxColumn.HeaderText = "kilogramos_disponibles";
            this.kilogramosdisponiblesDataGridViewTextBoxColumn.Name = "kilogramosdisponiblesDataGridViewTextBoxColumn";
            this.kilogramosdisponiblesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fabricanteDataGridViewTextBoxColumn
            // 
            this.fabricanteDataGridViewTextBoxColumn.DataPropertyName = "fabricante";
            this.fabricanteDataGridViewTextBoxColumn.HeaderText = "fabricante";
            this.fabricanteDataGridViewTextBoxColumn.Name = "fabricanteDataGridViewTextBoxColumn";
            this.fabricanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aeronaveBindingSource
            // 
            this.aeronaveBindingSource.DataMember = "Aeronave";
            this.aeronaveBindingSource.DataSource = this.dataSetAeronave;
            // 
            // dataSetAeronave
            // 
            this.dataSetAeronave.DataSetName = "DataSetAeronave";
            this.dataSetAeronave.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeronaveTableAdapter
            // 
            this.aeronaveTableAdapter.ClearBeforeFill = true;
            // 
            // NuevoAeronave
            // 
            this.NuevoAeronave.Location = new System.Drawing.Point(612, 109);
            this.NuevoAeronave.Name = "NuevoAeronave";
            this.NuevoAeronave.Size = new System.Drawing.Size(75, 23);
            this.NuevoAeronave.TabIndex = 1;
            this.NuevoAeronave.Text = "Nuevo";
            this.NuevoAeronave.UseVisualStyleBackColor = true;
            this.NuevoAeronave.Click += new System.EventHandler(this.NuevoAeronave_Click);
            // 
            // ModificarAeronave
            // 
            this.ModificarAeronave.Location = new System.Drawing.Point(612, 159);
            this.ModificarAeronave.Name = "ModificarAeronave";
            this.ModificarAeronave.Size = new System.Drawing.Size(75, 23);
            this.ModificarAeronave.TabIndex = 2;
            this.ModificarAeronave.Text = "Modificar";
            this.ModificarAeronave.UseVisualStyleBackColor = true;
            this.ModificarAeronave.Click += new System.EventHandler(this.ModificarAeronave_Click);
            // 
            // EliminarAeronave
            // 
            this.EliminarAeronave.Location = new System.Drawing.Point(612, 207);
            this.EliminarAeronave.Name = "EliminarAeronave";
            this.EliminarAeronave.Size = new System.Drawing.Size(75, 23);
            this.EliminarAeronave.TabIndex = 3;
            this.EliminarAeronave.Text = "Eliminar";
            this.EliminarAeronave.UseVisualStyleBackColor = true;
            this.EliminarAeronave.Click += new System.EventHandler(this.EliminarAeronave_Click);
            // 
            // BuscarAeronave
            // 
            this.BuscarAeronave.Location = new System.Drawing.Point(484, 50);
            this.BuscarAeronave.Name = "BuscarAeronave";
            this.BuscarAeronave.Size = new System.Drawing.Size(75, 23);
            this.BuscarAeronave.TabIndex = 4;
            this.BuscarAeronave.Text = "Buscar";
            this.BuscarAeronave.UseVisualStyleBackColor = true;
            // 
            // ABMAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 394);
            this.Controls.Add(this.BuscarAeronave);
            this.Controls.Add(this.EliminarAeronave);
            this.Controls.Add(this.ModificarAeronave);
            this.Controls.Add(this.NuevoAeronave);
            this.Controls.Add(this.aeronaveDataGrid);
            this.Name = "ABMAeronave";
            this.Text = "ABM Aeronave";
            this.Load += new System.EventHandler(this.ABMAeronave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAeronave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView aeronaveDataGrid;
        private DataSetAeronave dataSetAeronave;
        private System.Windows.Forms.BindingSource aeronaveBindingSource;
        private DataSetAeronaveTableAdapters.AeronaveTableAdapter aeronaveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilogramosdisponiblesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button NuevoAeronave;
        private System.Windows.Forms.Button ModificarAeronave;
        private System.Windows.Forms.Button EliminarAeronave;
        private System.Windows.Forms.Button BuscarAeronave;
    }
}