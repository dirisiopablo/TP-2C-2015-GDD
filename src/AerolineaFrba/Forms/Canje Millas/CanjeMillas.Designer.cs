namespace AerolineaFrba.Forms.Canje_Millas {
    partial class CanjeMillas {
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
            this.label1 = new System.Windows.Forms.Label();
            this.DNITextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productosCombo = new System.Windows.Forms.ComboBox();
            this.canjearButton = new System.Windows.Forms.Button();
            this.buscarClienteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cantidadNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.puntosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI Cliente:";
            // 
            // DNITextbox
            // 
            this.DNITextbox.Location = new System.Drawing.Point(97, 29);
            this.DNITextbox.Name = "DNITextbox";
            this.DNITextbox.Size = new System.Drawing.Size(149, 20);
            this.DNITextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(78, 73);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(0, 13);
            this.clienteLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Productos Disponibles:";
            // 
            // productosCombo
            // 
            this.productosCombo.FormattingEnabled = true;
            this.productosCombo.Location = new System.Drawing.Point(184, 130);
            this.productosCombo.Name = "productosCombo";
            this.productosCombo.Size = new System.Drawing.Size(260, 21);
            this.productosCombo.TabIndex = 5;
            // 
            // canjearButton
            // 
            this.canjearButton.Location = new System.Drawing.Point(490, 133);
            this.canjearButton.Name = "canjearButton";
            this.canjearButton.Size = new System.Drawing.Size(75, 47);
            this.canjearButton.TabIndex = 6;
            this.canjearButton.Text = "Canjear";
            this.canjearButton.UseVisualStyleBackColor = true;
            this.canjearButton.Click += new System.EventHandler(this.canjearButton_Click);
            // 
            // buscarClienteButton
            // 
            this.buscarClienteButton.Location = new System.Drawing.Point(284, 26);
            this.buscarClienteButton.Name = "buscarClienteButton";
            this.buscarClienteButton.Size = new System.Drawing.Size(85, 23);
            this.buscarClienteButton.TabIndex = 7;
            this.buscarClienteButton.Text = "Buscar Cliente";
            this.buscarClienteButton.UseVisualStyleBackColor = true;
            this.buscarClienteButton.Click += new System.EventHandler(this.buscarClienteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad:";
            // 
            // cantidadNumeric
            // 
            this.cantidadNumeric.Location = new System.Drawing.Point(184, 157);
            this.cantidadNumeric.Name = "cantidadNumeric";
            this.cantidadNumeric.Size = new System.Drawing.Size(120, 20);
            this.cantidadNumeric.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Millas disponibles:";
            // 
            // puntosLabel
            // 
            this.puntosLabel.AutoSize = true;
            this.puntosLabel.Location = new System.Drawing.Point(450, 73);
            this.puntosLabel.Name = "puntosLabel";
            this.puntosLabel.Size = new System.Drawing.Size(0, 13);
            this.puntosLabel.TabIndex = 11;
            // 
            // CanjeMillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 208);
            this.Controls.Add(this.puntosLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cantidadNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buscarClienteButton);
            this.Controls.Add(this.canjearButton);
            this.Controls.Add(this.productosCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DNITextbox);
            this.Controls.Add(this.label1);
            this.Name = "CanjeMillas";
            this.Text = "Canje Millas";
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DNITextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox productosCombo;
        private System.Windows.Forms.Button canjearButton;
        private System.Windows.Forms.Button buscarClienteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cantidadNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label puntosLabel;
    }
}