namespace AerolineaFrba.ABM.Abm_Ciudad {
    partial class ABMCiudad {
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
            this.ciudadDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCiudad = new AerolineaFrba.DataSetCiudad();
            this.ciudadTableAdapter = new AerolineaFrba.DataSetCiudadTableAdapters.CiudadTableAdapter();
            this.Limpiar = new System.Windows.Forms.Button();
            this.BuscarCiudad = new System.Windows.Forms.Button();
            this.nuevoCiudad = new System.Windows.Forms.Button();
            this.modificarCiudad = new System.Windows.Forms.Button();
            this.eliminarCiudad = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ciudadDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad)).BeginInit();
            this.SuspendLayout();
            // 
            // ciudadDataGrid
            // 
            this.ciudadDataGrid.AutoGenerateColumns = false;
            this.ciudadDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ciudadDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.ciudadDataGrid.DataSource = this.ciudadBindingSource;
            this.ciudadDataGrid.Location = new System.Drawing.Point(28, 76);
            this.ciudadDataGrid.Name = "ciudadDataGrid";
            this.ciudadDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ciudadDataGrid.Size = new System.Drawing.Size(258, 169);
            this.ciudadDataGrid.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // ciudadBindingSource
            // 
            this.ciudadBindingSource.DataMember = "Ciudad";
            this.ciudadBindingSource.DataSource = this.dataSetCiudad;
            // 
            // dataSetCiudad
            // 
            this.dataSetCiudad.DataSetName = "DataSetCiudad";
            this.dataSetCiudad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ciudadTableAdapter
            // 
            this.ciudadTableAdapter.ClearBeforeFill = true;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(28, 32);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 1;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // BuscarCiudad
            // 
            this.BuscarCiudad.Location = new System.Drawing.Point(199, 32);
            this.BuscarCiudad.Name = "BuscarCiudad";
            this.BuscarCiudad.Size = new System.Drawing.Size(75, 23);
            this.BuscarCiudad.TabIndex = 2;
            this.BuscarCiudad.Text = "Buscar";
            this.BuscarCiudad.UseVisualStyleBackColor = true;
            // 
            // nuevoCiudad
            // 
            this.nuevoCiudad.Location = new System.Drawing.Point(334, 97);
            this.nuevoCiudad.Name = "nuevoCiudad";
            this.nuevoCiudad.Size = new System.Drawing.Size(75, 23);
            this.nuevoCiudad.TabIndex = 3;
            this.nuevoCiudad.Text = "Nuevo";
            this.nuevoCiudad.UseVisualStyleBackColor = true;
            this.nuevoCiudad.Click += new System.EventHandler(this.nuevoCiudad_Click);
            // 
            // modificarCiudad
            // 
            this.modificarCiudad.Location = new System.Drawing.Point(334, 142);
            this.modificarCiudad.Name = "modificarCiudad";
            this.modificarCiudad.Size = new System.Drawing.Size(75, 23);
            this.modificarCiudad.TabIndex = 4;
            this.modificarCiudad.Text = "Modificar";
            this.modificarCiudad.UseVisualStyleBackColor = true;
            this.modificarCiudad.Click += new System.EventHandler(this.modificarCiudad_Click);
            // 
            // eliminarCiudad
            // 
            this.eliminarCiudad.Location = new System.Drawing.Point(334, 190);
            this.eliminarCiudad.Name = "eliminarCiudad";
            this.eliminarCiudad.Size = new System.Drawing.Size(75, 23);
            this.eliminarCiudad.TabIndex = 5;
            this.eliminarCiudad.Text = "Eliminar";
            this.eliminarCiudad.UseVisualStyleBackColor = true;
            this.eliminarCiudad.Click += new System.EventHandler(this.eliminarCiudad_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ABMCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 324);
            this.Controls.Add(this.eliminarCiudad);
            this.Controls.Add(this.modificarCiudad);
            this.Controls.Add(this.nuevoCiudad);
            this.Controls.Add(this.BuscarCiudad);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.ciudadDataGrid);
            this.Name = "ABMCiudad";
            this.Text = "ABM Ciudad";
            this.Load += new System.EventHandler(this.ABMCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ciudadDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ciudadDataGrid;
        private DataSetCiudad dataSetCiudad;
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        private DataSetCiudadTableAdapters.CiudadTableAdapter ciudadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button BuscarCiudad;
        private System.Windows.Forms.Button nuevoCiudad;
        private System.Windows.Forms.Button modificarCiudad;
        private System.Windows.Forms.Button eliminarCiudad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}