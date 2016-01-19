using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Objects;

namespace APPWEB.Garage
{
    public partial class nuevomensual : System.Web.UI.Page
    {
 protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtCodigo.Text = CONTROLADORA.ControladoraMensuales.ProximoCodigo().ToString();
                listTipoMensualidad.Items.Add("24HS");
                listTipoMensualidad.Items.Add("DIURNO");
                listTipoMensualidad.Items.Add("NOCTURNO");

                listTipoFactura.Items.Add("A");
                listTipoFactura.Items.Add("B");

           }

        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            MODELO.Mensual newMensual = new MODELO.Mensual();

            newMensual.Activo = true;
            newMensual.Codigo = Convert.ToInt32(txtCodigo.Text);
            newMensual.NombreApellido = txtNombreyApellido.Text;
            newMensual.Vehiculo = txtVehiculo.Text;
            newMensual.Patente = txtPatente.Text;
            newMensual.Domicilio = txtDomicilio.Text;
            newMensual.DomicilioFiscal = txtDomicilioFiscal.Text;
            newMensual.Telefono = txtTelefono.Text;
            newMensual.RazonSocial = txtRazonSocial.Text;
            newMensual.CUIL = txtCUIL.Text;
            newMensual.TipoFactura = listTipoFactura.SelectedItem.Text;
            newMensual.PrecioSugerido = Convert.ToDecimal(txtPrecioMensualidad.Value);
            newMensual.TipoMensual = listTipoMensualidad.SelectedItem.Text;

            newMensual.Observaciones = txtObservaciones.Value;

            newMensual.FechaAlta = DateTime.Today;

            CONTROLADORA.ControladoraMensuales.AgregarMensual(newMensual);

            MODELO.Contexto.ObtenerInstancia().Mensuales.ApplyCurrentValues(newMensual);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, newMensual);


            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("mensuales.aspx");

        }

      }
  }
