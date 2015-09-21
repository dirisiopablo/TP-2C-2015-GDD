namespace AerolineaFrba.Abm_Rol
{
    partial class ABMRol
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
            this.components = new System.ComponentModel.Container();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.rolDatagrid = new System.Windows.Forms.DataGridView();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.rolTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.RolTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rolDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(306, 33);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(75, 23);
            this.Nuevo.TabIndex = 0;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(306, 77);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 1;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(306, 120);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // rolDatagrid
            // 
            this.rolDatagrid.AutoGenerateColumns = false;
            this.rolDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.rolDatagrid.DataSource = this.rolBindingSource;
            this.rolDatagrid.Location = new System.Drawing.Point(24, 12);
            this.rolDatagrid.Name = "rolDatagrid";
            this.rolDatagrid.Size = new System.Drawing.Size(244, 231);
            this.rolDatagrid.TabIndex = 3;
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
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
            // ABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 288);
            this.Controls.Add(this.rolDatagrid);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Nuevo);
            this.Name = "ABMRol";
            this.Text = "ABM Rol";
            this.Load += new System.EventHandler(this.ABMRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.DataGridView rolDatagrid;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private GD2C2015DataSetTableAdapters.RolTableAdapter rolTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}