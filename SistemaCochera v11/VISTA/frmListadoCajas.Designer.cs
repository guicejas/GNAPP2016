namespace VISTA
{
    partial class frmListadoCajas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoCajas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.checkFechaCierre = new System.Windows.Forms.CheckBox();
            this.checkFechaApertura = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.gboxFechaCierre = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpCierreHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpCierreDesde = new System.Windows.Forms.DateTimePicker();
            this.gboxFechaApertura = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAperturaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpAperturaDesde = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNroCaja = new System.Windows.Forms.TextBox();
            this.dgridListados = new System.Windows.Forms.DataGridView();
            this.CantidadVehiculos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSinResultados = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.nroCajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraAperturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraCierreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsListadoCajas = new System.Windows.Forms.BindingSource(this.components);
            this.gboxFechaCierre.SuspendLayout();
            this.gboxFechaApertura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridListados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsListadoCajas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(728, 599);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(152, 43);
            this.btnCerrar.TabIndex = 33;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(709, 49);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(152, 43);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(709, 98);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(152, 43);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // checkFechaCierre
            // 
            this.checkFechaCierre.AutoSize = true;
            this.checkFechaCierre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFechaCierre.Location = new System.Drawing.Point(409, 50);
            this.checkFechaCierre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkFechaCierre.Name = "checkFechaCierre";
            this.checkFechaCierre.Size = new System.Drawing.Size(107, 22);
            this.checkFechaCierre.TabIndex = 28;
            this.checkFechaCierre.Text = "Fecha Cierre";
            this.checkFechaCierre.UseVisualStyleBackColor = true;
            this.checkFechaCierre.CheckedChanged += new System.EventHandler(this.checkFechaCierre_CheckedChanged);
            // 
            // checkFechaApertura
            // 
            this.checkFechaApertura.AutoSize = true;
            this.checkFechaApertura.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFechaApertura.Location = new System.Drawing.Point(144, 50);
            this.checkFechaApertura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkFechaApertura.Name = "checkFechaApertura";
            this.checkFechaApertura.Size = new System.Drawing.Size(124, 22);
            this.checkFechaApertura.TabIndex = 26;
            this.checkFechaApertura.Text = "Fecha Apertura";
            this.checkFechaApertura.UseVisualStyleBackColor = true;
            this.checkFechaApertura.CheckedChanged += new System.EventHandler(this.checkFechaApertura_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Estado";
            // 
            // cboxEstado
            // 
            this.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Todos",
            "Abierta",
            "Cerrada"});
            this.cboxEstado.Location = new System.Drawing.Point(449, 9);
            this.cboxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(121, 24);
            this.cboxEstado.TabIndex = 29;
            // 
            // gboxFechaCierre
            // 
            this.gboxFechaCierre.Controls.Add(this.label3);
            this.gboxFechaCierre.Controls.Add(this.label4);
            this.gboxFechaCierre.Controls.Add(this.dtpCierreHasta);
            this.gboxFechaCierre.Controls.Add(this.dtpCierreDesde);
            this.gboxFechaCierre.Enabled = false;
            this.gboxFechaCierre.Location = new System.Drawing.Point(395, 54);
            this.gboxFechaCierre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxFechaCierre.Name = "gboxFechaCierre";
            this.gboxFechaCierre.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxFechaCierre.Size = new System.Drawing.Size(207, 87);
            this.gboxFechaCierre.TabIndex = 27;
            this.gboxFechaCierre.TabStop = false;
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
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Desde";
            // 
            // dtpCierreHasta
            // 
            this.dtpCierreHasta.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCierreHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpCierreHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCierreHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCierreHasta.Location = new System.Drawing.Point(67, 53);
            this.dtpCierreHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCierreHasta.Name = "dtpCierreHasta";
            this.dtpCierreHasta.Size = new System.Drawing.Size(116, 22);
            this.dtpCierreHasta.TabIndex = 12;
            // 
            // dtpCierreDesde
            // 
            this.dtpCierreDesde.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCierreDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpCierreDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCierreDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCierreDesde.Location = new System.Drawing.Point(67, 25);
            this.dtpCierreDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCierreDesde.Name = "dtpCierreDesde";
            this.dtpCierreDesde.Size = new System.Drawing.Size(116, 22);
            this.dtpCierreDesde.TabIndex = 11;
            // 
            // gboxFechaApertura
            // 
            this.gboxFechaApertura.Controls.Add(this.label2);
            this.gboxFechaApertura.Controls.Add(this.label1);
            this.gboxFechaApertura.Controls.Add(this.dtpAperturaHasta);
            this.gboxFechaApertura.Controls.Add(this.dtpAperturaDesde);
            this.gboxFechaApertura.Enabled = false;
            this.gboxFechaApertura.Location = new System.Drawing.Point(139, 54);
            this.gboxFechaApertura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxFechaApertura.Name = "gboxFechaApertura";
            this.gboxFechaApertura.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxFechaApertura.Size = new System.Drawing.Size(207, 87);
            this.gboxFechaApertura.TabIndex = 25;
            this.gboxFechaApertura.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 55);
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
            // dtpAperturaHasta
            // 
            this.dtpAperturaHasta.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAperturaHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpAperturaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAperturaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAperturaHasta.Location = new System.Drawing.Point(67, 53);
            this.dtpAperturaHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpAperturaHasta.Name = "dtpAperturaHasta";
            this.dtpAperturaHasta.Size = new System.Drawing.Size(116, 22);
            this.dtpAperturaHasta.TabIndex = 12;
            // 
            // dtpAperturaDesde
            // 
            this.dtpAperturaDesde.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAperturaDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpAperturaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAperturaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAperturaDesde.Location = new System.Drawing.Point(67, 25);
            this.dtpAperturaDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpAperturaDesde.Name = "dtpAperturaDesde";
            this.dtpAperturaDesde.Size = new System.Drawing.Size(116, 22);
            this.dtpAperturaDesde.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(155, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 18);
            this.label21.TabIndex = 24;
            this.label21.Text = "Nro Caja";
            // 
            // txtNroCaja
            // 
            this.txtNroCaja.Location = new System.Drawing.Point(224, 10);
            this.txtNroCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNroCaja.MaxLength = 15;
            this.txtNroCaja.Name = "txtNroCaja";
            this.txtNroCaja.Size = new System.Drawing.Size(121, 22);
            this.txtNroCaja.TabIndex = 23;
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
            this.nroCajaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.fechaHoraAperturaDataGridViewTextBoxColumn,
            this.fechaHoraCierreDataGridViewTextBoxColumn,
            this.CantidadVehiculos});
            this.dgridListados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgridListados.DataSource = this.bdsListadoCajas;
            this.dgridListados.Location = new System.Drawing.Point(12, 164);
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
            this.dgridListados.Size = new System.Drawing.Size(884, 430);
            this.dgridListados.TabIndex = 20;
            // 
            // CantidadVehiculos
            // 
            this.CantidadVehiculos.DataPropertyName = "CantidadVehiculos";
            this.CantidadVehiculos.HeaderText = "Cant Veh.";
            this.CantidadVehiculos.Name = "CantidadVehiculos";
            this.CantidadVehiculos.ReadOnly = true;
            this.CantidadVehiculos.Width = 110;
            // 
            // lblSinResultados
            // 
            this.lblSinResultados.AutoSize = true;
            this.lblSinResultados.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSinResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinResultados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSinResultados.Location = new System.Drawing.Point(220, 233);
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(489, 17);
            this.lblSinResultados.TabIndex = 34;
            this.lblSinResultados.Text = "No se encontraron resultados con los parámetros de busqueda introducidos";
            this.lblSinResultados.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 614);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Cantidad de resultados encontrados:";
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(268, 615);
            this.lblResultados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(13, 17);
            this.lblResultados.TabIndex = 54;
            this.lblResultados.Text = "-";
            // 
            // nroCajaDataGridViewTextBoxColumn
            // 
            this.nroCajaDataGridViewTextBoxColumn.DataPropertyName = "NroCaja";
            this.nroCajaDataGridViewTextBoxColumn.HeaderText = "Nro Caja";
            this.nroCajaDataGridViewTextBoxColumn.Name = "nroCajaDataGridViewTextBoxColumn";
            this.nroCajaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Recaudado";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHoraAperturaDataGridViewTextBoxColumn
            // 
            this.fechaHoraAperturaDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraApertura";
            this.fechaHoraAperturaDataGridViewTextBoxColumn.HeaderText = "Apertura";
            this.fechaHoraAperturaDataGridViewTextBoxColumn.Name = "fechaHoraAperturaDataGridViewTextBoxColumn";
            this.fechaHoraAperturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaHoraAperturaDataGridViewTextBoxColumn.Width = 170;
            // 
            // fechaHoraCierreDataGridViewTextBoxColumn
            // 
            this.fechaHoraCierreDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraCierre";
            this.fechaHoraCierreDataGridViewTextBoxColumn.HeaderText = "Cierre";
            this.fechaHoraCierreDataGridViewTextBoxColumn.Name = "fechaHoraCierreDataGridViewTextBoxColumn";
            this.fechaHoraCierreDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaHoraCierreDataGridViewTextBoxColumn.Width = 170;
            // 
            // bdsListadoCajas
            // 
            this.bdsListadoCajas.DataSource = typeof(MODELO.Caja);
            // 
            // frmListadoCajas
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(911, 642);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSinResultados);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.checkFechaCierre);
            this.Controls.Add(this.checkFechaApertura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxEstado);
            this.Controls.Add(this.gboxFechaCierre);
            this.Controls.Add(this.gboxFechaApertura);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtNroCaja);
            this.Controls.Add(this.dgridListados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(917, 675);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(917, 675);
            this.Name = "frmListadoCajas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LISTADO CAJAS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmListadoCajas_Load);
            this.gboxFechaCierre.ResumeLayout(false);
            this.gboxFechaCierre.PerformLayout();
            this.gboxFechaApertura.ResumeLayout(false);
            this.gboxFechaApertura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridListados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsListadoCajas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox checkFechaCierre;
        private System.Windows.Forms.CheckBox checkFechaApertura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.GroupBox gboxFechaCierre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpCierreHasta;
        private System.Windows.Forms.DateTimePicker dtpCierreDesde;
        private System.Windows.Forms.GroupBox gboxFechaApertura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAperturaHasta;
        private System.Windows.Forms.DateTimePicker dtpAperturaDesde;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtNroCaja;
        private System.Windows.Forms.DataGridView dgridListados;
        private System.Windows.Forms.BindingSource bdsListadoCajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraAperturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraCierreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVehiculos;
        private System.Windows.Forms.Label lblSinResultados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResultados;
    }
}