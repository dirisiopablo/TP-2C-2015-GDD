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
            this.ABMAeronave_Button = new System.Windows.Forms.Button();
            this.ABMRuta_Button = new System.Windows.Forms.Button();
            this.generarViajeButton = new System.Windows.Forms.Button();
            this.compraButton = new System.Windows.Forms.Button();
            this.estadisticasButton = new System.Windows.Forms.Button();
            this.devolucionButton = new System.Windows.Forms.Button();
            this.consultarMillasButton = new System.Windows.Forms.Button();
            this.canjearMillasButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ABMRol_Button
            // 
            this.ABMRol_Button.Location = new System.Drawing.Point(117, 286);
            this.ABMRol_Button.Name = "ABMRol_Button";
            this.ABMRol_Button.Size = new System.Drawing.Size(87, 51);
            this.ABMRol_Button.TabIndex = 0;
            this.ABMRol_Button.Text = "ABM Rol";
            this.ABMRol_Button.Click += new System.EventHandler(this.ABMRol_Button_Click);
            // 
            // ABMAeronave_Button
            // 
            this.ABMAeronave_Button.Location = new System.Drawing.Point(210, 286);
            this.ABMAeronave_Button.Name = "ABMAeronave_Button";
            this.ABMAeronave_Button.Size = new System.Drawing.Size(92, 51);
            this.ABMAeronave_Button.TabIndex = 3;
            this.ABMAeronave_Button.Text = "ABM Aeronave";
            this.ABMAeronave_Button.UseVisualStyleBackColor = true;
            this.ABMAeronave_Button.Click += new System.EventHandler(this.ABMAeronave_Button_Click);
            // 
            // ABMRuta_Button
            // 
            this.ABMRuta_Button.Location = new System.Drawing.Point(308, 286);
            this.ABMRuta_Button.Name = "ABMRuta_Button";
            this.ABMRuta_Button.Size = new System.Drawing.Size(88, 51);
            this.ABMRuta_Button.TabIndex = 4;
            this.ABMRuta_Button.Text = "ABM Ruta";
            this.ABMRuta_Button.UseVisualStyleBackColor = true;
            this.ABMRuta_Button.Click += new System.EventHandler(this.ABMRuta_Button_Click);
            // 
            // generarViajeButton
            // 
            this.generarViajeButton.Location = new System.Drawing.Point(402, 286);
            this.generarViajeButton.Name = "generarViajeButton";
            this.generarViajeButton.Size = new System.Drawing.Size(88, 51);
            this.generarViajeButton.TabIndex = 5;
            this.generarViajeButton.Text = "Generar Viaje";
            this.generarViajeButton.UseVisualStyleBackColor = true;
            this.generarViajeButton.Click += new System.EventHandler(this.generarViajeButton_Click);
            // 
            // compraButton
            // 
            this.compraButton.Location = new System.Drawing.Point(156, 90);
            this.compraButton.Name = "compraButton";
            this.compraButton.Size = new System.Drawing.Size(88, 48);
            this.compraButton.TabIndex = 6;
            this.compraButton.Text = "Comprar ";
            this.compraButton.UseVisualStyleBackColor = true;
            this.compraButton.Click += new System.EventHandler(this.compraButton_Click);
            // 
            // estadisticasButton
            // 
            this.estadisticasButton.Location = new System.Drawing.Point(438, 90);
            this.estadisticasButton.Name = "estadisticasButton";
            this.estadisticasButton.Size = new System.Drawing.Size(92, 48);
            this.estadisticasButton.TabIndex = 7;
            this.estadisticasButton.Text = "Estadisticas";
            this.estadisticasButton.UseVisualStyleBackColor = true;
            this.estadisticasButton.Click += new System.EventHandler(this.estadisticasButton_Click);
            // 
            // devolucionButton
            // 
            this.devolucionButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.devolucionButton.Location = new System.Drawing.Point(496, 286);
            this.devolucionButton.Name = "devolucionButton";
            this.devolucionButton.Size = new System.Drawing.Size(88, 51);
            this.devolucionButton.TabIndex = 8;
            this.devolucionButton.Text = "Devolución";
            this.devolucionButton.UseVisualStyleBackColor = true;
            this.devolucionButton.Click += new System.EventHandler(this.devolucionButton_Click);
            // 
            // consultarMillasButton
            // 
            this.consultarMillasButton.Location = new System.Drawing.Point(250, 90);
            this.consultarMillasButton.Name = "consultarMillasButton";
            this.consultarMillasButton.Size = new System.Drawing.Size(88, 48);
            this.consultarMillasButton.TabIndex = 9;
            this.consultarMillasButton.Text = "Consultar Millas";
            this.consultarMillasButton.UseVisualStyleBackColor = true;
            this.consultarMillasButton.Click += new System.EventHandler(this.consultarMillasButton_Click);
            // 
            // canjearMillasButton
            // 
            this.canjearMillasButton.Location = new System.Drawing.Point(344, 90);
            this.canjearMillasButton.Name = "canjearMillasButton";
            this.canjearMillasButton.Size = new System.Drawing.Size(88, 48);
            this.canjearMillasButton.TabIndex = 10;
            this.canjearMillasButton.Text = "Canjear Millas";
            this.canjearMillasButton.UseVisualStyleBackColor = true;
            this.canjearMillasButton.Click += new System.EventHandler(this.canjearMillasButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(223, 186);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(239, 23);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "Ingresar como Administrador";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 382);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.canjearMillasButton);
            this.Controls.Add(this.consultarMillasButton);
            this.Controls.Add(this.devolucionButton);
            this.Controls.Add(this.estadisticasButton);
            this.Controls.Add(this.compraButton);
            this.Controls.Add(this.generarViajeButton);
            this.Controls.Add(this.ABMRuta_Button);
            this.Controls.Add(this.ABMAeronave_Button);
            this.Controls.Add(this.ABMRol_Button);
            this.Name = "MainForm";
            this.Text = "Aerolinea FRBA";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ABMRol_Button;
        private System.Windows.Forms.Button ABMAeronave_Button;
        private System.Windows.Forms.Button ABMRuta_Button;
        private System.Windows.Forms.Button generarViajeButton;
        private System.Windows.Forms.Button compraButton;
        private System.Windows.Forms.Button estadisticasButton;
        private System.Windows.Forms.Button devolucionButton;
        private System.Windows.Forms.Button consultarMillasButton;
        private System.Windows.Forms.Button canjearMillasButton;
        private System.Windows.Forms.Button loginButton;

    }
}