namespace AerolineaFrba.Forms.Consulta_Millas {
    partial class ConsultaMillas {
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
            this.consultarButton = new System.Windows.Forms.Button();
            this.millasDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clienteNameLabel = new System.Windows.Forms.Label();
            this.puntosLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.millasDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI Cliente:";
            // 
            // DNITextbox
            // 
            this.DNITextbox.Location = new System.Drawing.Point(122, 36);
            this.DNITextbox.Name = "DNITextbox";
            this.DNITextbox.Size = new System.Drawing.Size(180, 20);
            this.DNITextbox.TabIndex = 1;
            // 
            // consultarButton
            // 
            this.consultarButton.Location = new System.Drawing.Point(359, 24);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(114, 42);
            this.consultarButton.TabIndex = 2;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.consultarButton_Click);
            // 
            // millasDataGrid
            // 
            this.millasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.millasDataGrid.Location = new System.Drawing.Point(51, 176);
            this.millasDataGrid.Name = "millasDataGrid";
            this.millasDataGrid.Size = new System.Drawing.Size(422, 425);
            this.millasDataGrid.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Puntos Acumulados:";
            // 
            // clienteNameLabel
            // 
            this.clienteNameLabel.AutoSize = true;
            this.clienteNameLabel.Location = new System.Drawing.Point(134, 84);
            this.clienteNameLabel.Name = "clienteNameLabel";
            this.clienteNameLabel.Size = new System.Drawing.Size(0, 13);
            this.clienteNameLabel.TabIndex = 6;
            // 
            // puntosLabel
            // 
            this.puntosLabel.AutoSize = true;
            this.puntosLabel.Location = new System.Drawing.Point(209, 113);
            this.puntosLabel.Name = "puntosLabel";
            this.puntosLabel.Size = new System.Drawing.Size(0, 13);
            this.puntosLabel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Detalle";
            // 
            // ConsultaMillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 613);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.puntosLabel);
            this.Controls.Add(this.clienteNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.millasDataGrid);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.DNITextbox);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaMillas";
            this.Text = "Consulta Millas";
            ((System.ComponentModel.ISupportInitialize)(this.millasDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DNITextbox;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.DataGridView millasDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label clienteNameLabel;
        private System.Windows.Forms.Label puntosLabel;
        private System.Windows.Forms.Label label4;
    }
}