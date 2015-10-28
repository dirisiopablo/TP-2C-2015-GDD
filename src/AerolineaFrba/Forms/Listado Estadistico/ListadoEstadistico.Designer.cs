namespace AerolineaFrba.Forms.Listado_Estadistico {
    partial class ListadoEstadistico {
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
            this.anioCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.semestreCombo = new System.Windows.Forms.ComboBox();
            this.destinosPasajesButton = new System.Windows.Forms.Button();
            this.destinosVaciosButton = new System.Windows.Forms.Button();
            this.clientesPuntosButton = new System.Windows.Forms.Button();
            this.destinosCanceladosButton = new System.Windows.Forms.Button();
            this.aeronaveBajaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // anioCombo
            // 
            this.anioCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anioCombo.FormattingEnabled = true;
            this.anioCombo.Location = new System.Drawing.Point(61, 25);
            this.anioCombo.Name = "anioCombo";
            this.anioCombo.Size = new System.Drawing.Size(145, 21);
            this.anioCombo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Semestre:";
            // 
            // semestreCombo
            // 
            this.semestreCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semestreCombo.FormattingEnabled = true;
            this.semestreCombo.Items.AddRange(new object[] {
            "Primero",
            "Segundo"});
            this.semestreCombo.Location = new System.Drawing.Point(331, 25);
            this.semestreCombo.Name = "semestreCombo";
            this.semestreCombo.Size = new System.Drawing.Size(136, 21);
            this.semestreCombo.TabIndex = 3;
            // 
            // destinosPasajesButton
            // 
            this.destinosPasajesButton.Location = new System.Drawing.Point(50, 76);
            this.destinosPasajesButton.Name = "destinosPasajesButton";
            this.destinosPasajesButton.Size = new System.Drawing.Size(118, 53);
            this.destinosPasajesButton.TabIndex = 4;
            this.destinosPasajesButton.Text = "Destinos mas vendidos";
            this.destinosPasajesButton.UseVisualStyleBackColor = true;
            this.destinosPasajesButton.Click += new System.EventHandler(this.destinosPasajesButton_Click);
            // 
            // destinosVaciosButton
            // 
            this.destinosVaciosButton.Location = new System.Drawing.Point(198, 76);
            this.destinosVaciosButton.Name = "destinosVaciosButton";
            this.destinosVaciosButton.Size = new System.Drawing.Size(118, 53);
            this.destinosVaciosButton.TabIndex = 5;
            this.destinosVaciosButton.Text = "Destinos con aeronaves mas vacias";
            this.destinosVaciosButton.UseVisualStyleBackColor = true;
            this.destinosVaciosButton.Click += new System.EventHandler(this.destinosVaciosButton_Click);
            // 
            // clientesPuntosButton
            // 
            this.clientesPuntosButton.Location = new System.Drawing.Point(345, 76);
            this.clientesPuntosButton.Name = "clientesPuntosButton";
            this.clientesPuntosButton.Size = new System.Drawing.Size(118, 53);
            this.clientesPuntosButton.TabIndex = 6;
            this.clientesPuntosButton.Text = "Clientes con mas puntos acumulados";
            this.clientesPuntosButton.UseVisualStyleBackColor = true;
            this.clientesPuntosButton.Click += new System.EventHandler(this.clientesPuntosButton_Click);
            // 
            // destinosCanceladosButton
            // 
            this.destinosCanceladosButton.Location = new System.Drawing.Point(125, 160);
            this.destinosCanceladosButton.Name = "destinosCanceladosButton";
            this.destinosCanceladosButton.Size = new System.Drawing.Size(118, 53);
            this.destinosCanceladosButton.TabIndex = 7;
            this.destinosCanceladosButton.Text = "Destinos con pasajes mas cancelados";
            this.destinosCanceladosButton.UseVisualStyleBackColor = true;
            this.destinosCanceladosButton.Click += new System.EventHandler(this.destinosCanceladosButton_Click);
            // 
            // aeronaveBajaButton
            // 
            this.aeronaveBajaButton.Location = new System.Drawing.Point(274, 160);
            this.aeronaveBajaButton.Name = "aeronaveBajaButton";
            this.aeronaveBajaButton.Size = new System.Drawing.Size(118, 53);
            this.aeronaveBajaButton.TabIndex = 8;
            this.aeronaveBajaButton.Text = "Aeronaves con mas dias fuera de servicio";
            this.aeronaveBajaButton.UseVisualStyleBackColor = true;
            this.aeronaveBajaButton.Click += new System.EventHandler(this.aeronaveBajaButton_Click);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 245);
            this.Controls.Add(this.aeronaveBajaButton);
            this.Controls.Add(this.destinosCanceladosButton);
            this.Controls.Add(this.clientesPuntosButton);
            this.Controls.Add(this.destinosVaciosButton);
            this.Controls.Add(this.destinosPasajesButton);
            this.Controls.Add(this.semestreCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.anioCombo);
            this.Controls.Add(this.label1);
            this.Name = "ListadoEstadistico";
            this.Text = "Estadisticas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox anioCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox semestreCombo;
        private System.Windows.Forms.Button destinosPasajesButton;
        private System.Windows.Forms.Button destinosVaciosButton;
        private System.Windows.Forms.Button clientesPuntosButton;
        private System.Windows.Forms.Button destinosCanceladosButton;
        private System.Windows.Forms.Button aeronaveBajaButton;
    }
}