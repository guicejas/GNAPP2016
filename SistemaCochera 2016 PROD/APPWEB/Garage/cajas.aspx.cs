using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APPWEB.Garage
{
    public partial class cajas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LoadGridData();
            }
        }

        private void LoadGridData()
        {
            GridCajas.DataSource = CONTROLADORA.ControladoraCajas.ListarCajas();
            GridCajas.DataBind();
        }

        protected void GridCajas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridCajas.PageIndex = e.NewPageIndex;
            LoadGridData();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtFiltroCaja.Text != "" || txtFiltroApertura.Value != "" || txtFiltroCierre.Value != "" || txtFiltroEstado.SelectedIndex != 0)
            {
                GridCajas.DataSource = CONTROLADORA.ControladoraCajas.ListarCajasFiltradas(txtFiltroCaja.Text, txtFiltroEstado.SelectedValue.ToString(), txtFiltroApertura.Value, txtFiltroCierre.Value);
                GridCajas.DataBind();
            }

        }

        protected void btnReestablecer_Click(object sender, EventArgs e)
        {
            txtFiltroCaja.Text = "";
            txtFiltroApertura.Value = "";
            txtFiltroCierre.Value = "";
            txtFiltroEstado.SelectedIndex = 0;

            LoadGridData();
        }
    }
}