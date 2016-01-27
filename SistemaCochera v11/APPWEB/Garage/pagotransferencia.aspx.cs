using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APPWEB.Garage
{
    public partial class pagotransferencia : System.Web.UI.Page
    {
        int nro = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                nro = Convert.ToInt32(Request.QueryString["MensualId"]);

                MODELO.Mensual editMensual = CONTROLADORA.ControladoraMensuales.BuscarMensual(nro);

                lblTitulo.InnerText = editMensual.Codigo + " - " + editMensual.NombreApellido;
                txtFechadePago.Text = DateTime.Today.ToShortDateString();


                try
                {
                    int mesPagado = Convert.ToInt16(editMensual.PagoMensual.Last().MesSaldado);
                    if (mesPagado == 12)
                    {
                        mesPagado = 0;
                    }
                    txtMesPagado.Text = (mesPagado + 1).ToString();

                    txtMontoAbonado.Value = editMensual.PrecioSugerido.ToString();

                }
                catch
                {
                }


            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            nro = Convert.ToInt32(Request.QueryString["MensualId"]);

            MODELO.Mensual oMensual = CONTROLADORA.ControladoraMensuales.BuscarMensual(nro);


            if (oMensual.id.ToString().Length > 0 && txtMesPagado.Text.Length > 0 && txtMontoAbonado.Value.Length > 0 && txtFechadePago.Text.Length > 0)
            {
                CONTROLADORA.ControladoraMensuales.AgregarPagoMensualTransferencia(oMensual, Convert.ToInt32(txtMesPagado.Text), Convert.ToDecimal(txtMontoAbonado.Value), Convert.ToDateTime(txtFechadePago.Text));

            }


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("mensuales.aspx");
        }


    }
}