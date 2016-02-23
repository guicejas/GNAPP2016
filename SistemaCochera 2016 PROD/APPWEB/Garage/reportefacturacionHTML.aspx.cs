using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APPWEB.Garage
{
    public partial class reportefacturacionHTML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("es-ES");

            spanFecha.InnerText = "Garage Nadia - " + DateTime.Now.ToString("dd/MM/yyyy hh:mm");

            divCode.InnerHtml = CONTROLADORA.ControladoraReporteHTML.ReporteFacturacion(radiotipoMensual.SelectedValue, radioTipoFactura.SelectedValue);


        }
    }
}