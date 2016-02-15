namespace VISTA
{
    partial class frmPagoMensual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagoMensual));
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblPesos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblUltimoMes = new System.Windows.Forms.Label();
            this.lblPrecioSugerido = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTipoMensual = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timerError = new System.Windows.Forms.Timer(this.components);
            this.lblClienteEncontrado = new System.Windows.Forms.Label();
            this.bdsMensuales = new System.Windows.Forms.BindingSource(this.components);
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.timerConfirmacion = new System.Windows.Forms.Timer(this.components);
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMensuales)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtMonto.BackColor = System.Drawing.Color.White;
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtMonto.Location = new System.Drawing.Point(363, 337);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.MaxLength = 7;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.ShortcutsEnabled = false;
            this.txtMonto.Size = new System.Drawing.Size(430, 98);
            this.txtMonto.TabIndex = 65;
            this.txtMonto.TabStop = false;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPagoMensual_KeyDown);
            // 
            // lblPesos
            // 
            this.lblPesos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPesos.AutoSize = true;
            this.lblPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPesos.Location = new System.Drawing.Point(287, 339);
            this.lblPesos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(84, 91);
            this.lblPesos.TabIndex = 66;
            this.lblPesos.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 64;
            this.label2.Text = "CODIGO DE CLIENTE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(526, 13);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(281, 23);
            this.lblError.TabIndex = 62;
            this.lblError.Text = "ERROR CLIENTE NO ENCONTRADO";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(15, 13);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(30, 21);
            this.lblEstado.TabIndex = 61;
            this.lblEstado.Text = "     ";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(533, 482);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(201, 59);
            this.btnAceptar.TabIndex = 60;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPagoMensual_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(304, 482);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(201, 59);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPagoMensual_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 69;
            this.label8.Text = "CLIENTE: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 70;
            this.label1.Text = "VEHICULO: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 71;
            this.label3.Text = "PATENTE: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 72;
            this.label4.Text = "ULTIMO MES PAGO: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 21);
            this.label5.TabIndex = 73;
            this.label5.Text = "RAZON SOCIAL: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 21);
            this.label7.TabIndex = 75;
            this.label7.Text = "PRECIO SUGERIDO: ";
            // 
            // txtCliente
            // 
            this.txtCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtCliente.Location = new System.Drawing.Point(34, 57);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.MaxLength = 5;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.ShortcutsEnabled = false;
            this.txtCliente.Size = new System.Drawing.Size(242, 98);
            this.txtCliente.TabIndex = 76;
            this.txtCliente.TabStop = false;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPagoMensual_KeyDown);
            // 
            // txtMes
            // 
            this.txtMes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtMes.BackColor = System.Drawing.Color.White;
            this.txtMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.ForeColor = System.Drawing.Color.Black;
            this.txtMes.Location = new System.Drawing.Point(138, 337);
            this.txtMes.Margin = new System.Windows.Forms.Padding(2);
            this.txtMes.MaxLength = 2;
            this.txtMes.Name = "txtMes";
            this.txtMes.ReadOnly = true;
            this.txtMes.ShortcutsEnabled = false;
            this.txtMes.Size = new System.Drawing.Size(128, 98);
            this.txtMes.TabIndex = 77;
            this.txtMes.TabStop = false;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPagoMensual_KeyDown);
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.ForeColor = System.Drawing.Color.Black;
            this.lblNombreApellido.Location = new System.Drawing.Point(391, 58);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(15, 21);
            this.lblNombreApellido.TabIndex = 78;
            this.lblNombreApellido.Text = "-";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.lblRazonSocial.Location = new System.Drawing.Point(438, 98);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(15, 21);
            this.lblRazonSocial.TabIndex = 79;
            this.lblRazonSocial.Text = "-";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.ForeColor = System.Drawing.Color.Black;
            this.lblVehiculo.Location = new System.Drawing.Point(118, 179);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(15, 21);
            this.lblVehiculo.TabIndex = 81;
            this.lblVehiculo.Text = "-";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.ForeColor = System.Drawing.Color.Black;
            this.lblPatente.Location = new System.Drawing.Point(106, 215);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(15, 21);
            this.lblPatente.TabIndex = 82;
            this.lblPatente.Text = "-";
            // 
            // lblUltimoMes
            // 
            this.lblUltimoMes.AutoSize = true;
            this.lblUltimoMes.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoMes.ForeColor = System.Drawing.Color.Black;
            this.lblUltimoMes.Location = new System.Drawing.Point(183, 292);
            this.lblUltimoMes.Name = "lblUltimoMes";
            this.lblUltimoMes.Size = new System.Drawing.Size(15, 21);
            this.lblUltimoMes.TabIndex = 83;
            this.lblUltimoMes.Text = "-";
            // 
            // lblPrecioSugerido
            // 
            this.lblPrecioSugerido.AutoSize = true;
            this.lblPrecioSugerido.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioSugerido.ForeColor = System.Drawing.Color.Black;
            this.lblPrecioSugerido.Location = new System.Drawing.Point(468, 292);
            this.lblPrecioSugerido.Name = "lblPrecioSugerido";
            this.lblPrecioSugerido.Size = new System.Drawing.Size(15, 21);
            this.lblPrecioSugerido.TabIndex = 84;
            this.lblPrecioSugerido.Text = "-";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(10, 349);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(127, 72);
            this.label9.TabIndex = 85;
            this.label9.Text = "MES A\r\nPAGAR\r\n";
            // 
            // lblTipoMensual
            // 
            this.lblTipoMensual.AutoSize = true;
            this.lblTipoMensual.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMensual.ForeColor = System.Drawing.Color.Black;
            this.lblTipoMensual.Location = new System.Drawing.Point(212, 251);
            this.lblTipoMensual.Name = "lblTipoMensual";
            this.lblTipoMensual.Size = new System.Drawing.Size(15, 21);
            this.lblTipoMensual.TabIndex = 87;
            this.lblTipoMensual.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 21);
            this.label11.TabIndex = 86;
            this.label11.Text = "TIPO DE MENSUALIDAD: ";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.ForeColor = System.Drawing.Color.Black;
            this.lblFactura.Location = new System.Drawing.Point(401, 137);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(15, 21);
            this.lblFactura.TabIndex = 80;
            this.lblFactura.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 74;
            this.label6.Text = "FACTURA: ";
            // 
            // timerError
            // 
            this.timerError.Interval = 400;
            this.timerError.Tick += new System.EventHandler(this.timerError_Tick);
            // 
            // lblClienteEncontrado
            // 
            this.lblClienteEncontrado.AutoSize = true;
            this.lblClienteEncontrado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteEncontrado.ForeColor = System.Drawing.Color.Green;
            this.lblClienteEncontrado.Location = new System.Drawing.Point(529, 13);
            this.lblClienteEncontrado.Name = "lblClienteEncontrado";
            this.lblClienteEncontrado.Size = new System.Drawing.Size(192, 23);
            this.lblClienteEncontrado.TabIndex = 88;
            this.lblClienteEncontrado.Text = "CLIENTE ENCONTRADO";
            this.lblClienteEncontrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClienteEncontrado.Visible = false;
            // 
            // bdsMensuales
            // 
            this.bdsMensuales.DataSource = typeof(MODELO.Mensual);
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacion.ForeColor = System.Drawing.Color.Green;
            this.lblConfirmacion.Location = new System.Drawing.Point(7, 158);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(804, 178);
            this.lblConfirmacion.TabIndex = 89;
            this.lblConfirmacion.Text = "PAGO REGISTRADO\r\nCORRECTAMENTE";
            this.lblConfirmacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConfirmacion.Visible = false;
            // 
            // timerConfirmacion
            // 
            this.timerConfirmacion.Interval = 400;
            this.timerConfirmacion.Tick += new System.EventHandler(this.timerConfirmacion_Tick);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.Black;
            this.lblObservaciones.Location = new System.Drawing.Point(448, 179);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(345, 103);
            this.lblObservaciones.TabIndex = 91;
            this.lblObservaciones.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(320, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 21);
            this.label12.TabIndex = 90;
            this.label12.Text = "OBSERVACIONES: ";
            // 
            // frmPagoMensual
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(819, 590);
            this.Controls.Add(this.lblConfirmacion);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblClienteEncontrado);
            this.Controls.Add(this.lblTipoMensual);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPrecioSugerido);
            this.Controls.Add(this.lblUltimoMes);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblNombreApellido);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPagoMensual";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago de Mensuales";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPagoMensual_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPagoMensual_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMensuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource bdsMensuales;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblUltimoMes;
        private System.Windows.Forms.Label lblPrecioSugerido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTipoMensual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerError;
        private System.Windows.Forms.Label lblClienteEncontrado;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.Timer timerConfirmacion;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label label12;

    }
}