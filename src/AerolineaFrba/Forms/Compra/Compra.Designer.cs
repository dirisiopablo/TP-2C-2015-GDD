namespace AerolineaFrba.Forms.Compra {
    partial class Compra {
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
            this.salidaPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.origenCombo = new System.Windows.Forms.ComboBox();
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCiudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCiudad = new AerolineaFrba.DataSetCiudad();
            this.destinoCombo = new System.Windows.Forms.ComboBox();
            this.ciudadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCiudad2 = new AerolineaFrba.DataSetCiudad2();
            this.ciudadTableAdapter = new AerolineaFrba.DataSetCiudadTableAdapters.CiudadTableAdapter();
            this.ciudadTableAdapter1 = new AerolineaFrba.DataSetCiudad2TableAdapters.CiudadTableAdapter();
            this.buscarButton = new System.Windows.Forms.Button();
            this.viajeDataSet = new AerolineaFrba.ViajeDataSet();
            this.viajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viajeTableAdapter = new AerolineaFrba.ViajeDataSetTableAdapters.ViajeTableAdapter();
            this.viajesDataGrid = new System.Windows.Forms.DataGridView();
            this.pasajerosDataGrid = new System.Windows.Forms.DataGridView();
            this.agregarPasajeroButton = new System.Windows.Forms.Button();
            this.fechaNacimientoPicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fechaNacimientoLabel = new System.Windows.Forms.Label();
            this.direccionTextbox = new System.Windows.Forms.TextBox();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.apellidoTextbox = new System.Windows.Forms.TextBox();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.nombreTextbox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.documentoTextbox = new System.Windows.Forms.TextBox();
            this.documentoLabel = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.paquetesDataGrid = new System.Windows.Forms.DataGridView();
            this.agregarPaqueteButton = new System.Windows.Forms.Button();
            this.emailTextboxPaquete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fechaNacimientoPickerPaquete = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.direccionTextboxPaquete = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.apellidoTextboxPaquete = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nombreTextboxPaquete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.documentoTextboxPaquete = new System.Windows.Forms.TextBox();
            this.documentoLabelPaquete = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butacaCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pesoBox = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.confirmarCompraButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viajeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viajesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paquetesDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // salidaPicker
            // 
            this.salidaPicker.Location = new System.Drawing.Point(102, 22);
            this.salidaPicker.Name = "salidaPicker";
            this.salidaPicker.Size = new System.Drawing.Size(200, 20);
            this.salidaPicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de salida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Destino:";
            // 
            // origenCombo
            // 
            this.origenCombo.DataSource = this.ciudadBindingSource;
            this.origenCombo.DisplayMember = "descripcion";
            this.origenCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origenCombo.FormattingEnabled = true;
            this.origenCombo.Location = new System.Drawing.Point(380, 22);
            this.origenCombo.Name = "origenCombo";
            this.origenCombo.Size = new System.Drawing.Size(135, 21);
            this.origenCombo.TabIndex = 4;
            this.origenCombo.ValueMember = "id";
            // 
            // ciudadBindingSource
            // 
            this.ciudadBindingSource.DataMember = "Ciudad";
            this.ciudadBindingSource.DataSource = this.dataSetCiudadBindingSource;
            // 
            // dataSetCiudadBindingSource
            // 
            this.dataSetCiudadBindingSource.DataSource = this.dataSetCiudad;
            this.dataSetCiudadBindingSource.Position = 0;
            // 
            // dataSetCiudad
            // 
            this.dataSetCiudad.DataSetName = "DataSetCiudad";
            this.dataSetCiudad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // destinoCombo
            // 
            this.destinoCombo.DataSource = this.ciudadBindingSource1;
            this.destinoCombo.DisplayMember = "descripcion";
            this.destinoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinoCombo.FormattingEnabled = true;
            this.destinoCombo.Location = new System.Drawing.Point(600, 22);
            this.destinoCombo.Name = "destinoCombo";
            this.destinoCombo.Size = new System.Drawing.Size(137, 21);
            this.destinoCombo.TabIndex = 5;
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
            // ciudadTableAdapter
            // 
            this.ciudadTableAdapter.ClearBeforeFill = true;
            // 
            // ciudadTableAdapter1
            // 
            this.ciudadTableAdapter1.ClearBeforeFill = true;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(776, 12);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(126, 38);
            this.buscarButton.TabIndex = 6;
            this.buscarButton.Text = "Buscar Viajes";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // viajeDataSet
            // 
            this.viajeDataSet.DataSetName = "ViajeDataSet";
            this.viajeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viajeBindingSource
            // 
            this.viajeBindingSource.DataMember = "Viaje";
            this.viajeBindingSource.DataSource = this.viajeDataSet;
            // 
            // viajeTableAdapter
            // 
            this.viajeTableAdapter.ClearBeforeFill = true;
            // 
            // viajesDataGrid
            // 
            this.viajesDataGrid.AllowUserToAddRows = false;
            this.viajesDataGrid.AllowUserToDeleteRows = false;
            this.viajesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viajesDataGrid.Location = new System.Drawing.Point(14, 65);
            this.viajesDataGrid.MultiSelect = false;
            this.viajesDataGrid.Name = "viajesDataGrid";
            this.viajesDataGrid.ReadOnly = true;
            this.viajesDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.viajesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viajesDataGrid.Size = new System.Drawing.Size(888, 136);
            this.viajesDataGrid.TabIndex = 7;
            this.viajesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viajesDataGrid_CellContentClick);
            // 
            // pasajerosDataGrid
            // 
            this.pasajerosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pasajerosDataGrid.Location = new System.Drawing.Point(14, 140);
            this.pasajerosDataGrid.Name = "pasajerosDataGrid";
            this.pasajerosDataGrid.Size = new System.Drawing.Size(888, 114);
            this.pasajerosDataGrid.TabIndex = 13;
            // 
            // agregarPasajeroButton
            // 
            this.agregarPasajeroButton.Location = new System.Drawing.Point(797, 45);
            this.agregarPasajeroButton.Name = "agregarPasajeroButton";
            this.agregarPasajeroButton.Size = new System.Drawing.Size(105, 43);
            this.agregarPasajeroButton.TabIndex = 12;
            this.agregarPasajeroButton.Text = "Agregar Pasajero";
            this.agregarPasajeroButton.UseVisualStyleBackColor = true;
            this.agregarPasajeroButton.Click += new System.EventHandler(this.agregarPasajeroButton_Click);
            // 
            // fechaNacimientoPicker
            // 
            this.fechaNacimientoPicker.Location = new System.Drawing.Point(492, 72);
            this.fechaNacimientoPicker.Name = "fechaNacimientoPicker";
            this.fechaNacimientoPicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoPicker.TabIndex = 11;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(87, 107);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(272, 20);
            this.emailTextbox.TabIndex = 9;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(47, 110);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email:";
            // 
            // fechaNacimientoLabel
            // 
            this.fechaNacimientoLabel.AutoSize = true;
            this.fechaNacimientoLabel.Location = new System.Drawing.Point(377, 75);
            this.fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            this.fechaNacimientoLabel.Size = new System.Drawing.Size(109, 13);
            this.fechaNacimientoLabel.TabIndex = 10;
            this.fechaNacimientoLabel.Text = "Fecha de nacimiento:";
            // 
            // direccionTextbox
            // 
            this.direccionTextbox.Location = new System.Drawing.Point(87, 72);
            this.direccionTextbox.Name = "direccionTextbox";
            this.direccionTextbox.Size = new System.Drawing.Size(272, 20);
            this.direccionTextbox.TabIndex = 7;
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(27, 78);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(55, 13);
            this.direccionLabel.TabIndex = 6;
            this.direccionLabel.Text = "Direccion:";
            // 
            // apellidoTextbox
            // 
            this.apellidoTextbox.Location = new System.Drawing.Point(529, 37);
            this.apellidoTextbox.Name = "apellidoTextbox";
            this.apellidoTextbox.Size = new System.Drawing.Size(163, 20);
            this.apellidoTextbox.TabIndex = 5;
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Location = new System.Drawing.Point(465, 40);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(50, 13);
            this.apellidoLabel.TabIndex = 4;
            this.apellidoLabel.Text = "Apellido: ";
            // 
            // nombreTextbox
            // 
            this.nombreTextbox.Location = new System.Drawing.Point(296, 37);
            this.nombreTextbox.Name = "nombreTextbox";
            this.nombreTextbox.Size = new System.Drawing.Size(142, 20);
            this.nombreTextbox.TabIndex = 3;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(240, 40);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(50, 13);
            this.nombreLabel.TabIndex = 2;
            this.nombreLabel.Text = "Nombre: ";
            // 
            // documentoTextbox
            // 
            this.documentoTextbox.Location = new System.Drawing.Point(87, 37);
            this.documentoTextbox.Name = "documentoTextbox";
            this.documentoTextbox.Size = new System.Drawing.Size(120, 20);
            this.documentoTextbox.TabIndex = 1;
            this.documentoTextbox.TextChanged += new System.EventHandler(this.documentoTextbox_TextChanged);
            // 
            // documentoLabel
            // 
            this.documentoLabel.AutoSize = true;
            this.documentoLabel.Location = new System.Drawing.Point(17, 40);
            this.documentoLabel.Name = "documentoLabel";
            this.documentoLabel.Size = new System.Drawing.Size(65, 13);
            this.documentoLabel.TabIndex = 0;
            this.documentoLabel.Text = "Documento:";
            // 
            // splitContainer
            // 
            this.splitContainer.Location = new System.Drawing.Point(25, 12);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.buscarButton);
            this.splitContainer.Panel1.Controls.Add(this.salidaPicker);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.label3);
            this.splitContainer.Panel1.Controls.Add(this.origenCombo);
            this.splitContainer.Panel1.Controls.Add(this.destinoCombo);
            this.splitContainer.Panel1.Controls.Add(this.viajesDataGrid);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.paquetesDataGrid);
            this.splitContainer.Panel2.Controls.Add(this.agregarPaqueteButton);
            this.splitContainer.Panel2.Controls.Add(this.emailTextboxPaquete);
            this.splitContainer.Panel2.Controls.Add(this.label10);
            this.splitContainer.Panel2.Controls.Add(this.fechaNacimientoPickerPaquete);
            this.splitContainer.Panel2.Controls.Add(this.label9);
            this.splitContainer.Panel2.Controls.Add(this.direccionTextboxPaquete);
            this.splitContainer.Panel2.Controls.Add(this.label8);
            this.splitContainer.Panel2.Controls.Add(this.apellidoTextboxPaquete);
            this.splitContainer.Panel2.Controls.Add(this.label7);
            this.splitContainer.Panel2.Controls.Add(this.nombreTextboxPaquete);
            this.splitContainer.Panel2.Controls.Add(this.label6);
            this.splitContainer.Panel2.Controls.Add(this.documentoTextboxPaquete);
            this.splitContainer.Panel2.Controls.Add(this.documentoLabelPaquete);
            this.splitContainer.Panel2.Controls.Add(this.label5);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.agregarPasajeroButton);
            this.splitContainer.Panel2.Controls.Add(this.fechaNacimientoPicker);
            this.splitContainer.Panel2.Controls.Add(this.pasajerosDataGrid);
            this.splitContainer.Panel2.Controls.Add(this.emailTextbox);
            this.splitContainer.Panel2.Controls.Add(this.documentoLabel);
            this.splitContainer.Panel2.Controls.Add(this.emailLabel);
            this.splitContainer.Panel2.Controls.Add(this.documentoTextbox);
            this.splitContainer.Panel2.Controls.Add(this.fechaNacimientoLabel);
            this.splitContainer.Panel2.Controls.Add(this.nombreLabel);
            this.splitContainer.Panel2.Controls.Add(this.direccionTextbox);
            this.splitContainer.Panel2.Controls.Add(this.nombreTextbox);
            this.splitContainer.Panel2.Controls.Add(this.direccionLabel);
            this.splitContainer.Panel2.Controls.Add(this.apellidoLabel);
            this.splitContainer.Panel2.Controls.Add(this.apellidoTextbox);
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Panel2.Controls.Add(this.panel2);
            this.splitContainer.Size = new System.Drawing.Size(927, 774);
            this.splitContainer.SplitterDistance = 228;
            this.splitContainer.TabIndex = 14;
            // 
            // paquetesDataGrid
            // 
            this.paquetesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paquetesDataGrid.Location = new System.Drawing.Point(14, 415);
            this.paquetesDataGrid.Name = "paquetesDataGrid";
            this.paquetesDataGrid.Size = new System.Drawing.Size(888, 113);
            this.paquetesDataGrid.TabIndex = 29;
            // 
            // agregarPaqueteButton
            // 
            this.agregarPaqueteButton.Location = new System.Drawing.Point(797, 317);
            this.agregarPaqueteButton.Name = "agregarPaqueteButton";
            this.agregarPaqueteButton.Size = new System.Drawing.Size(105, 43);
            this.agregarPaqueteButton.TabIndex = 28;
            this.agregarPaqueteButton.Text = "Agregar Paquete";
            this.agregarPaqueteButton.UseVisualStyleBackColor = true;
            this.agregarPaqueteButton.Click += new System.EventHandler(this.agregarPaqueteButton_Click);
            // 
            // emailTextboxPaquete
            // 
            this.emailTextboxPaquete.Location = new System.Drawing.Point(88, 377);
            this.emailTextboxPaquete.Name = "emailTextboxPaquete";
            this.emailTextboxPaquete.Size = new System.Drawing.Size(271, 20);
            this.emailTextboxPaquete.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Email:";
            // 
            // fechaNacimientoPickerPaquete
            // 
            this.fechaNacimientoPickerPaquete.Location = new System.Drawing.Point(492, 344);
            this.fechaNacimientoPickerPaquete.Name = "fechaNacimientoPickerPaquete";
            this.fechaNacimientoPickerPaquete.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoPickerPaquete.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fecha de nacimiento:";
            // 
            // direccionTextboxPaquete
            // 
            this.direccionTextboxPaquete.Location = new System.Drawing.Point(87, 344);
            this.direccionTextboxPaquete.Name = "direccionTextboxPaquete";
            this.direccionTextboxPaquete.Size = new System.Drawing.Size(272, 20);
            this.direccionTextboxPaquete.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Direccion:";
            // 
            // apellidoTextboxPaquete
            // 
            this.apellidoTextboxPaquete.Location = new System.Drawing.Point(529, 308);
            this.apellidoTextboxPaquete.Name = "apellidoTextboxPaquete";
            this.apellidoTextboxPaquete.Size = new System.Drawing.Size(163, 20);
            this.apellidoTextboxPaquete.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Apellido:";
            // 
            // nombreTextboxPaquete
            // 
            this.nombreTextboxPaquete.Location = new System.Drawing.Point(296, 308);
            this.nombreTextboxPaquete.Name = "nombreTextboxPaquete";
            this.nombreTextboxPaquete.Size = new System.Drawing.Size(142, 20);
            this.nombreTextboxPaquete.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nombre:";
            // 
            // documentoTextboxPaquete
            // 
            this.documentoTextboxPaquete.Location = new System.Drawing.Point(87, 308);
            this.documentoTextboxPaquete.Name = "documentoTextboxPaquete";
            this.documentoTextboxPaquete.Size = new System.Drawing.Size(120, 20);
            this.documentoTextboxPaquete.TabIndex = 17;
            this.documentoTextboxPaquete.TextChanged += new System.EventHandler(this.documentoTextboxPaquete_TextChanged);
            // 
            // documentoLabelPaquete
            // 
            this.documentoLabelPaquete.AutoSize = true;
            this.documentoLabelPaquete.Location = new System.Drawing.Point(20, 311);
            this.documentoLabelPaquete.Name = "documentoLabelPaquete";
            this.documentoLabelPaquete.Size = new System.Drawing.Size(65, 13);
            this.documentoLabelPaquete.TabIndex = 16;
            this.documentoLabelPaquete.Text = "Documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Paquetes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pasajeros";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.butacaCombo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 261);
            this.panel1.TabIndex = 30;
            // 
            // butacaCombo
            // 
            this.butacaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.butacaCombo.FormattingEnabled = true;
            this.butacaCombo.Location = new System.Drawing.Point(487, 97);
            this.butacaCombo.Name = "butacaCombo";
            this.butacaCombo.Size = new System.Drawing.Size(200, 21);
            this.butacaCombo.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(437, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Butaca:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pesoBox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(4, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 260);
            this.panel2.TabIndex = 31;
            // 
            // pesoBox
            // 
            this.pesoBox.Location = new System.Drawing.Point(487, 96);
            this.pesoBox.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.pesoBox.Name = "pesoBox";
            this.pesoBox.Size = new System.Drawing.Size(102, 20);
            this.pesoBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(426, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Peso (KG):";
            // 
            // confirmarCompraButton
            // 
            this.confirmarCompraButton.Location = new System.Drawing.Point(361, 813);
            this.confirmarCompraButton.Name = "confirmarCompraButton";
            this.confirmarCompraButton.Size = new System.Drawing.Size(271, 53);
            this.confirmarCompraButton.TabIndex = 15;
            this.confirmarCompraButton.Text = "Confirmar Compra";
            this.confirmarCompraButton.UseVisualStyleBackColor = true;
            this.confirmarCompraButton.Click += new System.EventHandler(this.confirmarCompraButton_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.confirmarCompraButton);
            this.Controls.Add(this.splitContainer);
            this.Name = "Compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCiudad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viajeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viajesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosDataGrid)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paquetesDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker salidaPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox origenCombo;
        private System.Windows.Forms.BindingSource dataSetCiudadBindingSource;
        private DataSetCiudad dataSetCiudad;
        private System.Windows.Forms.ComboBox destinoCombo;
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        private DataSetCiudadTableAdapters.CiudadTableAdapter ciudadTableAdapter;
        private DataSetCiudad2 dataSetCiudad2;
        private System.Windows.Forms.BindingSource ciudadBindingSource1;
        private DataSetCiudad2TableAdapters.CiudadTableAdapter ciudadTableAdapter1;
        private System.Windows.Forms.Button buscarButton;
        private ViajeDataSet viajeDataSet;
        private System.Windows.Forms.BindingSource viajeBindingSource;
        private ViajeDataSetTableAdapters.ViajeTableAdapter viajeTableAdapter;
        private System.Windows.Forms.DataGridView viajesDataGrid;
        private System.Windows.Forms.Button agregarPasajeroButton;
        private System.Windows.Forms.DateTimePicker fechaNacimientoPicker;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label fechaNacimientoLabel;
        private System.Windows.Forms.TextBox direccionTextbox;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.TextBox apellidoTextbox;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.TextBox nombreTextbox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox documentoTextbox;
        private System.Windows.Forms.Label documentoLabel;
        private System.Windows.Forms.DataGridView pasajerosDataGrid;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DateTimePicker fechaNacimientoPickerPaquete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox direccionTextboxPaquete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox apellidoTextboxPaquete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombreTextboxPaquete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox documentoTextboxPaquete;
        private System.Windows.Forms.Label documentoLabelPaquete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView paquetesDataGrid;
        private System.Windows.Forms.Button agregarPaqueteButton;
        private System.Windows.Forms.TextBox emailTextboxPaquete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox butacaCombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown pesoBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button confirmarCompraButton;
    }
}