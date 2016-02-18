using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APPWEB.Garage
{
    public partial class reportegananciasHTML : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("es-ES");

            spanFecha.InnerText = "Garage Nadia - " + DateTime.Now.ToString("dd/MM/yyyy hh:mm");

            string tipo = Request.QueryString["tipo"];

            if (tipo == "mensual")
            {
                string mes = Request.QueryString["mes"];
                string ano = Request.QueryString["ano"];
                string texto = Request.QueryString["texto"];
                string detalle = Request.QueryString["detalle"];

                spanFiltros.InnerText = "Mes: "+texto+" - Año: "+ano;

                divCode.InnerHtml = CONTROLADORA.ControladoraReporteHTML.ReporteGananciasMensual(mes, ano, detalle);
            }

            if (tipo == "periodo")
            {
                string desde = Request.QueryString["desde"];
                string hasta = Request.QueryString["hasta"];
                string detalle = Request.QueryString["detalle"];

                spanFiltros.InnerText = "Reporte Desde: " + desde + " - Hasta: " + hasta;


                divCode.InnerHtml = CONTROLADORA.ControladoraReporteHTML.ReporteGananciasPeriodo(desde, hasta, detalle);
            }


        }


    }
}