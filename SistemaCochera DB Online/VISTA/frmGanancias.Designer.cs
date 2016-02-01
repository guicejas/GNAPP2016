namespace VISTA
{
    partial class frmGanancias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGanancias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSinResultados = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgridListados = new System.Windows.Forms.DataGridView();
            this.CantidadVehiculos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCajas = new System.Windows.Forms.Label();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.lblCajaMaxima = new System.Windows.Forms.Label();
            this.lblCajaMinima = new System.Windows.Forms.Label();
            this.lblCajaPromedio = new System.Windows.Forms.Label();
            this.lblTotalR = new System.Windows.Forms.Label();
            this.lblCajasR = new System.Windows.Forms.Label();
            this.lblVehiculosR = new System.Windows.Forms.Label();
            this.lblCajaMaximaR = new System.Windows.Forms.Label();
            this.lblCajaMinimaR = new System.Windows.Forms.Label();
            this.lblCajaPromedioR = new System.Windows.Forms.Label();
            this.lblVehiculosPromR = new System.Windows.Forms.Label();
            this.lblVehiculosMinR = new System.Windows.Forms.Label();
            this.lblVehiculosMaxR = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraAperturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraCierreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsCajas = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgridListados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCajas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSinResultados
            // 
            this.lblSinResultados.AutoSize = true;
            this.lblSinResultados.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSinResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinResultados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSinResultados.Location = new System.Drawing.Point(187, 282);
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(489, 17);
            this.lblSinResultados.TabIndex = 39;
            this.lblSinResultados.Text = "No se encontraron resultados con los parámetros de busqueda introducidos";
            this.lblSinResultados.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(747, 586);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(152, 43);
            this.btnCerrar.TabIndex = 38;
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
            this.btnLimpiar.Location = new System.Drawing.Point(747, 20);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(152, 43);
            this.btnLimpiar.TabIndex = 37;
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
            this.btnBuscar.Location = new System.Drawing.Point(572, 21);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(152, 43);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.totalDataGridViewTextBoxColumn,
            this.nroCajaDataGridViewTextBoxColumn,
            this.fechaHoraAperturaDataGridViewTextBoxColumn,
            this.fechaHoraCierreDataGridViewTextBoxColumn,
            this.CantidadVehiculos});
            this.dgridListados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgridListados.DataSource = this.bdsCajas;
            this.dgridListados.Location = new System.Drawing.Point(41, 209);
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
            this.dgridListados.Size = new System.Drawing.Size(851, 358);
            this.dgridListados.TabIndex = 35;
            // 
            // CantidadVehiculos
            // 
            this.CantidadVehiculos.DataPropertyName = "CantidadVehiculos";
            this.CantidadVehiculos.HeaderText = "Cant Veh.";
            this.CantidadVehiculos.Name = "CantidadVehiculos";
            this.CantidadVehiculos.ReadOnly = true;
            this.CantidadVehiculos.Width = 110;
            // 
            // cboxMes
            // 
            this.cboxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMes.FormattingEnabled = true;
            this.cboxMes.Items.AddRange(new object[] {
            "TODOS",
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cboxMes.Location = new System.Drawing.Point(171, 38);
            this.cboxMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxMes.Name = "cboxMes";
            this.cboxMes.Size = new System.Drawing.Size(160, 24);
            this.cboxMes.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Año";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(432, 38);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(53, 22);
            this.txtAno.TabIndex = 43;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(37, 101);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(229, 21);
            this.lblTotal.TabIndex = 44;
            this.lblTotal.Text = "Total Recaudado en el período:";
            // 
            // lblCajas
            // 
            this.lblCajas.AutoSize = true;
            this.lblCajas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajas.Location = new System.Drawing.Point(37, 132);
            this.lblCajas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCajas.Name = "lblCajas";
            this.lblCajas.Size = new System.Drawing.Size(139, 21);
            this.lblCajas.TabIndex = 45;
            this.lblCajas.Text = "Cantidad de Cajas:";
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculos.Location = new System.Drawing.Point(37, 162);
            this.lblVehiculos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(170, 21);
            this.lblVehiculos.TabIndex = 46;
            this.lblVehiculos.Text = "Cantidad de Vehículos:";
            // 
            // lblCajaMaxima
            // 
            this.lblCajaMaxima.AutoSize = true;
            this.lblCajaMaxima.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajaMaxima.Location = new System.Drawing.Point(405, 101);
            this.lblCajaMaxima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCajaMaxima.Name = "lblCajaMaxima";
            this.lblCajaMaxima.Size = new System.Drawing.Size(105, 21);
            this.lblCajaMaxima.TabIndex = 47;
            this.lblCajaMaxima.Text = "Caja Máxima:";
            // 
            // lblCajaMinima
            // 
            this.lblCajaMinima.AutoSize = true;
            this.lblCajaMinima.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajaMinima.Location = new System.Drawing.Point(405, 132);
            this.lblCajaMinima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCajaMinima.Name = "lblCajaMinima";
            this.lblCajaMinima.Size = new System.Drawing.Size(102, 21);
            this.lblCajaMinima.TabIndex = 48;
            this.lblCajaMinima.Text = "Caja Mínima:";
            // 
            // lblCajaPromedio
            // 
            this.lblCajaPromedio.AutoSize = true;
            this.lblCajaPromedio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajaPromedio.Location = new System.Drawing.Point(405, 162);
            this.lblCajaPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCajaPromedio.Name = "lblCajaPromedio";
            this.lblCajaPromedio.Size = new System.Drawing.Size(117, 21);
            this.lblCajaPromedio.TabIndex = 49;
            this.lblCajaPromedio.Text = "Caja Promedio:";
            // 
            // lblTotalR
            // 
            this.lblTotalR.AutoSize = true;
            this.lblTotalR.Location = new System.Drawing.Point(279, 103);
            this.lblTotalR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalR.Name = "lblTotalR";
            this.lblTotalR.Size = new System.Drawing.Size(13, 17);
            this.lblTotalR.TabIndex = 50;
            this.lblTotalR.Text = "-";
            // 
            // lblCajasR
            // 
            this.lblCajasR.AutoSize = true;
            this.lblCajasR.Location = new System.Drawing.Point(187, 133);
            this.lblCajasR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCajasR.Name = "lblCajasR";
            this.lblCajasR.Size = new System.Drawing.Size(13, 17);
            this.lblCajasR.TabIndex = 51;
            this.lblCajasR.Text = "-";
            // 
            // lblVehiculosR
            // 
            this.lblVehiculosR.AutoSize = true;
            this.lblVehiculosR.Location = new System.Drawing.Point(219, 165);
            this.lblVehiculosR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculosR.Name = "lblVehiculosR";
            this.lblVehiculosR.Size = new System.Drawing.Size(13, 17);
            this.lblVehiculosR.TabIndex = 52;
            this.lblVehiculosR.Text = "-";
            // 
            // lblCajaMaximaR
            // 
            this.lblCajaMaximaR.AutoSize = true;
            this.lblCajaMaximaR.Location = new System.Drawing.Point(519, 103);
            this.lblCajaMaximaR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCajaMaximaR.Name = "lblCajaMaximaR";
            this.lblCajaMaximaR.Size = new System.Drawing.Size(13, 17);
            this.lblCajaMaximaR.TabIndex = 53;
            this.lblCajaMaximaR.Text = "-";
            // 
            // lblCajaMinimaR
            // 
            this.lblCajaMinimaR.AutoSize = true;
            this.lblCajaMinimaR.Location = new System.Drawing.Point(516, 134);
            this.lblCajaMinimaR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCajaMinimaR.Name = "lblCajaMinimaR";
            this.lblCajaMinimaR.Size = new System.Drawing.Size(13, 17);
            this.lblCajaMinimaR.TabIndex = 54;
            this.lblCajaMinimaR.Text = "-";
            // 
            // lblCajaPromedioR
            // 
            this.lblCajaPromedioR.AutoSize = true;
            this.lblCajaPromedioR.Location = new System.Drawing.Point(533, 164);
            this.lblCajaPromedioR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCajaPromedioR.Name = "lblCajaPromedioR";
            this.lblCajaPromedioR.Size = new System.Drawing.Size(13, 17);
            this.lblCajaPromedioR.TabIndex = 55;
            this.lblCajaPromedioR.Text = "-";
            // 
            // lblVehiculosPromR
            // 
            this.lblVehiculosPromR.AutoSize = true;
            this.lblVehiculosPromR.Location = new System.Drawing.Point(831, 165);
            this.lblVehiculosPromR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculosPromR.Name = "lblVehiculosPromR";
            this.lblVehiculosPromR.Size = new System.Drawing.Size(13, 17);
            this.lblVehiculosPromR.TabIndex = 61;
            this.lblVehiculosPromR.Text = "-";
            // 
            // lblVehiculosMinR
            // 
            this.lblVehiculosMinR.AutoSize = true;
            this.lblVehiculosMinR.Location = new System.Drawing.Point(823, 134);
            this.lblVehiculosMinR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculosMinR.Name = "lblVehiculosMinR";
            this.lblVehiculosMinR.Size = new System.Drawing.Size(13, 17);
            this.lblVehiculosMinR.TabIndex = 60;
            this.lblVehiculosMinR.Text = "-";
            // 
            // lblVehiculosMaxR
            // 
            this.lblVehiculosMaxR.AutoSize = true;
            this.lblVehiculosMaxR.Location = new System.Drawing.Point(825, 103);
            this.lblVehiculosMaxR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculosMaxR.Name = "lblVehiculosMaxR";
            this.lblVehiculosMaxR.Size = new System.Drawing.Size(13, 17);
            this.lblVehiculosMaxR.TabIndex = 59;
            this.lblVehiculosMaxR.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(663, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 21);
            this.label6.TabIndex = 58;
            this.label6.Text = "Cant Veh. Promedio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(663, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 21);
            this.label7.TabIndex = 57;
            this.label7.Text = "Cant Min Vehiculos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(663, 101);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 21);
            this.label8.TabIndex = 56;
            this.label8.Text = "Cant Max Vehiculos:";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nroCajaDataGridViewTextBoxColumn
            // 
            this.nroCajaDataGridViewTextBoxColumn.DataPropertyName = "NroCaja";
            this.nroCajaDataGridViewTextBoxColumn.HeaderText = "NroCaja";
            this.nroCajaDataGridViewTextBoxColumn.Name = "nroCajaDataGridViewTextBoxColumn";
            this.nroCajaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHoraAperturaDataGridViewTextBoxColumn
            // 
            this.fechaHoraAperturaDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraApertura";
            this.fechaHoraAperturaDataGridViewTextBoxColumn.HeaderText = "Apertura";
            this.fechaHoraAperturaDataGridViewTextBoxColumn.Name = "fechaHoraAperturaDataGridViewTextBoxColumn";
            this.fechaHoraAperturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaHoraAperturaDataGridViewTextBoxColumn.Width = 160;
            // 
            // fechaHoraCierreDataGridViewTextBoxColumn
            // 
            this.fechaHoraCierreDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraCierre";
            this.fechaHoraCierreDataGridViewTextBoxColumn.HeaderText = "Cierre";
            this.fechaHoraCierreDataGridViewTextBoxColumn.Name = "fechaHoraCierreDataGridViewTextBoxColumn";
            this.fechaHoraCierreDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaHoraCierreDataGridViewTextBoxColumn.Width = 160;
            // 
            // bdsCajas
            // 
            this.bdsCajas.DataSource = typeof(MODELO.Caja);
            // 
            // frmGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 636);
            this.Controls.Add(this.lblVehiculosPromR);
            this.Controls.Add(this.lblVehiculosMinR);
            this.Controls.Add(this.lblVehiculosMaxR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCajaPromedioR);
            this.Controls.Add(this.lblCajaMinimaR);
            this.Controls.Add(this.lblCajaMaximaR);
            this.Controls.Add(this.lblVehiculosR);
            this.Controls.Add(this.lblCajasR);
            this.Controls.Add(this.lblTotalR);
            this.Controls.Add(this.lblCajaPromedio);
            this.Controls.Add(this.lblCajaMinima);
            this.Controls.Add(this.lblCajaMaxima);
            this.Controls.Add(this.lblVehiculos);
            this.Controls.Add(this.lblCajas);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxMes);
            this.Controls.Add(this.lblSinResultados);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgridListados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(933, 669);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(933, 669);
            this.Name = "frmGanancias";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GANANCIAS POR PERIODO";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmGanancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridListados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCajas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSinResultados;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgridListados;
        private System.Windows.Forms.ComboBox cboxMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.BindingSource bdsCajas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCajas;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.Label lblCajaMaxima;
        private System.Windows.Forms.Label lblCajaMinima;
        private System.Windows.Forms.Label lblCajaPromedio;
        private System.Windows.Forms.Label lblTotalR;
        private System.Windows.Forms.Label lblCajasR;
        private System.Windows.Forms.Label lblVehiculosR;
        private System.Windows.Forms.Label lblCajaMaximaR;
        private System.Windows.Forms.Label lblCajaMinimaR;
        private System.Windows.Forms.Label lblCajaPromedioR;
        private System.Windows.Forms.Label lblVehiculosPromR;
        private System.Windows.Forms.Label lblVehiculosMinR;
        private System.Windows.Forms.Label lblVehiculosMaxR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraAperturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraCierreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVehiculos;
    }
}