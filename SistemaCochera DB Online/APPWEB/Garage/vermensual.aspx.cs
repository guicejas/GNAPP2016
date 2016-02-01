using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Objects;

namespace APPWEB.Garage
{
    public partial class vermensual : System.Web.UI.Page
    {
        int nro=0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int nro = Convert.ToInt32(Request.QueryString["MensualId"]);

                listTipoMensualidad.Items.Add("24HS");
                listTipoMensualidad.Items.Add("DIURNO");
                listTipoMensualidad.Items.Add("NOCTURNO");

                listTipoFactura.Items.Add("A");
                listTipoFactura.Items.Add("B");


                MODELO.Mensual editMensual = CONTROLADORA.ControladoraMensuales.BuscarMensual(nro);

                txtCodigo.Text = editMensual.Codigo.ToString();
                txtNombreyApellido.Text = editMensual.NombreApellido;
                txtVehiculo.Text = editMensual.Vehiculo;
                txtPatente.Text = editMensual.Patente;
                txtDomicilio.Text = editMensual.Domicilio;
                txtDomicilioFiscal.Text = editMensual.DomicilioFiscal;
                txtTelefono.Text = editMensual.Telefono;
                txtRazonSocial.Text = editMensual.RazonSocial;
                txtCUIL.Text = editMensual.CUIL;
                listTipoFactura.SelectedValue = editMensual.TipoFactura;
                txtPrecioMensualidad.Value = editMensual.PrecioSugerido.ToString();
                listTipoMensualidad.SelectedValue = editMensual.TipoMensual;
                txtObservaciones.Value = editMensual.Observaciones;

                GridHistorialPagos.DataSource = CONTROLADORA.ControladoraMensuales.ListarPagosMensuales(editMensual);
                GridHistorialPagos.DataBind();

                try
                {
                    txtUltimoMesPago.InnerText = editMensual.PagoMensual.Last().MesSaldado.ToString();
                    txtFechaUltimoMesPago.InnerText = editMensual.PagoMensual.Last().Fecha.Date.ToShortDateString();
                }
                catch
                {
                }

            }


        }

        protected void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            int nro = Convert.ToInt32(Request.QueryString["MensualId"]);

            Response.Redirect("pagotransferencia.aspx?MensualId="+nro);
        }
    }
}