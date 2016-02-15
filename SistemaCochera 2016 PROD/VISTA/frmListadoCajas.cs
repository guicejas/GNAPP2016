using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmListadoCajas : Form
    {
        public frmListadoCajas()
        {
            InitializeComponent();
            if (CONTROLADORA.ControladoraSistema.Sistema().CheckSiempreTOP)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void frmListadoCajas_Load(object sender, EventArgs e)
        {
            bdsListadoCajas.DataSource = null;
            lblSinResultados.Visible = false;
            cboxEstado.SelectedIndex = 0;

            txtNroCaja.Clear();
            lblResultados.Text = "-";
            checkFechaApertura.Checked = false;
            checkFechaCierre.Checked = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblSinResultados.Visible = false;

            string nroCaja = txtNroCaja.Text.ToString();
            string estado = cboxEstado.Text.ToString();
                        
            object AperturaDesde = null;
            object AperturaHasta = null;
            object CierreDesde = null;
            object CierreHasta = null;

            if (checkFechaApertura.Checked)
            {
                AperturaDesde = dtpAperturaDesde.Value.Date;
                AperturaHasta = dtpAperturaHasta.Value.Date;
            }

            if (checkFechaCierre.Checked)
            {
                CierreDesde = dtpCierreDesde.Value.Date;
                CierreHasta = dtpCierreHasta.Value.Date;
            }

            bdsListadoCajas.DataSource = CONTROLADORA.ControladoraCajas.ListarCajasFiltradas(nroCaja, estado, AperturaDesde, AperturaHasta, CierreDesde, CierreHasta);

            if (bdsListadoCajas.Count == 0)
            {
                lblSinResultados.Visible = true;
                lblResultados.Text = "-";
            }
            else
            {
                lblResultados.Text = bdsListadoCajas.Count.ToString();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            frmListadoCajas_Load(null, null);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkFechaApertura_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFechaApertura.Checked == true)
                gboxFechaApertura.Enabled = true;
            if (checkFechaApertura.Checked == false)
                gboxFechaApertura.Enabled = false;
        }

        private void checkFechaCierre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFechaCierre.Checked == true)
                gboxFechaCierre.Enabled = true;
            if (checkFechaCierre.Checked == false)
                gboxFechaCierre.Enabled = false;

        }
    }
}
