namespace AerolineaFrba.ABM.Abm_Ciudad {
    partial class CiudadDialog {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.descripcionCiudad = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.guardarCiudad = new System.Windows.Forms.Button();
            this.cancelarCiudad = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Descripcion);
            this.panel1.Controls.Add(this.descripcionCiudad);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 120);
            this.panel1.TabIndex = 0;
            // 
            // descripcionCiudad
            // 
            this.descripcionCiudad.Location = new System.Drawing.Point(112, 29);
            this.descripcionCiudad.Name = "descripcionCiudad";
            this.descripcionCiudad.Size = new System.Drawing.Size(119, 20);
            this.descripcionCiudad.TabIndex = 0;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(45, 32);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 1;
            this.Descripcion.Text = "Descripción";
            // 
            // guardarCiudad
            // 
            this.guardarCiudad.Location = new System.Drawing.Point(167, 138);
            this.guardarCiudad.Name = "guardarCiudad";
            this.guardarCiudad.Size = new System.Drawing.Size(105, 28);
            this.guardarCiudad.TabIndex = 0;
            this.guardarCiudad.Text = "Guardar";
            this.guardarCiudad.UseVisualStyleBackColor = true;
            this.guardarCiudad.Click += new System.EventHandler(this.guardarCiudad_Click);
            // 
            // cancelarCiudad
            // 
            this.cancelarCiudad.Location = new System.Drawing.Point(12, 138);
            this.cancelarCiudad.Name = "cancelarCiudad";
            this.cancelarCiudad.Size = new System.Drawing.Size(108, 28);
            this.cancelarCiudad.TabIndex = 1;
            this.cancelarCiudad.Text = "Cancelar";
            this.cancelarCiudad.UseVisualStyleBackColor = true;
            // 
            // CiudadDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 178);
            this.Controls.Add(this.cancelarCiudad);
            this.Controls.Add(this.guardarCiudad);
            this.Controls.Add(this.panel1);
            this.Name = "CiudadDialog";
            this.Text = "CiudadDialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox descripcionCiudad;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Button guardarCiudad;
        private System.Windows.Forms.Button cancelarCiudad;
    }
}