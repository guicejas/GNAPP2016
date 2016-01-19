namespace VISTA
{
    partial class frmListadoVehiculos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoVehiculos));
            this.dtpEntradaDesde = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNroTicket = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dgridListados = new System.Windows.Forms.DataGridView();
            this.DuplicadoPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.dtpEntradaHasta = new System.Windows.Forms.DateTimePicker();
            this.gboxFechaEntrada = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkFechaEntrada = new System.Windows.Forms.CheckBox();
            this.gboxFechaSalida = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpSalidaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaDesde = new System.Windows.Forms.DateTimePicker();
            this.checkFechaSalida = new System.Windows.Forms.CheckBox();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblSinResultados = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNroCaja = new System.Windows.Forms.TextBox();
            this.lblResultados = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nroTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muestraClaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muestraCajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsListadoVehiculos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgridListados)).BeginInit();
            this.gboxFechaEntrada.SuspendLayout();
            this.gboxFechaSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsListadoVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpEntradaDesde
            // 
            this.dtpEntradaDesde.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntradaDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpEntradaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntradaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntradaDesde.Location = new System.Drawing.Point(67, 25);
            this.dtpEntradaDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEntradaDesde.Name = "dtpEntradaDesde";
            this.dtpEntradaDesde.Size = new System.Drawing.Size(116, 22);
            this.dtpEntradaDesde.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(284, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 18);
            this.label21.TabIndex = 10;
            this.label21.Text = "Nro Ticket";
            // 
            // txtNroTicket
            // 
            this.txtNroTicket.Location = new System.Drawing.Point(364, 6);
            this.txtNroTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNroTicket.MaxLength = 15;
            this.txtNroTicket.Name = "txtNroTicket";
            this.txtNroTicket.Size = new System.Drawing.Size(121, 22);
            this.txtNroTicket.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(148, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 18);
            this.label20.TabIndex = 8;
            this.label20.Text = "Patente";
            // 
            // dgridListados
            // 
            this.dgridListados.AllowUserToAddRows = false;
            this.dgridListados.AllowUserToDeleteRows = false;
            this.dgridListados.AllowUserToOrderColumns = true;
            this.dgridListados.AutoGenerateColumns = false;
            this.dgridListados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridListados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridListados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroTicketDataGridViewTextBoxColumn,
            this.DuplicadoPatente,
            this.estadoDataGridViewTextBoxColumn,
            this.fechaHoraEntradaDataGridViewTextBoxColumn,
            this.fechaHoraSalidaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.muestraClaseDataGridViewTextBoxColumn,
            this.muestraCajaDataGridViewTextBoxColumn});
            this.dgridListados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgridListados.DataSource = this.bdsListadoVehiculos;
            this.dgridListados.Location = new System.Drawing.Point(12, 212);
            this.dgridListados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgridListados.MultiSelect = false;
            this.dgridListados.Name = "dgridListados";
            this.dgridListados.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridListados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgridListados.RowHeadersVisible = false;
            this.dgridListados.RowTemplate.Height = 24;
            this.dgridListados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridListados.Size = new System.Drawing.Size(977, 430);
            this.dgridListados.TabIndex = 6;
            // 
            // DuplicadoPatente
            // 
            this.DuplicadoPatente.DataPropertyName = "DuplicadoPatente";
            this.DuplicadoPatente.HeaderText = "Patente";
            this.DuplicadoPatente.Name = "DuplicadoPatente";
            this.DuplicadoPatente.ReadOnly = true;
            this.DuplicadoPatente.Width = 70;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(212, 7);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatente.MaxLength = 3;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(53, 22);
            this.txtPatente.TabIndex = 7;
            // 
            // dtpEntradaHasta
            // 
            this.dtpEntradaHasta.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntradaHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpEntradaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntradaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntradaHasta.Location = new System.Drawing.Point(67, 53);
            this.dtpEntradaHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEntradaHasta.Name = "dtpEntradaHasta";
            this.dtpEntradaHasta.Size = new System.Drawing.Size(116, 22);
            this.dtpEntradaHasta.TabIndex = 12;
            // 
            // gboxFechaEntrada
            // 
            this.gboxFechaEntrada.Controls.Add(this.label2);
            this.gboxFechaEntrada.Controls.Add(this.label1);
            this.gboxFechaEntrada.Controls.Add(this.dtpEntradaHasta);
            this.gboxFechaEntrada.Controls.Add(this.dtpEntradaDesde);
            this.gboxFechaEntrada.Enabled = false;
            this.gboxFechaEntrada.Location = new System.Drawing.Point(104, 96);
            this.gboxFechaEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxFechaEntrada.Name = "gboxFechaEntrada";
            this.gboxFechaEntrada.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxFechaEntrada.Size = new System.Drawing.Size(207, 87);
            this.gboxFechaEntrada.TabIndex = 13;
            this.gboxFechaEntrada.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Desde";
            // 
            // checkFechaEntrada
            // 
            this.checkFechaEntrada.AutoSize = true;
            this.checkFechaEntrada.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFechaEntrada.Location = new System.Drawing.Point(107, 92);
            this.checkFechaEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkFechaEntrada.Name = "checkFechaEntrada";
            this.checkFechaEntrada.Size = new System.Drawing.Size(116, 22);
            this.checkFechaEntrada.TabIndex = 14;
            this.checkFechaEntrada.Text = "Fecha Entrada";
            this.checkFechaEntrada.UseVisualStyleBackColor = true;
            this.checkFechaEntrada.CheckedChanged += new System.EventHandler(this.checkFechaEntrada_CheckedChanged);
            // 
            // gboxFechaSalida
            // 
            this.gboxFechaSalida.Controls.Add(this.label3);
            this.gboxFechaSalida.Controls.Add(this.label4);
            this.gboxFechaSalida.Controls.Add(this.dtpSalidaHasta);
            this.gboxFechaSalida.Controls.Add(this.dtpSalidaDesde);
            this.gboxFechaSalida.Enabled = false;
            this.gboxFechaSalida.Location = new System.Drawing.Point(360, 96);
            this.gboxFechaSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxFechaSalida.Name = "gboxFechaSalida";
            this.gboxFechaSalida.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxFechaSalida.Size = new System.Drawing.Size(207, 87);
            this.gboxFechaSalida.TabIndex = 14;
            this.gboxFechaSalida.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Desde";
            // 
            // dtpSalidaHasta
            // 
            this.dtpSalidaHasta.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalidaHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpSalidaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalidaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalidaHasta.Location = new System.Drawing.Point(67, 53);
            this.dtpSalidaHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSalidaHasta.Name = "dtpSalidaHasta";
            this.dtpSalidaHasta.Size = new System.Drawing.Size(116, 22);
            this.dtpSalidaHasta.TabIndex = 12;
            // 
            // dtpSalidaDesde
            // 
            this.dtpSalidaDesde.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalidaDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpSalidaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalidaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalidaDesde.Location = new System.Drawing.Point(67, 25);
            this.dtpSalidaDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSalidaDesde.Name = "dtpSalidaDesde";
            this.dtpSalidaDesde.Size = new System.Drawing.Size(116, 22);
            this.dtpSalidaDesde.TabIndex = 11;
            // 
            // checkFechaSalida
            // 
            this.checkFechaSalida.AutoSize = true;
            this.checkFechaSalida.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFechaSalida.Location = new System.Drawing.Point(364, 92);
            this.checkFechaSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkFechaSalida.Name = "checkFechaSalida";
            this.checkFechaSalida.Size = new System.Drawing.Size(106, 22);
            this.checkFechaSalida.TabIndex = 14;
            this.checkFechaSalida.Text = "Fecha Salida";
            this.checkFechaSalida.UseVisualStyleBackColor = true;
            this.checkFechaSalida.CheckedChanged += new System.EventHandler(this.checkFechaSalida_CheckedChanged);
            // 
            // cboxEstado
            // 
            this.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Todos",
            "Activo",
            "Inactivo"});
            this.cboxEstado.Location = new System.Drawing.Point(568, 4);
            this.cboxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(121, 24);
            this.cboxEstado.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(804, 112);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(152, 43);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(804, 64);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(152, 43);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(819, 650);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(152, 43);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblSinResultados
            // 
            this.lblSinResultados.AutoSize = true;
            this.lblSinResultados.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSinResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinResultados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSinResultados.Location = new System.Drawing.Point(248, 278);
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(489, 17);
            this.lblSinResultados.TabIndex = 24;
            this.lblSinResultados.Text = "No se encontraron resultados con los parámetros de busqueda introducidos";
            this.lblSinResultados.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Clase";
            // 
            // txtClase
            // 
            this.txtClase.Location = new System.Drawing.Point(212, 43);
            this.txtClase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClase.MaxLength = 3;
            this.txtClase.Name = "txtClase";
            this.txtClase.Size = new System.Drawing.Size(53, 22);
            this.txtClase.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Nro Caja";
            // 
            // txtNroCaja
            // 
            this.txtNroCaja.Location = new System.Drawing.Point(364, 43);
            this.txtNroCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNroCaja.MaxLength = 15;
            this.txtNroCaja.Name = "txtNroCaja";
            this.txtNroCaja.Size = new System.Drawing.Size(121, 22);
            this.txtNroCaja.TabIndex = 27;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(268, 666);
            this.lblResultados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(13, 17);
            this.lblResultados.TabIndex = 56;
            this.lblResultados.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 665);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 18);
            this.label8.TabIndex = 55;
            this.label8.Text = "Cantidad de resultados encontrados:";
            // 
            // nroTicketDataGridViewTextBoxColumn
            // 
            this.nroTicketDataGridViewTextBoxColumn.DataPropertyName = "NroTicket";
            this.nroTicketDataGridViewTextBoxColumn.HeaderText = "NroT";
            this.nroTicketDataGridViewTextBoxColumn.Name = "nroTicketDataGridViewTextBoxColumn";
            this.nroTicketDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroTicketDataGridViewTextBoxColumn.Width = 60;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 80;
            // 
            // fechaHoraEntradaDataGridViewTextBoxColumn
            // 
            this.fechaHoraEntradaDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraEntrada";
            this.fechaHoraEntradaDataGridViewTextBoxColumn.HeaderText = "Entrada";
            this.fechaHoraEntradaDataGridViewTextBoxColumn.Name = "fechaHoraEntradaDataGridViewTextBoxColumn";
            this.fechaHoraEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaHoraEntradaDataGridViewTextBoxColumn.Width = 160;
            // 
            // fechaHoraSalidaDataGridViewTextBoxColumn
            // 
            this.fechaHoraSalidaDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraSalida";
            this.fechaHoraSalidaDataGridViewTextBoxColumn.HeaderText = "Salida";
            this.fechaHoraSalidaDataGridViewTextBoxColumn.Name = "fechaHoraSalidaDataGridViewTextBoxColumn";
            this.fechaHoraSalidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaHoraSalidaDataGridViewTextBoxColumn.Width = 160;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 70;
            // 
            // muestraClaseDataGridViewTextBoxColumn
            // 
            this.muestraClaseDataGridViewTextBoxColumn.DataPropertyName = "MuestraClase";
            this.muestraClaseDataGridViewTextBoxColumn.HeaderText = "Clase";
            this.muestraClaseDataGridViewTextBoxColumn.Name = "muestraClaseDataGridViewTextBoxColumn";
            this.muestraClaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.muestraClaseDataGridViewTextBoxColumn.Width = 50;
            // 
            // muestraCajaDataGridViewTextBoxColumn
            // 
            this.muestraCajaDataGridViewTextBoxColumn.DataPropertyName = "MuestraCaja";
            this.muestraCajaDataGridViewTextBoxColumn.HeaderText = "Caja";
            this.muestraCajaDataGridViewTextBoxColumn.Name = "muestraCajaDataGridViewTextBoxColumn";
            this.muestraCajaDataGridViewTextBoxColumn.ReadOnly = true;
            this.muestraCajaDataGridViewTextBoxColumn.Width = 70;
            // 
            // bdsListadoVehiculos
            // 
            this.bdsListadoVehiculos.DataSource = typeof(MODELO.Vehiculo);
            // 
            // frmListadoVehiculos
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(1004, 699);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNroCaja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClase);
            this.Controls.Add(this.lblSinResultados);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.checkFechaSalida);
            this.Controls.Add(this.checkFechaEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxEstado);
            this.Controls.Add(this.gboxFechaSalida);
            this.Controls.Add(this.gboxFechaEntrada);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtNroTicket);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dgridListados);
            this.Controls.Add(this.txtPatente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1010, 732);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1010, 732);
            this.Name = "frmListadoVehiculos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LISTADO VEHICULOS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmListadoVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridListados)).EndInit();
            this.gboxFechaEntrada.ResumeLayout(false);
            this.gboxFechaEntrada.PerformLayout();
            this.gboxFechaSalida.ResumeLayout(false);
            this.gboxFechaSalida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsListadoVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEntradaDesde;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtNroTicket;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgridListados;
        private System.Windows.Forms.BindingSource bdsListadoVehiculos;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.DateTimePicker dtpEntradaHasta;
        private System.Windows.Forms.GroupBox gboxFechaEntrada;
        private System.Windows.Forms.CheckBox checkFechaEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxFechaSalida;
        private System.Windows.Forms.CheckBox checkFechaSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpSalidaHasta;
        private System.Windows.Forms.DateTimePicker dtpSalidaDesde;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuplicadoPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muestraClaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muestraCajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblSinResultados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNroCaja;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label label8;
    }
}