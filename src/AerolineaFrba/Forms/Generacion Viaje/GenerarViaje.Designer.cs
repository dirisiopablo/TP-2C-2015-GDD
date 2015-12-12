namespace AerolineaFrba.Forms.Generacion_Viaje {
    partial class GenerarViaje {
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
            this.guardarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.aeronaveCombo = new System.Windows.Forms.ComboBox();
            this.aeronaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet3 = new AerolineaFrba.GD2C2015DataSet3();
            this.aeronaveTableAdapter = new AerolineaFrba.GD2C2015DataSet3TableAdapters.AeronaveTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.rutaCombo = new System.Windows.Forms.ComboBox();
            this.rutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet4 = new AerolineaFrba.GD2C2015DataSet4();
            this.rutaTableAdapter = new AerolineaFrba.GD2C2015DataSet4TableAdapters.RutaTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tipoServicioRutaLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tipoServicioLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Aeronave = new System.Windows.Forms.Label();
            this.destinoLabel = new System.Windows.Forms.Label();
            this.origenLabel = new System.Windows.Forms.Label();
            this.precioPasajeLabel = new System.Windows.Forms.Label();
            this.precioKgLabel = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.kgLabel = new System.Windows.Forms.Label();
            this.fabModeloLabel = new System.Windows.Forms.Label();
            this.matriculaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(461, 426);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(97, 33);
            this.guardarButton.TabIndex = 0;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click_1);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(187, 426);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(97, 33);
            this.cancelarButton.TabIndex = 1;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click_1);
            // 
            // aeronaveCombo
            // 
            this.aeronaveCombo.DataSource = this.aeronaveBindingSource;
            this.aeronaveCombo.DisplayMember = "matricula";
            this.aeronaveCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aeronaveCombo.FormattingEnabled = true;
            this.aeronaveCombo.Location = new System.Drawing.Point(142, 112);
            this.aeronaveCombo.Name = "aeronaveCombo";
            this.aeronaveCombo.Size = new System.Drawing.Size(200, 21);
            this.aeronaveCombo.TabIndex = 2;
            this.aeronaveCombo.ValueMember = "id";
            this.aeronaveCombo.SelectedIndexChanged += new System.EventHandler(this.aeronaveCombo_SelectedIndexChanged_1);
            // 
            // aeronaveBindingSource
            // 
            this.aeronaveBindingSource.DataMember = "Aeronave";
            this.aeronaveBindingSource.DataSource = this.gD2C2015DataSet3;
            // 
            // gD2C2015DataSet3
            // 
            this.gD2C2015DataSet3.DataSetName = "GD2C2015DataSet3";
            this.gD2C2015DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeronaveTableAdapter
            // 
            this.aeronaveTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aeronave";
            // 
            // rutaCombo
            // 
            this.rutaCombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rutaBindingSource, "id", true));
            this.rutaCombo.DataSource = this.rutaBindingSource;
            this.rutaCombo.DisplayMember = "codigo";
            this.rutaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rutaCombo.FormattingEnabled = true;
            this.rutaCombo.Location = new System.Drawing.Point(142, 161);
            this.rutaCombo.Name = "rutaCombo";
            this.rutaCombo.Size = new System.Drawing.Size(200, 21);
            this.rutaCombo.TabIndex = 4;
            this.rutaCombo.ValueMember = "id";
            this.rutaCombo.SelectedIndexChanged += new System.EventHandler(this.rutaCombo_SelectedIndexChanged_1);
            // 
            // rutaBindingSource
            // 
            this.rutaBindingSource.DataMember = "Ruta";
            this.rutaBindingSource.DataSource = this.gD2C2015DataSet4;
            // 
            // gD2C2015DataSet4
            // 
            this.gD2C2015DataSet4.DataSetName = "GD2C2015DataSet4";
            this.gD2C2015DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rutaTableAdapter
            // 
            this.rutaTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ruta Aerea";
            // 
            // fechaPicker
            // 
            this.fechaPicker.Location = new System.Drawing.Point(142, 206);
            this.fechaPicker.Name = "fechaPicker";
            this.fechaPicker.Size = new System.Drawing.Size(200, 20);
            this.fechaPicker.TabIndex = 6;
            this.fechaPicker.Value = new System.DateTime(2015, 12, 12, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha Salida";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tipoServicioRutaLabel);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tipoServicioLabel);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Aeronave);
            this.panel1.Controls.Add(this.destinoLabel);
            this.panel1.Controls.Add(this.origenLabel);
            this.panel1.Controls.Add(this.precioPasajeLabel);
            this.panel1.Controls.Add(this.precioKgLabel);
            this.panel1.Controls.Add(this.codigoLabel);
            this.panel1.Controls.Add(this.kgLabel);
            this.panel1.Controls.Add(this.fabModeloLabel);
            this.panel1.Controls.Add(this.matriculaLabel);
            this.panel1.Location = new System.Drawing.Point(394, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 377);
            this.panel1.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Tipo de Servicio: ";
            // 
            // tipoServicioRutaLabel
            // 
            this.tipoServicioRutaLabel.AutoSize = true;
            this.tipoServicioRutaLabel.Location = new System.Drawing.Point(115, 336);
            this.tipoServicioRutaLabel.Name = "tipoServicioRutaLabel";
            this.tipoServicioRutaLabel.Size = new System.Drawing.Size(24, 13);
            this.tipoServicioRutaLabel.TabIndex = 19;
            this.tipoServicioRutaLabel.Text = "mat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Tipo de Servicio: ";
            // 
            // tipoServicioLabel
            // 
            this.tipoServicioLabel.AutoSize = true;
            this.tipoServicioLabel.Location = new System.Drawing.Point(115, 131);
            this.tipoServicioLabel.Name = "tipoServicioLabel";
            this.tipoServicioLabel.Size = new System.Drawing.Size(24, 13);
            this.tipoServicioLabel.TabIndex = 17;
            this.tipoServicioLabel.Text = "mat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ciudad destino:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ciudad origen:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Precio base / pasaje:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Precio base / kg:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cod.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kg. Disponibles: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Matricula: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ruta Aerea";
            // 
            // Aeronave
            // 
            this.Aeronave.AutoSize = true;
            this.Aeronave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aeronave.Location = new System.Drawing.Point(22, 24);
            this.Aeronave.Name = "Aeronave";
            this.Aeronave.Size = new System.Drawing.Size(69, 17);
            this.Aeronave.TabIndex = 8;
            this.Aeronave.Text = "Aeronave";
            // 
            // destinoLabel
            // 
            this.destinoLabel.AutoSize = true;
            this.destinoLabel.Location = new System.Drawing.Point(103, 312);
            this.destinoLabel.Name = "destinoLabel";
            this.destinoLabel.Size = new System.Drawing.Size(0, 13);
            this.destinoLabel.TabIndex = 7;
            // 
            // origenLabel
            // 
            this.origenLabel.AutoSize = true;
            this.origenLabel.Location = new System.Drawing.Point(103, 290);
            this.origenLabel.Name = "origenLabel";
            this.origenLabel.Size = new System.Drawing.Size(0, 13);
            this.origenLabel.TabIndex = 6;
            // 
            // precioPasajeLabel
            // 
            this.precioPasajeLabel.AutoSize = true;
            this.precioPasajeLabel.Location = new System.Drawing.Point(139, 264);
            this.precioPasajeLabel.Name = "precioPasajeLabel";
            this.precioPasajeLabel.Size = new System.Drawing.Size(0, 13);
            this.precioPasajeLabel.TabIndex = 5;
            // 
            // precioKgLabel
            // 
            this.precioKgLabel.AutoSize = true;
            this.precioKgLabel.Location = new System.Drawing.Point(119, 240);
            this.precioKgLabel.Name = "precioKgLabel";
            this.precioKgLabel.Size = new System.Drawing.Size(0, 13);
            this.precioKgLabel.TabIndex = 4;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(62, 214);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(0, 13);
            this.codigoLabel.TabIndex = 3;
            // 
            // kgLabel
            // 
            this.kgLabel.AutoSize = true;
            this.kgLabel.Location = new System.Drawing.Point(117, 107);
            this.kgLabel.Name = "kgLabel";
            this.kgLabel.Size = new System.Drawing.Size(0, 13);
            this.kgLabel.TabIndex = 2;
            // 
            // fabModeloLabel
            // 
            this.fabModeloLabel.AutoSize = true;
            this.fabModeloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fabModeloLabel.Location = new System.Drawing.Point(22, 54);
            this.fabModeloLabel.Name = "fabModeloLabel";
            this.fabModeloLabel.Size = new System.Drawing.Size(0, 13);
            this.fabModeloLabel.TabIndex = 1;
            // 
            // matriculaLabel
            // 
            this.matriculaLabel.AutoSize = true;
            this.matriculaLabel.Location = new System.Drawing.Point(81, 81);
            this.matriculaLabel.Name = "matriculaLabel";
            this.matriculaLabel.Size = new System.Drawing.Size(24, 13);
            this.matriculaLabel.TabIndex = 0;
            this.matriculaLabel.Text = "mat";
            // 
            // GenerarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rutaCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aeronaveCombo);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.guardarButton);
            this.Name = "GenerarViaje";
            this.Text = "GenerarViaje";
            this.Load += new System.EventHandler(this.GenerarViaje_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.ComboBox aeronaveCombo;
        private GD2C2015DataSet3 gD2C2015DataSet3;
        private System.Windows.Forms.BindingSource aeronaveBindingSource;
        private GD2C2015DataSet3TableAdapters.AeronaveTableAdapter aeronaveTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rutaCombo;
        private GD2C2015DataSet4 gD2C2015DataSet4;
        private System.Windows.Forms.BindingSource rutaBindingSource;
        private GD2C2015DataSet4TableAdapters.RutaTableAdapter rutaTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label matriculaLabel;
        private System.Windows.Forms.Label fabModeloLabel;
        private System.Windows.Forms.Label kgLabel;
        private System.Windows.Forms.Label precioPasajeLabel;
        private System.Windows.Forms.Label precioKgLabel;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label destinoLabel;
        private System.Windows.Forms.Label origenLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Aeronave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label tipoServicioLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label tipoServicioRutaLabel;
    }
}