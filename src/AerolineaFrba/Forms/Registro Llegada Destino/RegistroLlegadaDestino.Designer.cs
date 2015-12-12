namespace AerolineaFrba.Forms.Registro_Llegada_Destino {
    partial class RegistroLlegadaDestino {
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
            this.label1 = new System.Windows.Forms.Label();
            this.aeronaveBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet3 = new AerolineaFrba.GD2C2015DataSet3();
            this.dataSetAeronave = new AerolineaFrba.DataSetAeronave();
            this.dataSetAeronaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeronaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeronaveTableAdapter = new AerolineaFrba.DataSetAeronaveTableAdapters.AeronaveTableAdapter();
            this.aeronaveTableAdapter1 = new AerolineaFrba.GD2C2015DataSet3TableAdapters.AeronaveTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.origenCombo = new System.Windows.Forms.ComboBox();
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCiudad = new AerolineaFrba.DataSetCiudad();
            this.ciudadTableAdapter = new AerolineaFrba.DataSetCiudadTableAdapters.CiudadTableAdapter();
            this.destinoCombo = new System.Windows.Forms.ComboBox();
            this.ciudadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCiudad2 = new AerolineaFrba.DataSetCiudad2();
            this.ciudadTableAdapter1 = new AerolineaFrba.DataSetCiudad2TableAdapters.CiudadTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaPicker = new System.Windows.Forms.DateTimePicker();
            this.guardarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.matriculaTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAeronave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAeronaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // aeronaveBindingSource1
            // 
            this.aeronaveBindingSource1.DataMember = "Aeronave";
            this.aeronaveBindingSource1.DataSource = this.gD2C2015DataSet3;
            // 
            // gD2C2015DataSet3
            // 
            this.gD2C2015DataSet3.DataSetName = "GD2C2015DataSet3";
            this.gD2C2015DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetAeronave
            // 
            this.dataSetAeronave.DataSetName = "DataSetAeronave";
            this.dataSetAeronave.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetAeronaveBindingSource
            // 
            this.dataSetAeronaveBindingSource.DataSource = this.dataSetAeronave;
            this.dataSetAeronaveBindingSource.Position = 0;
            // 
            // aeronaveBindingSource
            // 
            this.aeronaveBindingSource.DataMember = "Aeronave";
            this.aeronaveBindingSource.DataSource = this.dataSetAeronaveBindingSource;
            // 
            // aeronaveTableAdapter
            // 
            this.aeronaveTableAdapter.ClearBeforeFill = true;
            // 
            // aeronaveTableAdapter1
            // 
            this.aeronaveTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destino";
            // 
            // origenCombo
            // 
            this.origenCombo.DataSource = this.ciudadBindingSource;
            this.origenCombo.DisplayMember = "descripcion";
            this.origenCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origenCombo.FormattingEnabled = true;
            this.origenCombo.Location = new System.Drawing.Point(109, 84);
            this.origenCombo.Name = "origenCombo";
            this.origenCombo.Size = new System.Drawing.Size(241, 21);
            this.origenCombo.TabIndex = 5;
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
            // ciudadTableAdapter
            // 
            this.ciudadTableAdapter.ClearBeforeFill = true;
            // 
            // destinoCombo
            // 
            this.destinoCombo.DataSource = this.ciudadBindingSource1;
            this.destinoCombo.DisplayMember = "descripcion";
            this.destinoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinoCombo.FormattingEnabled = true;
            this.destinoCombo.Location = new System.Drawing.Point(109, 123);
            this.destinoCombo.Name = "destinoCombo";
            this.destinoCombo.Size = new System.Drawing.Size(241, 21);
            this.destinoCombo.TabIndex = 6;
            this.destinoCombo.ValueMember = "id";
            // 
            // ciudadBindingSource1
            // 
            this.ciudadBindingSource1.DataMember = "Ciudad";
            this.ciudadBindingSource1.DataSource = this.dataSetCiudad2;
            // 
            // dataSetCiudad2
            // 
            this.dataSetCiudad2.DataSetName = "DataSetCiudad2";
            this.dataSetCiudad2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ciudadTableAdapter1
            // 
            this.ciudadTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha y hora";
            // 
            // fechaPicker
            // 
            this.fechaPicker.Location = new System.Drawing.Point(109, 161);
            this.fechaPicker.MinDate = new System.DateTime(2015, 10, 22, 1, 14, 19, 0);
            this.fechaPicker.Name = "fechaPicker";
            this.fechaPicker.Size = new System.Drawing.Size(241, 20);
            this.fechaPicker.TabIndex = 8;
            this.fechaPicker.Value = new System.DateTime(2015, 10, 22, 3, 14, 0, 0);
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(234, 216);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(98, 33);
            this.guardarButton.TabIndex = 9;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(71, 216);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(98, 33);
            this.cancelarButton.TabIndex = 10;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // matriculaTextbox
            // 
            this.matriculaTextbox.Location = new System.Drawing.Point(109, 46);
            this.matriculaTextbox.Name = "matriculaTextbox";
            this.matriculaTextbox.Size = new System.Drawing.Size(241, 20);
            this.matriculaTextbox.TabIndex = 11;
            // 
            // RegistroLlegadaDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 275);
            this.Controls.Add(this.matriculaTextbox);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.fechaPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.destinoCombo);
            this.Controls.Add(this.origenCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroLlegadaDestino";
            this.Text = "RegistroLlegadaDestino";
            this.Load += new System.EventHandler(this.RegistroLlegadaDestino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAeronave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAeronaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dataSetAeronaveBindingSource;
        private DataSetAeronave dataSetAeronave;
        private System.Windows.Forms.BindingSource aeronaveBindingSource;
        private DataSetAeronaveTableAdapters.AeronaveTableAdapter aeronaveTableAdapter;
        private GD2C2015DataSet3 gD2C2015DataSet3;
        private System.Windows.Forms.BindingSource aeronaveBindingSource1;
        private GD2C2015DataSet3TableAdapters.AeronaveTableAdapter aeronaveTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox origenCombo;
        private DataSetCiudad dataSetCiudad;
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        private DataSetCiudadTableAdapters.CiudadTableAdapter ciudadTableAdapter;
        private System.Windows.Forms.ComboBox destinoCombo;
        private DataSetCiudad2 dataSetCiudad2;
        private System.Windows.Forms.BindingSource ciudadBindingSource1;
        private DataSetCiudad2TableAdapters.CiudadTableAdapter ciudadTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechaPicker;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.TextBox matriculaTextbox;
    }
}