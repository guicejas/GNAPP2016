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
    public partial class frmGanancias : Form
    {
        public frmGanancias()
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGanancias_Load(object sender, EventArgs e)
        {
            cboxMes.SelectedIndex = 0;
           // bdsCajas.DataSource = MODELO.Contexto.ObtenerInstancia().Cajas.OrderByDescending(x => x.Total).Take(10);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblSinResultados.Visible = false;

            //if (cboxMes.SelectedIndex == 0 && txtAno.Text == "")
            //{
            //    return;
            //}

            List<MODELO.Caja> oCajas = MODELO.Contexto.ObtenerInstancia().Cajas.ToList();

            if (cboxMes.SelectedIndex >1)
            oCajas = oCajas.Where(x=> x.FechaHoraApertura.Value.Month == (cboxMes.SelectedIndex)).ToList();

            if (txtAno.Text != "")
                oCajas = oCajas.Where(x => x.FechaHoraApertura.Value.Year == Convert.ToInt32(txtAno.Text)).ToList();

            bdsCajas.DataSource = oCajas;

            if (oCajas.Count != 0)
            {
                decimal total = oCajas.Sum(x => x.Total);
                lblTotalR.Text = "$" + total.ToString();

                lblCajasR.Text = oCajas.Count.ToString();

                int vehiculos = oCajas.Sum(x => x.Vehiculo.Count);
                lblVehiculosR.Text = vehiculos.ToString();

                decimal cajamax = oCajas.Max(x => x.Total);
                lblCajaMaximaR.Text = "$" + cajamax.ToString();

                decimal cajamin = oCajas.Min(x => x.Total);
                lblCajaMinimaR.Text = "$" + cajamin.ToString();

                decimal cajaprom = oCajas.Average(x => x.Total);
                lblCajaPromedioR.Text = "$" + (Math.Round(cajaprom, 2)).ToString();

                int vehiculosMax = oCajas.Max(x => x.Vehiculo.Count);
                lblVehiculosMaxR.Text = vehiculosMax.ToString();

                int vehiculosMin = oCajas.Min(x => x.Vehiculo.Count);
                lblVehiculosMinR.Text = vehiculosMin.ToString();

                double vehiculosProm = oCajas.Average(x => x.Vehiculo.Count);
                lblVehiculosPromR.Text = Convert.ToInt32(vehiculosProm).ToString();
            }
            else
            {
                lblTotalR.Text = "-";
                lblCajasR.Text = "-";
                lblVehiculosR.Text = "-";
                lblCajaMaximaR.Text = "-";
                lblCajaMinimaR.Text = "-";
                lblCajaPromedioR.Text = "-";
                lblVehiculosMaxR.Text = "-";
                lblVehiculosMinR.Text = "-";
                lblVehiculosPromR.Text = "-";

                lblSinResultados.Visible = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblSinResultados.Visible = false;
            bdsCajas.DataSource = null;
            cboxMes.SelectedIndex = 0;
            txtAno.Clear();
            lblTotalR.Text = "-";
            lblCajasR.Text = "-";
            lblVehiculosR.Text = "-";
            lblCajaMaximaR.Text = "-";
            lblCajaMinimaR.Text = "-";
            lblCajaPromedioR.Text = "-";
            lblVehiculosMaxR.Text ="-";
            lblVehiculosMinR.Text = "-";
            lblVehiculosPromR.Text = "-";

        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }


    }
}
