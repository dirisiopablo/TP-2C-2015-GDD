namespace AerolineaFrba.ABM.Abm_Aeronave {
    partial class AeronaveDialog {
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
            this.matriculaTextbox = new System.Windows.Forms.TextBox();
            this.modeloTextbox = new System.Windows.Forms.TextBox();
            this.kgTextbox = new System.Windows.Forms.TextBox();
            this.fabricanteTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guardarAeronave = new System.Windows.Forms.Button();
            this.cancelarAeronave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matriculaTextbox
            // 
            this.matriculaTextbox.Location = new System.Drawing.Point(170, 47);
            this.matriculaTextbox.Name = "matriculaTextbox";
            this.matriculaTextbox.Size = new System.Drawing.Size(148, 20);
            this.matriculaTextbox.TabIndex = 0;
            // 
            // modeloTextbox
            // 
            this.modeloTextbox.Location = new System.Drawing.Point(170, 85);
            this.modeloTextbox.Name = "modeloTextbox";
            this.modeloTextbox.Size = new System.Drawing.Size(148, 20);
            this.modeloTextbox.TabIndex = 1;
            // 
            // kgTextbox
            // 
            this.kgTextbox.Location = new System.Drawing.Point(170, 125);
            this.kgTextbox.Name = "kgTextbox";
            this.kgTextbox.Size = new System.Drawing.Size(148, 20);
            this.kgTextbox.TabIndex = 2;
            // 
            // fabricanteTextbox
            // 
            this.fabricanteTextbox.Location = new System.Drawing.Point(170, 165);
            this.fabricanteTextbox.Name = "fabricanteTextbox";
            this.fabricanteTextbox.Size = new System.Drawing.Size(148, 20);
            this.fabricanteTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kg Disponibles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fabricante";
            // 
            // guardarAeronave
            // 
            this.guardarAeronave.Location = new System.Drawing.Point(233, 232);
            this.guardarAeronave.Name = "guardarAeronave";
            this.guardarAeronave.Size = new System.Drawing.Size(85, 26);
            this.guardarAeronave.TabIndex = 8;
            this.guardarAeronave.Text = "Guardar";
            this.guardarAeronave.UseVisualStyleBackColor = true;
            this.guardarAeronave.Click += new System.EventHandler(this.guardarAeronave_Click);
            // 
            // cancelarAeronave
            // 
            this.cancelarAeronave.Location = new System.Drawing.Point(36, 232);
            this.cancelarAeronave.Name = "cancelarAeronave";
            this.cancelarAeronave.Size = new System.Drawing.Size(89, 26);
            this.cancelarAeronave.TabIndex = 9;
            this.cancelarAeronave.Text = "Cancelar";
            this.cancelarAeronave.UseVisualStyleBackColor = true;
            this.cancelarAeronave.Click += new System.EventHandler(this.cancelarAeronave_Click);
            // 
            // AeronaveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 283);
            this.Controls.Add(this.cancelarAeronave);
            this.Controls.Add(this.guardarAeronave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fabricanteTextbox);
            this.Controls.Add(this.kgTextbox);
            this.Controls.Add(this.modeloTextbox);
            this.Controls.Add(this.matriculaTextbox);
            this.Name = "AeronaveDialog";
            this.Text = "Aeronave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox matriculaTextbox;
        private System.Windows.Forms.TextBox modeloTextbox;
        private System.Windows.Forms.TextBox kgTextbox;
        private System.Windows.Forms.TextBox fabricanteTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button guardarAeronave;
        private System.Windows.Forms.Button cancelarAeronave;
    }
}