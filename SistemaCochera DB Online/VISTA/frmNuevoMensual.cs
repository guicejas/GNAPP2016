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
    public partial class frmNuevoMensual : Form
    {
        string accion;
        MODELO.Mensual editMensual;

        public frmNuevoMensual()
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


            accion = "ALTA";
        }

        public frmNuevoMensual(MODELO.Mensual oMensual)
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
            accion = "MODIFICACION";
        }

        private void frmNuevoMensual_Load(object sender, EventArgs e)
        {
            if (accion == "ALTA")
            {
                txtCodigo.Text = CONTROLADORA.ControladoraMensuales.ProximoCodigo().ToString();
            }
            if (accion == "MODIFICACION")
            {
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

            }

        }

        private bool validaciones()
        {
            if (txtNombreApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del mensual.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                Convert.ToDecimal(txtPrecio.Text);
            }
            catch
            {
                MessageBox.Show("El precio es incorrecto. Ingreselo en formato xx,xx", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validaciones() == true)
            {
                if (accion == "ALTA")
                {
                    MODELO.Mensual newMensual = new MODELO.Mensual();

                    newMensual.Activo = true;
                    newMensual.Codigo = Convert.ToInt32(txtCodigo.Text);
                    newMensual.NombreApellido = txtNombreApellido.Text;
                    newMensual.Vehiculo = txtVehiculo.Text;
                    newMensual.Patente = txtPatente.Text;
                    newMensual.Domicilio = txtDomicilio.Text;
                    newMensual.DomicilioFiscal = txtDomicilioFiscal.Text;
                    newMensual.Telefono = txtTelefono.Text;
                    newMensual.RazonSocial = txtRazonSocial.Text;
                    newMensual.CUIL = txtCUIL.Text;
                    newMensual.TipoFactura = cboxTipoFactura.Text;
                    newMensual.PrecioSugerido = Convert.ToDecimal(txtPrecio.Text);
                    newMensual.TipoMensual = cboxTipoMensualidad.Text;

                    newMensual.Observaciones = txtObservaciones.Text;

                    newMensual.FechaAlta = DateTime.Today;

                    CONTROLADORA.ControladoraMensuales.AgregarMensual(newMensual);
                }

                if (accion == "MODIFICACION")
                {
                    editMensual.Codigo = Convert.ToInt32(txtCodigo.Text);
                    editMensual.NombreApellido = txtNombreApellido.Text;
                    editMensual.Vehiculo = txtVehiculo.Text;
                    editMensual.Patente = txtPatente.Text;
                    editMensual.Domicilio = txtDomicilio.Text;
                    editMensual.DomicilioFiscal = txtDomicilioFiscal.Text;
                    editMensual.Telefono = txtTelefono.Text;
                    editMensual.RazonSocial = txtRazonSocial.Text;
                    editMensual.CUIL = txtCUIL.Text;
                    editMensual.TipoFactura = cboxTipoFactura.Text;
                    editMensual.PrecioSugerido = Convert.ToDecimal(txtPrecio.Text);
                    editMensual.TipoMensual = cboxTipoMensualidad.Text;
                    editMensual.Observaciones = txtObservaciones.Text;

                    CONTROLADORA.ControladoraMensuales.ModificarMensual(editMensual);

                }

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
