using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APPWEB.Garage
{
    public partial class reporteganancias : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            listMesMensual.Items.Add("TODOS");
            listMesMensual.Items.Add("ENERO");
            listMesMensual.Items.Add("FEBRERO");
            listMesMensual.Items.Add("MARZO");
            listMesMensual.Items.Add("ABRIL");
            listMesMensual.Items.Add("MAYO");
            listMesMensual.Items.Add("JUNIO");
            listMesMensual.Items.Add("JULIO");
            listMesMensual.Items.Add("AGOSTO");
            listMesMensual.Items.Add("SEPTIEMBRE");
            listMesMensual.Items.Add("OCTUBRE");
            listMesMensual.Items.Add("NOVIEMBRE");
            listMesMensual.Items.Add("DICIEMBRE");
        }

        protected void btnGenerarMensual_Click(object sender, EventArgs e)
        {

        }

        protected void btnGenerarPeriodo_Click(object sender, EventArgs e)
        {

        }


    }
}