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
    public partial class frmVerMensual : Form
    {
        MODELO.Mensual editMensual;

        public frmVerMensual(MODELO.Mensual oMensual)
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

            editMensual = oMensual;
        }

        private void frmVerMensual_Load(object sender, EventArgs e)
        {
            bdsHistorialPagos.DataSource = null;
            bdsHistorialPagos.DataSource = CONTROLADORA.ControladoraMensuales.ListarPagosMensuales(editMensual);


            txtCodigo.Text = editMensual.Codigo.ToString();
            txtNombreApellido.Text = editMensual.NombreApellido;

            txtVehiculo.Text = editMensual.Vehiculo;
            txtPatente.Text = editMensual.Patente;
            txtDomicilio.Text = editMensual.Domicilio;
            txtDomicilioFiscal.Text = editMensual.DomicilioFiscal;
            txtTelefono.Text = editMensual.Telefono;
            txtRazonSocial.Text = editMensual.RazonSocial;
            txtCUIL.Text = editMensual.CUIL;
            cboxTipoFactura.SelectedItem = editMensual.TipoFactura;
            txtPrecio.Text = editMensual.PrecioSugerido.ToString();
            cboxTipoMensualidad.SelectedItem = editMensual.TipoMensual;

            txtObservaciones.Text = editMensual.Observaciones;

            txtFechaAlta.Text = editMensual.FechaAlta.Date.ToShortDateString();
            try
            {
                txtFechaPago.Text = editMensual.PagoMensual.Last().Fecha.Date.ToShortDateString();
                txtUltipoPago.Text = editMensual.PagoMensual.Last().MesSaldado.ToString();
            }
            catch
            {
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
