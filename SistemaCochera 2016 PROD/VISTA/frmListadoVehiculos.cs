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
    public partial class frmListadoVehiculos : Form
    {
        public frmListadoVehiculos()
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

        private void frmListadoVehiculos_Load(object sender, EventArgs e)
        {

            
            // bdsListadoVehiculos.DataSource = CONTROLADORA.ControladoraVehiculos.ListarVehiculos();
            bdsListadoVehiculos.DataSource = null;
            lblSinResultados.Visible = false;
            cboxEstado.SelectedIndex = 0;
            lblResultados.Text = "-";
            txtPatente.Clear();
            txtNroTicket.Clear();
            txtClase.Clear();
            txtNroCaja.Clear();

            checkFechaEntrada.Checked = false;
            checkFechaSalida.Checked = false;
        }

        private void checkFechaEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFechaEntrada.Checked ==true)
            gboxFechaEntrada.Enabled = true;
            if (checkFechaEntrada.Checked == false)
                gboxFechaEntrada.Enabled = false;
        }

        private void checkFechaSalida_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFechaSalida.Checked == true)
                gboxFechaSalida.Enabled = true;
            if (checkFechaSalida.Checked == false)
                gboxFechaSalida.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblSinResultados.Visible = false;

            string patente = txtPatente.Text.ToString();
            string nroTicket = txtNroTicket.Text.ToString();
            string estado = cboxEstado.Text.ToString();

            string clase = txtClase.Text.ToString();
            string nroCaja = txtNroCaja.Text.ToString();

            object EntradaDesde = null;
            object EntradaHasta = null;
            object SalidaDesde = null;
            object SalidaHasta = null;

            if (checkFechaEntrada.Checked)
            {
                EntradaDesde = dtpEntradaDesde.Value.Date;
                EntradaHasta = dtpEntradaHasta.Value.Date;
            }

            if (checkFechaSalida.Checked)
            {
                SalidaDesde = dtpSalidaDesde.Value.Date;
                SalidaHasta = dtpSalidaHasta.Value.Date;
            }

            bdsListadoVehiculos.DataSource = CONTROLADORA.ControladoraVehiculos.ListarVehiculosFiltrados(patente, nroTicket, estado, clase, nroCaja, EntradaDesde, EntradaHasta, SalidaDesde, SalidaHasta);

            if (bdsListadoVehiculos.Count == 0)
            {
                lblSinResultados.Visible = true;
                lblResultados.Text = "-";
            }
            else
            {
                lblResultados.Text = bdsListadoVehiculos.Count.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            frmListadoVehiculos_Load(null, null);
        }

    }
}
