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
            this.nuevoCiudad = new System.Windows.Forms.Button();
            this.modificarCiudad = new System.Windows.Forms.Button();
            this.eliminarCiudad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inactivoInput = new System.Windows.Forms.CheckBox();
            this.descripcionInput = new System.Windows.Forms.TextBox();
            this.activoInput = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.limpiarCampos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.ciudadDataGrid.Size = new System.Drawing.Size(300, 169);
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
            this.ciudadBindingSource.CurrentChanged += new System.EventHandler(this.ciudadBindingSource_CurrentChanged);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.inactivoInput);
            this.panel1.Controls.Add(this.descripcionInput);
            this.panel1.Controls.Add(this.activoInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Buscar);
            this.panel1.Controls.Add(this.limpiarCampos);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 54);
            this.panel1.TabIndex = 8;
            // 
            // inactivoInput
            // 
            this.inactivoInput.AutoSize = true;
            this.inactivoInput.Location = new System.Drawing.Point(138, 32);
            this.inactivoInput.Name = "inactivoInput";
            this.inactivoInput.Size = new System.Drawing.Size(64, 17);
            this.inactivoInput.TabIndex = 9;
            this.inactivoInput.Text = "Inactivo";
            this.inactivoInput.UseVisualStyleBackColor = true;
            // 
            // descripcionInput
            // 
            this.descripcionInput.Location = new System.Drawing.Point(49, 6);
            this.descripcionInput.Name = "descripcionInput";
            this.descripcionInput.Size = new System.Drawing.Size(100, 20);
            this.descripcionInput.TabIndex = 8;
            // 
            // activoInput
            // 
            this.activoInput.AutoSize = true;
            this.activoInput.Location = new System.Drawing.Point(49, 32);
            this.activoInput.Name = "activoInput";
            this.activoInput.Size = new System.Drawing.Size(56, 17);
            this.activoInput.TabIndex = 7;
            this.activoInput.Text = "Activo";
            this.activoInput.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripción";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(243, 3);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(103, 23);
            this.Buscar.TabIndex = 4;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // limpiarCampos
            // 
            this.limpiarCampos.Location = new System.Drawing.Point(243, 28);
            this.limpiarCampos.Name = "limpiarCampos";
            this.limpiarCampos.Size = new System.Drawing.Size(103, 23);
            this.limpiarCampos.TabIndex = 5;
            this.limpiarCampos.Text = "Limpiar Campos";
            this.limpiarCampos.UseVisualStyleBackColor = true;
            this.limpiarCampos.Click += new System.EventHandler(this.limpiarCampos_Click);
            // 
            // ABMCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eliminarCiudad);
            this.Controls.Add(this.modificarCiudad);
            this.Controls.Add(this.nuevoCiudad);
            this.Controls.Add(this.ciudadDataGrid);
            this.Name = "ABMCiudad";
            this.Text = "ABM Ciudad";
            this.Load += new System.EventHandler(this.ABMCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ciudadDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ciudadDataGrid;
        private DataSetCiudad dataSetCiudad;
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        private DataSetCiudadTableAdapters.CiudadTableAdapter ciudadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button nuevoCiudad;
        private System.Windows.Forms.Button modificarCiudad;
        private System.Windows.Forms.Button eliminarCiudad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox inactivoInput;
        private System.Windows.Forms.TextBox descripcionInput;
        private System.Windows.Forms.CheckBox activoInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button limpiarCampos;
    }
}