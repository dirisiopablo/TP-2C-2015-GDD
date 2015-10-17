namespace AerolineaFrba {
    partial class MainForm {
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
            this.ABMRol_Button = new System.Windows.Forms.Button();
            this.generarViaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ABMRol_Button
            // 
            this.ABMRol_Button.Location = new System.Drawing.Point(40, 28);
            this.ABMRol_Button.Name = "ABMRol_Button";
            this.ABMRol_Button.Size = new System.Drawing.Size(77, 51);
            this.ABMRol_Button.TabIndex = 0;
            this.ABMRol_Button.Text = "ABM Rol";
            this.ABMRol_Button.Click += new System.EventHandler(this.ABMRol_Button_Click);
            // 
            // generarViaje
            // 
            this.generarViaje.Location = new System.Drawing.Point(42, 371);
            this.generarViaje.Name = "generarViaje";
            this.generarViaje.Size = new System.Drawing.Size(75, 45);
            this.generarViaje.TabIndex = 1;
            this.generarViaje.Text = "Generar Viaje";
            this.generarViaje.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 469);
            this.Controls.Add(this.generarViaje);
            this.Controls.Add(this.ABMRol_Button);
            this.Name = "MainForm";
            this.Text = "Aerolinea FRBA";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ABMRol_Button;
        private System.Windows.Forms.Button generarViaje;

    }
}