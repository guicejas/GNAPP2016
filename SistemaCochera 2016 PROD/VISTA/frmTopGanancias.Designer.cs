namespace VISTA
{
    partial class frmTopGanancias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTopGanancias));
            this.dgridCajasTOP = new System.Windows.Forms.DataGridView();
            this.TOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadVehiculos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraAperturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraCierreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsCajasTop = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgridCajasTOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCajasTop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridCajasTOP
            // 
            this.dgridCajasTOP.AllowUserToAddRows = false;
            this.dgridCajasTOP.AllowUserToDeleteRows = false;
            this.dgridCajasTOP.AllowUserToOrderColumns = true;
            this.dgridCajasTOP.AutoGenerateColumns = false;
            this.dgridCajasTOP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridCajasTOP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridCajasTOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridCajasTOP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TOP,
            this.totalDataGridViewTextBoxColumn,
            this.nroCajaDataGridViewTextBoxColumn,
            this.fechaHoraAperturaDataGridViewTextBoxColumn,
            this.fechaHoraCierreDataGridViewTextBoxColumn,
            this.CantidadVehiculos});
            this.dgridCajasTOP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgridCajasTOP.DataSource = this.bdsCajasTop;
            this.dgridCajasTOP.Location = new System.Drawing.Point(20, 65);
            this.dgridCajasTOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgridCajasTOP.MultiSelect = false;
            this.dgridCajasTOP.Name = "dgridCajasTOP";
            this.dgridCajasTOP.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridCajasTOP.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgridCajasTOP.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgridCajasTOP.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgridCajasTOP.RowTemplate.Height = 35;
            this.dgridCajasTOP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridCajasTOP.Size = new System.Drawing.Size(913, 497);
            this.dgridCajasTOP.TabIndex = 21;
            // 
            // TOP
            // 
            this.TOP.FillWeight = 200F;
            this.TOP.HeaderText = "TOP";
            this.TOP.Name = "TOP";
            this.TOP.ReadOnly = true;
            this.TOP.Width = 50;
            // 
            // CantidadVehiculos
            // 
            this.CantidadVehiculos.DataPropertyName = "CantidadVehiculos";
            this.CantidadVehiculos.FillWeight = 200F;
            this.CantidadVehiculos.HeaderText = "Cant Veh.";
            this.CantidadVehiculos.Name = "CantidadVehiculos";
            this.CantidadVehiculos.ReadOnly = true;
            this.CantidadVehiculos.Width = 110;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(773, 580);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(152, 43);
            this.btnCerrar.TabIndex = 34;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 40);
            this.label1.TabIndex = 35;
            this.label1.Text = "TOP 10 MEJORES CAJAS";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.FillWeight = 200F;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Recaudado";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nroCajaDataGridViewTextBoxColumn
            // 
            this.nroCajaDataGridViewTextBoxColumn.DataPropertyName = "NroCaja";
            this.nroCajaDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nroCajaDataGridViewTextBoxColumn.HeaderText = "Nro Caja";
            this.nroCajaDataGridViewTextBoxColumn.Name = "nroCajaDataGridViewTextBoxColumn";
            this.nroCajaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHoraAperturaDataGridViewTextBoxColumn
            // 
            this.fechaHoraAperturaDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraApertura";
            this.fechaHoraAperturaDataGridViewTextBoxColumn.FillWeight = 200F;
            this.fechaHoraAperturaDataGridViewTextBoxColumn.HeaderText = "Apertura";
            this.fechaHoraAperturaDataGridViewTextBoxColumn.Name = "fechaHoraAperturaDataGridViewTextBoxColumn";
            this.fechaHoraAperturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaHoraAperturaDataGridViewTextBoxColumn.Width = 160;
            // 
            // fechaHoraCierreDataGridViewTextBoxColumn
            // 
            this.fechaHoraCierreDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraCierre";
            this.fechaHoraCierreDataGridViewTextBoxColumn.FillWeight = 200F;
            this.fechaHoraCierreDataGridViewTextBoxColumn.HeaderText = "Cierre";
            this.fechaHoraCierreDataGridViewTextBoxColumn.Name = "fechaHoraCierreDataGridViewTextBoxColumn";
            this.fechaHoraCierreDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaHoraCierreDataGridViewTextBoxColumn.Width = 160;
            // 
            // bdsCajasTop
            // 
            this.bdsCajasTop.DataSource = typeof(MODELO.Caja);
            // 
            // frmTopGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgridCajasTOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(958, 663);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(958, 663);
            this.Name = "frmTopGanancias";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TOP 10 MEJORES GANANCIAS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTopGanancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridCajasTOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCajasTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsCajasTop;
        private System.Windows.Forms.DataGridView dgridCajasTOP;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraAperturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraCierreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVehiculos;
    }
}