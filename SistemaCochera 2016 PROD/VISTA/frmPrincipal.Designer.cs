namespace VISTA
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.btnControles = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.gboxNumeros = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnCajaParcial = new System.Windows.Forms.Button();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.gboxControles = new System.Windows.Forms.GroupBox();
            this.btnPagoMensuales = new System.Windows.Forms.Button();
            this.btnDescuentos = new System.Windows.Forms.Button();
            this.btnListadoMovimientos = new System.Windows.Forms.Button();
            this.btnCantidadVechiculos = new System.Windows.Forms.Button();
            this.txtClase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.btnFoco = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.timerCaja = new System.Windows.Forms.Timer(this.components);
            this.timerEstado = new System.Windows.Forms.Timer(this.components);
            this.lblPesos = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.timerError = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnListarEstadias = new System.Windows.Forms.Button();
            this.bdsLista = new System.Windows.Forms.BindingSource(this.components);
            this.gboxNumeros.SuspendLayout();
            this.gboxControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTexto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTexto.BackColor = System.Drawing.Color.White;
            this.txtTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.ForeColor = System.Drawing.Color.Red;
            this.txtTexto.Location = new System.Drawing.Point(348, 44);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(2);
            this.txtTexto.MaxLength = 9;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ReadOnly = true;
            this.txtTexto.ShortcutsEnabled = false;
            this.txtTexto.Size = new System.Drawing.Size(431, 98);
            this.txtTexto.TabIndex = 50;
            this.txtTexto.TabStop = false;
            this.txtTexto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            this.txtTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIngreso.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Image = ((System.Drawing.Image)(resources.GetObject("btnIngreso.Image")));
            this.btnIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngreso.Location = new System.Drawing.Point(316, 210);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(230, 55);
            this.btnIngreso.TabIndex = 1;
            this.btnIngreso.TabStop = false;
            this.btnIngreso.Text = "INGRESO";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            this.btnIngreso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnSalida
            // 
            this.btnSalida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Image = ((System.Drawing.Image)(resources.GetObject("btnSalida.Image")));
            this.btnSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalida.Location = new System.Drawing.Point(604, 210);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(230, 55);
            this.btnSalida.TabIndex = 2;
            this.btnSalida.TabStop = false;
            this.btnSalida.Text = "SALIDA";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            this.btnSalida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministracion.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministracion.Image")));
            this.btnAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdministracion.Location = new System.Drawing.Point(182, 411);
            this.btnAdministracion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(154, 62);
            this.btnAdministracion.TabIndex = 3;
            this.btnAdministracion.TabStop = false;
            this.btnAdministracion.Text = "ADMIN";
            this.btnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.UseVisualStyleBackColor = true;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            this.btnAdministracion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnControles
            // 
            this.btnControles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnControles.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControles.Image = ((System.Drawing.Image)(resources.GetObject("btnControles.Image")));
            this.btnControles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnControles.Location = new System.Drawing.Point(780, 296);
            this.btnControles.Margin = new System.Windows.Forms.Padding(2);
            this.btnControles.Name = "btnControles";
            this.btnControles.Size = new System.Drawing.Size(180, 55);
            this.btnControles.TabIndex = 4;
            this.btnControles.TabStop = false;
            this.btnControles.Text = "CONTROLES";
            this.btnControles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControles.UseVisualStyleBackColor = true;
            this.btnControles.Click += new System.EventHandler(this.btnControles_Click);
            this.btnControles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(28, 30);
            this.btn7.Margin = new System.Windows.Forms.Padding(2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 81);
            this.btn7.TabIndex = 5;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            this.btn7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(132, 30);
            this.btn8.Margin = new System.Windows.Forms.Padding(2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 81);
            this.btn8.TabIndex = 6;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            this.btn8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(236, 30);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 81);
            this.btn9.TabIndex = 7;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            this.btn9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(28, 138);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 81);
            this.btn4.TabIndex = 8;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(132, 138);
            this.btn5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 81);
            this.btn5.TabIndex = 9;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            this.btn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(236, 138);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 81);
            this.btn6.TabIndex = 10;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            this.btn6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(28, 248);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 81);
            this.btn1.TabIndex = 11;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(132, 248);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 81);
            this.btn2.TabIndex = 12;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(236, 248);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 81);
            this.btn3.TabIndex = 13;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(236, 355);
            this.btnPunto.Margin = new System.Windows.Forms.Padding(2);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(75, 81);
            this.btnPunto.TabIndex = 16;
            this.btnPunto.TabStop = false;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            this.btnPunto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(28, 355);
            this.btn0.Margin = new System.Windows.Forms.Padding(2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(180, 81);
            this.btn0.TabIndex = 15;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            this.btn0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // gboxNumeros
            // 
            this.gboxNumeros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gboxNumeros.Controls.Add(this.btnPunto);
            this.gboxNumeros.Controls.Add(this.btn0);
            this.gboxNumeros.Controls.Add(this.btn3);
            this.gboxNumeros.Controls.Add(this.btn2);
            this.gboxNumeros.Controls.Add(this.btn1);
            this.gboxNumeros.Controls.Add(this.btn6);
            this.gboxNumeros.Controls.Add(this.btn5);
            this.gboxNumeros.Controls.Add(this.btn4);
            this.gboxNumeros.Controls.Add(this.btn9);
            this.gboxNumeros.Controls.Add(this.btn8);
            this.gboxNumeros.Controls.Add(this.btn7);
            this.gboxNumeros.Enabled = false;
            this.gboxNumeros.Location = new System.Drawing.Point(384, 282);
            this.gboxNumeros.Margin = new System.Windows.Forms.Padding(2);
            this.gboxNumeros.Name = "gboxNumeros";
            this.gboxNumeros.Padding = new System.Windows.Forms.Padding(2);
            this.gboxNumeros.Size = new System.Drawing.Size(336, 462);
            this.gboxNumeros.TabIndex = 17;
            this.gboxNumeros.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(444, 770);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(230, 55);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnListado
            // 
            this.btnListado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.Image = ((System.Drawing.Image)(resources.GetObject("btnListado.Image")));
            this.btnListado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListado.Location = new System.Drawing.Point(15, 124);
            this.btnListado.Margin = new System.Windows.Forms.Padding(2);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(154, 62);
            this.btnListado.TabIndex = 19;
            this.btnListado.TabStop = false;
            this.btnListado.Text = "LISTADO V.\r\nEN PLAYA";
            this.btnListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            this.btnListado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnCajaParcial
            // 
            this.btnCajaParcial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajaParcial.Image = ((System.Drawing.Image)(resources.GetObject("btnCajaParcial.Image")));
            this.btnCajaParcial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCajaParcial.Location = new System.Drawing.Point(15, 192);
            this.btnCajaParcial.Margin = new System.Windows.Forms.Padding(2);
            this.btnCajaParcial.Name = "btnCajaParcial";
            this.btnCajaParcial.Size = new System.Drawing.Size(154, 62);
            this.btnCajaParcial.TabIndex = 20;
            this.btnCajaParcial.TabStop = false;
            this.btnCajaParcial.Text = "CAJA\r\nPARCIAL";
            this.btnCajaParcial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCajaParcial.UseVisualStyleBackColor = true;
            this.btnCajaParcial.Click += new System.EventHandler(this.btnCaja_Click);
            this.btnCajaParcial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarCaja.Image")));
            this.btnCerrarCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarCaja.Location = new System.Drawing.Point(15, 334);
            this.btnCerrarCaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(154, 62);
            this.btnCerrarCaja.TabIndex = 21;
            this.btnCerrarCaja.TabStop = false;
            this.btnCerrarCaja.Text = "CERRAR\r\nCAJA";
            this.btnCerrarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarCaja.UseVisualStyleBackColor = true;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            this.btnCerrarCaja.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // gboxControles
            // 
            this.gboxControles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gboxControles.BackColor = System.Drawing.SystemColors.Control;
            this.gboxControles.Controls.Add(this.btnListarEstadias);
            this.gboxControles.Controls.Add(this.btnPagoMensuales);
            this.gboxControles.Controls.Add(this.btnDescuentos);
            this.gboxControles.Controls.Add(this.btnListadoMovimientos);
            this.gboxControles.Controls.Add(this.btnCantidadVechiculos);
            this.gboxControles.Controls.Add(this.btnCerrarCaja);
            this.gboxControles.Controls.Add(this.btnCajaParcial);
            this.gboxControles.Controls.Add(this.btnListado);
            this.gboxControles.Controls.Add(this.btnAdministracion);
            this.gboxControles.Enabled = false;
            this.gboxControles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gboxControles.Location = new System.Drawing.Point(780, 312);
            this.gboxControles.Margin = new System.Windows.Forms.Padding(2);
            this.gboxControles.Name = "gboxControles";
            this.gboxControles.Padding = new System.Windows.Forms.Padding(2);
            this.gboxControles.Size = new System.Drawing.Size(349, 486);
            this.gboxControles.TabIndex = 22;
            this.gboxControles.TabStop = false;
            this.gboxControles.Visible = false;
            // 
            // btnPagoMensuales
            // 
            this.btnPagoMensuales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoMensuales.Image = ((System.Drawing.Image)(resources.GetObject("btnPagoMensuales.Image")));
            this.btnPagoMensuales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagoMensuales.Location = new System.Drawing.Point(182, 58);
            this.btnPagoMensuales.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagoMensuales.Name = "btnPagoMensuales";
            this.btnPagoMensuales.Size = new System.Drawing.Size(154, 62);
            this.btnPagoMensuales.TabIndex = 58;
            this.btnPagoMensuales.TabStop = false;
            this.btnPagoMensuales.Text = "PAGO\r\nMENSUAL";
            this.btnPagoMensuales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagoMensuales.UseVisualStyleBackColor = true;
            this.btnPagoMensuales.Click += new System.EventHandler(this.btnPagoMensuales_Click);
            // 
            // btnDescuentos
            // 
            this.btnDescuentos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("btnDescuentos.Image")));
            this.btnDescuentos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescuentos.Location = new System.Drawing.Point(182, 126);
            this.btnDescuentos.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescuentos.Name = "btnDescuentos";
            this.btnDescuentos.Size = new System.Drawing.Size(154, 62);
            this.btnDescuentos.TabIndex = 57;
            this.btnDescuentos.TabStop = false;
            this.btnDescuentos.Text = "AGREGAR\r\nDESCUENTO";
            this.btnDescuentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescuentos.UseVisualStyleBackColor = true;
            this.btnDescuentos.Click += new System.EventHandler(this.btnDescuentos_Click);
            // 
            // btnListadoMovimientos
            // 
            this.btnListadoMovimientos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoMovimientos.Image = ((System.Drawing.Image)(resources.GetObject("btnListadoMovimientos.Image")));
            this.btnListadoMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListadoMovimientos.Location = new System.Drawing.Point(15, 258);
            this.btnListadoMovimientos.Margin = new System.Windows.Forms.Padding(2);
            this.btnListadoMovimientos.Name = "btnListadoMovimientos";
            this.btnListadoMovimientos.Size = new System.Drawing.Size(154, 62);
            this.btnListadoMovimientos.TabIndex = 56;
            this.btnListadoMovimientos.TabStop = false;
            this.btnListadoMovimientos.Text = "MOVIMIENT.\r\nDE CAJA";
            this.btnListadoMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoMovimientos.UseVisualStyleBackColor = true;
            this.btnListadoMovimientos.Click += new System.EventHandler(this.btnListadoMovimientos_Click);
            this.btnListadoMovimientos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnCantidadVechiculos
            // 
            this.btnCantidadVechiculos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidadVechiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnCantidadVechiculos.Image")));
            this.btnCantidadVechiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCantidadVechiculos.Location = new System.Drawing.Point(15, 58);
            this.btnCantidadVechiculos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCantidadVechiculos.Name = "btnCantidadVechiculos";
            this.btnCantidadVechiculos.Size = new System.Drawing.Size(154, 62);
            this.btnCantidadVechiculos.TabIndex = 22;
            this.btnCantidadVechiculos.TabStop = false;
            this.btnCantidadVechiculos.Text = "VEHICULOS\r\nEN PLAYA";
            this.btnCantidadVechiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCantidadVechiculos.UseVisualStyleBackColor = true;
            this.btnCantidadVechiculos.Click += new System.EventHandler(this.btnCantidad_Click);
            this.btnCantidadVechiculos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // txtClase
            // 
            this.txtClase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClase.BackColor = System.Drawing.Color.White;
            this.txtClase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClase.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtClase.Location = new System.Drawing.Point(816, 44);
            this.txtClase.Margin = new System.Windows.Forms.Padding(2);
            this.txtClase.MaxLength = 9;
            this.txtClase.Name = "txtClase";
            this.txtClase.ReadOnly = true;
            this.txtClase.Size = new System.Drawing.Size(74, 98);
            this.txtClase.TabIndex = 50;
            this.txtClase.TabStop = false;
            this.txtClase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClase.TextChanged += new System.EventHandler(this.txtClase_TextChanged);
            this.txtClase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(819, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "CLASE";
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(471, 14);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 24);
            this.lblHora.TabIndex = 26;
            this.lblHora.Text = "Hora";
            // 
            // btnFoco
            // 
            this.btnFoco.FlatAppearance.BorderSize = 0;
            this.btnFoco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoco.Location = new System.Drawing.Point(11, 11);
            this.btnFoco.Margin = new System.Windows.Forms.Padding(2);
            this.btnFoco.Name = "btnFoco";
            this.btnFoco.Size = new System.Drawing.Size(10, 10);
            this.btnFoco.TabIndex = 0;
            this.btnFoco.UseVisualStyleBackColor = true;
            this.btnFoco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(354, 162);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(26, 21);
            this.lblEstado.TabIndex = 51;
            this.lblEstado.Text = "    ";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCaja
            // 
            this.timerCaja.Interval = 3000;
            this.timerCaja.Tick += new System.EventHandler(this.timerCaja_Tick);
            // 
            // timerEstado
            // 
            this.timerEstado.Interval = 500;
            this.timerEstado.Tick += new System.EventHandler(this.timerEstado_Tick);
            // 
            // lblPesos
            // 
            this.lblPesos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPesos.AutoSize = true;
            this.lblPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesos.ForeColor = System.Drawing.Color.Red;
            this.lblPesos.Location = new System.Drawing.Point(272, 46);
            this.lblPesos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(84, 91);
            this.lblPesos.TabIndex = 52;
            this.lblPesos.Text = "$";
            this.lblPesos.Visible = false;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(648, 162);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(65, 23);
            this.lblError.TabIndex = 53;
            this.lblError.Text = "ERROR";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // timerError
            // 
            this.timerError.Interval = 400;
            this.timerError.Tick += new System.EventHandler(this.timerError_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(15, 11);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(250, 170);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 62;
            this.pictureBox5.TabStop = false;
            // 
            // btnListarEstadias
            // 
            this.btnListarEstadias.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarEstadias.Image = ((System.Drawing.Image)(resources.GetObject("btnListarEstadias.Image")));
            this.btnListarEstadias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarEstadias.Location = new System.Drawing.Point(182, 192);
            this.btnListarEstadias.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarEstadias.Name = "btnListarEstadias";
            this.btnListarEstadias.Size = new System.Drawing.Size(154, 62);
            this.btnListarEstadias.TabIndex = 59;
            this.btnListarEstadias.TabStop = false;
            this.btnListarEstadias.Text = "LISTAR\r\nESTADIAS";
            this.btnListarEstadias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarEstadias.UseVisualStyleBackColor = true;
            this.btnListarEstadias.Click += new System.EventHandler(this.btnListarEstadias_Click);
            // 
            // bdsLista
            // 
            this.bdsLista.DataSource = typeof(MODELO.Vehiculo);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1272, 851);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnFoco);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClase);
            this.Controls.Add(this.btnControles);
            this.Controls.Add(this.gboxControles);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gboxNumeros);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(811, 764);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garage Nadia - Sistema de Cobro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.gboxNumeros.ResumeLayout(false);
            this.gboxControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Button btnControles;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.GroupBox gboxNumeros;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnCajaParcial;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.GroupBox gboxControles;
        private System.Windows.Forms.TextBox txtClase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnCantidadVechiculos;
        private System.Windows.Forms.Button btnFoco;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Timer timerCaja;
        private System.Windows.Forms.Timer timerEstado;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer timerError;
        private System.Windows.Forms.BindingSource bdsLista;
        private System.Windows.Forms.Button btnListadoMovimientos;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnPagoMensuales;
        private System.Windows.Forms.Button btnDescuentos;
        private System.Windows.Forms.Button btnListarEstadias;

    }
}

