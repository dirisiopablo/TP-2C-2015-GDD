namespace AerolineaFrba.ABM.Abm_Aeronave
{
    partial class AeronaveBaja
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
            this.matriculaLabel = new System.Windows.Forms.Label();
            this.modeloLabel = new System.Windows.Forms.Label();
            this.fabricanteLabel = new System.Windows.Forms.Label();
            this.matriculaTexto = new System.Windows.Forms.Label();
            this.modeloTexto = new System.Windows.Forms.Label();
            this.fabricanteTexto = new System.Windows.Forms.Label();
            this.tipoBajaLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gD2C2015DataSet2 = new AerolineaFrba.GD2C2015DataSet2();
            this.tipoBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_BajaTableAdapter = new AerolineaFrba.GD2C2015DataSet2TableAdapters.Tipo_BajaTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.confirmarBaja = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBajaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // matriculaLabel
            // 
            this.matriculaLabel.AutoSize = true;
            this.matriculaLabel.Location = new System.Drawing.Point(6, 28);
            this.matriculaLabel.Name = "matriculaLabel";
            this.matriculaLabel.Size = new System.Drawing.Size(58, 13);
            this.matriculaLabel.TabIndex = 0;
            this.matriculaLabel.Text = "Matrícula: ";
            // 
            // modeloLabel
            // 
            this.modeloLabel.AutoSize = true;
            this.modeloLabel.Location = new System.Drawing.Point(132, 28);
            this.modeloLabel.Name = "modeloLabel";
            this.modeloLabel.Size = new System.Drawing.Size(48, 13);
            this.modeloLabel.TabIndex = 1;
            this.modeloLabel.Text = "Modelo: ";
            // 
            // fabricanteLabel
            // 
            this.fabricanteLabel.AutoSize = true;
            this.fabricanteLabel.Location = new System.Drawing.Point(235, 28);
            this.fabricanteLabel.Name = "fabricanteLabel";
            this.fabricanteLabel.Size = new System.Drawing.Size(63, 13);
            this.fabricanteLabel.TabIndex = 2;
            this.fabricanteLabel.Text = "Fabricante: ";
            // 
            // matriculaTexto
            // 
            this.matriculaTexto.AutoSize = true;
            this.matriculaTexto.Location = new System.Drawing.Point(70, 28);
            this.matriculaTexto.Name = "matriculaTexto";
            this.matriculaTexto.Size = new System.Drawing.Size(32, 13);
            this.matriculaTexto.TabIndex = 3;
            this.matriculaTexto.Text = "{text}";
            // 
            // modeloTexto
            // 
            this.modeloTexto.AutoSize = true;
            this.modeloTexto.Location = new System.Drawing.Point(186, 28);
            this.modeloTexto.Name = "modeloTexto";
            this.modeloTexto.Size = new System.Drawing.Size(32, 13);
            this.modeloTexto.TabIndex = 4;
            this.modeloTexto.Text = "{text}";
            // 
            // fabricanteTexto
            // 
            this.fabricanteTexto.AutoSize = true;
            this.fabricanteTexto.Location = new System.Drawing.Point(304, 28);
            this.fabricanteTexto.Name = "fabricanteTexto";
            this.fabricanteTexto.Size = new System.Drawing.Size(32, 13);
            this.fabricanteTexto.TabIndex = 5;
            this.fabricanteTexto.Text = "{text}";
            // 
            // tipoBajaLabel
            // 
            this.tipoBajaLabel.AutoSize = true;
            this.tipoBajaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoBajaLabel.Location = new System.Drawing.Point(57, 93);
            this.tipoBajaLabel.Name = "tipoBajaLabel";
            this.tipoBajaLabel.Size = new System.Drawing.Size(155, 15);
            this.tipoBajaLabel.TabIndex = 1;
            this.tipoBajaLabel.Text = "Seleccione un tipo de baja:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tipoBajaBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // gD2C2015DataSet2
            // 
            this.gD2C2015DataSet2.DataSetName = "GD2C2015DataSet2";
            this.gD2C2015DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoBajaBindingSource
            // 
            this.tipoBajaBindingSource.DataMember = "Tipo_Baja";
            this.tipoBajaBindingSource.DataSource = this.gD2C2015DataSet2;
            // 
            // tipo_BajaTableAdapter
            // 
            this.tipo_BajaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fabricanteTexto);
            this.groupBox1.Controls.Add(this.matriculaLabel);
            this.groupBox1.Controls.Add(this.fabricanteLabel);
            this.groupBox1.Controls.Add(this.modeloTexto);
            this.groupBox1.Controls.Add(this.matriculaTexto);
            this.groupBox1.Controls.Add(this.modeloLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aeronave Seleccionada";
            // 
            // confirmarBaja
            // 
            this.confirmarBaja.Location = new System.Drawing.Point(268, 82);
            this.confirmarBaja.Name = "confirmarBaja";
            this.confirmarBaja.Size = new System.Drawing.Size(107, 23);
            this.confirmarBaja.TabIndex = 4;
            this.confirmarBaja.Text = "Confirmar Baja";
            this.confirmarBaja.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Descartar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AeronaveBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 153);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmarBaja);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tipoBajaLabel);
            this.Name = "AeronaveBaja";
            this.Text = "AeronaveBaja";
            this.Load += new System.EventHandler(this.AeronaveBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBajaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modeloLabel;
        private System.Windows.Forms.Label matriculaLabel;
        private System.Windows.Forms.Label fabricanteLabel;
        private System.Windows.Forms.Label fabricanteTexto;
        private System.Windows.Forms.Label modeloTexto;
        private System.Windows.Forms.Label matriculaTexto;
        private System.Windows.Forms.Label tipoBajaLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private GD2C2015DataSet2 gD2C2015DataSet2;
        private System.Windows.Forms.BindingSource tipoBajaBindingSource;
        private GD2C2015DataSet2TableAdapters.Tipo_BajaTableAdapter tipo_BajaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button confirmarBaja;
        private System.Windows.Forms.Button button1;
    }
}