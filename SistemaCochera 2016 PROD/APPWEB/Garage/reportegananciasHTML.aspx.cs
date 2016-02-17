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
        //protected string report_string = gencode();

        protected void Page_Load(object sender, EventArgs e)
        {
            string tipo = Request.QueryString["tipo"];

            if (tipo == "mensual")
            {
                string mes = Request.QueryString["mes"];
                string ano = Request.QueryString["ano"];
                string texto = Request.QueryString["texto"];

                spanFiltros.InnerText = "Reporte Mes: "+texto+" - Año: "+ano;

                divCode.InnerHtml = CONTROLADORA.ControladoraReporteHTML.ReporteGananciasMensual(mes, ano);
            }

            if (tipo == "periodo")
            {
                string desde = Request.QueryString["desde"];
                string hasta = Request.QueryString["hasta"];

                spanFiltros.InnerText = "Reporte Desde: " + desde + " - Hasta: " + hasta;


                divCode.InnerHtml = CONTROLADORA.ControladoraReporteHTML.ReporteGananciasPeriodo(desde, hasta);
            }


        }


    }
}