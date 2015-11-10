namespace AerolineaFrba.ABM.Abm_Ruta {
    partial class RutaDialog {
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
            this.components = new System.ComponentModel.Container();
            this.codigoTextbox = new System.Windows.Forms.TextBox();
            this.pasajeTextbox = new System.Windows.Forms.TextBox();
            this.origenCombo = new System.Windows.Forms.ComboBox();
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCiudad = new AerolineaFrba.DataSetCiudad();
            this.destinoCombo = new System.Windows.Forms.ComboBox();
            this.ciudadBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCiudad2 = new AerolineaFrba.DataSetCiudad2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guardarRuta = new System.Windows.Forms.Button();
            this.cancelarRuta = new System.Windows.Forms.Button();
            this.ciudadTableAdapter = new AerolineaFrba.DataSetCiudadTableAdapters.CiudadTableAdapter();
            this.ciudadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadTableAdapter1 = new AerolineaFrba.DataSetCiudad2TableAdapters.CiudadTableAdapter();
            this.kgTextbox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoTextbox
            // 
            this.codigoTextbox.Location = new System.Drawing.Point(216, 40);
            this.codigoTextbox.Name = "codigoTextbox";
            this.codigoTextbox.Size = new System.Drawing.Size(155, 20);
            this.codigoTextbox.TabIndex = 0;
            // 
            // pasajeTextbox
            // 
            this.pasajeTextbox.Location = new System.Drawing.Point(216, 120);
            this.pasajeTextbox.Name = "pasajeTextbox";
            this.pasajeTextbox.Size = new System.Drawing.Size(155, 20);
            this.pasajeTextbox.TabIndex = 2;
            // 
            // origenCombo
            // 
            this.origenCombo.DataSource = this.ciudadBindingSource;
            this.origenCombo.DisplayMember = "descripcion";
            this.origenCombo.FormattingEnabled = true;
            this.origenCombo.Location = new System.Drawing.Point(216, 159);
            this.origenCombo.Name = "origenCombo";
            this.origenCombo.Size = new System.Drawing.Size(155, 21);
            this.origenCombo.TabIndex = 3;
            this.origenCombo.ValueMember = "id";
            // 
            // ciudadBindingSource
            // 
            this.ciudadBindingSource.DataMember = "Ciudad";
            this.ciudadBindingSource.DataSource = this.dataSetCiudad;
            // 
            // dataSetCiudad
            // 
            this.dataSetCiudad.DataSetName = "DataSetCiudad";
            this.dataSetCiudad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // destinoCombo
            // 
            this.destinoCombo.DataSource = this.ciudadBindingSource2;
            this.destinoCombo.DisplayMember = "descripcion";
            this.destinoCombo.FormattingEnabled = true;
            this.destinoCombo.Location = new System.Drawing.Point(216, 201);
            this.destinoCombo.Name = "destinoCombo";
            this.destinoCombo.Size = new System.Drawing.Size(155, 21);
            this.destinoCombo.TabIndex = 4;
            this.destinoCombo.ValueMember = "id";
            // 
            // ciudadBindingSource2
            // 
            this.ciudadBindingSource2.DataMember = "Ciudad";
            this.ciudadBindingSource2.DataSource = this.dataSetCiudad2;
            // 
            // dataSetCiudad2
            // 
            this.dataSetCiudad2.DataSetName = "DataSetCiudad2";
            this.dataSetCiudad2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precio base / KG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio base pasaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Origen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destino";
            // 
            // guardarRuta
            // 
            this.guardarRuta.Location = new System.Drawing.Point(299, 268);
            this.guardarRuta.Name = "guardarRuta";
            this.guardarRuta.Size = new System.Drawing.Size(86, 28);
            this.guardarRuta.TabIndex = 10;
            this.guardarRuta.Text = "Guardar";
            this.guardarRuta.UseVisualStyleBackColor = true;
            this.guardarRuta.Click += new System.EventHandler(this.guardarRuta_Click);
            // 
            // cancelarRuta
            // 
            this.cancelarRuta.Location = new System.Drawing.Point(40, 268);
            this.cancelarRuta.Name = "cancelarRuta";
            this.cancelarRuta.Size = new System.Drawing.Size(86, 28);
            this.cancelarRuta.TabIndex = 11;
            this.cancelarRuta.Text = "Cancelar";
            this.cancelarRuta.UseVisualStyleBackColor = true;
            this.cancelarRuta.Click += new System.EventHandler(this.cancelarRuta_Click);
            // 
            // ciudadTableAdapter
            // 
            this.ciudadTableAdapter.ClearBeforeFill = true;
            // 
            // ciudadBindingSource1
            // 
            this.ciudadBindingSource1.DataMember = "Ciudad";
            this.ciudadBindingSource1.DataSource = this.dataSetCiudad2;
            // 
            // ciudadTableAdapter1
            // 
            this.ciudadTableAdapter1.ClearBeforeFill = true;
            // 
            // kgTextbox
            // 
            this.kgTextbox.DecimalPlaces = 2;
            this.kgTextbox.Location = new System.Drawing.Point(216, 80);
            this.kgTextbox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.kgTextbox.Name = "kgTextbox";
            this.kgTextbox.Size = new System.Drawing.Size(155, 20);
            this.kgTextbox.TabIndex = 12;
            this.kgTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.kgTextbox_Validating);
            // 
            // RutaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 318);
            this.Controls.Add(this.cancelarRuta);
            this.Controls.Add(this.guardarRuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinoCombo);
            this.Controls.Add(this.origenCombo);
            this.Controls.Add(this.pasajeTextbox);
            this.Controls.Add(this.codigoTextbox);
            this.Controls.Add(this.kgTextbox);
            this.Name = "RutaDialog";
            this.Text = "Ruta";
            this.Load += new System.EventHandler(this.RutaDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgTextbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigoTextbox;
        private System.Windows.Forms.TextBox pasajeTextbox;
        private System.Windows.Forms.ComboBox origenCombo;
        private System.Windows.Forms.ComboBox destinoCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button guardarRuta;
        private System.Windows.Forms.Button cancelarRuta;
        private DataSetCiudad dataSetCiudad;
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        private DataSetCiudadTableAdapters.CiudadTableAdapter ciudadTableAdapter;
        private DataSetCiudad2 dataSetCiudad2;
        private System.Windows.Forms.BindingSource ciudadBindingSource1;
        private DataSetCiudad2TableAdapters.CiudadTableAdapter ciudadTableAdapter1;
        private System.Windows.Forms.BindingSource ciudadBindingSource2;
        private System.Windows.Forms.NumericUpDown kgTextbox;
    }
}