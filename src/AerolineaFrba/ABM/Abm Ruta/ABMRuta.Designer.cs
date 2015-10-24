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
            this.rutaDataGrid = new System.Windows.Forms.DataGridView();
            this.rutaDataSet = new AerolineaFrba.rutaDataSet();
            this.rutaNuevo = new System.Windows.Forms.Button();
            this.rutaModificar = new System.Windows.Forms.Button();
            this.rutaEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rutaDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaDataSet)).BeginInit();
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
            // rutaDataSet
            // 
            this.rutaDataSet.DataSetName = "rutaDataSet";
            this.rutaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ABMRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 403);
            this.Controls.Add(this.rutaEliminar);
            this.Controls.Add(this.rutaModificar);
            this.Controls.Add(this.rutaNuevo);
            this.Controls.Add(this.rutaDataGrid);
            this.Name = "ABMRuta";
            this.Text = "ABM Ruta";
            this.Load += new System.EventHandler(this.ABMRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rutaDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView rutaDataGrid;
        private rutaDataSet rutaDataSet;
        private System.Windows.Forms.Button rutaNuevo;
        private System.Windows.Forms.Button rutaModificar;
        private System.Windows.Forms.Button rutaEliminar;
    }
}