using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APPWEB.Garage
{
    public partial class mensuales : System.Web.UI.Page
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
            GridMensuales.DataSource = CONTROLADORA.ControladoraMensuales.ListarMensuales();
            GridMensuales.DataBind();
        }

        protected void GridMensuales_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridMensuales.PageIndex = e.NewPageIndex;
            LoadGridData();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtFiltroNombreApellido.Text != "" || txtFiltroRazonSocial.Text != "" || txtFiltroPatente.Text != "" || txtFiltroTipo.SelectedIndex != 0)
            {
                GridMensuales.DataSource = CONTROLADORA.ControladoraMensuales.ListarMensualesFiltrados(txtFiltroNombreApellido.Text, txtFiltroPatente.Text, txtFiltroRazonSocial.Text, txtFiltroTipo.SelectedValue.ToString());
                GridMensuales.DataBind();
            }

        }

        protected void btnReestablecer_Click(object sender, EventArgs e)
        {
            txtFiltroNombreApellido.Text = "";
            txtFiltroRazonSocial.Text = "";
            txtFiltroPatente.Text = "";
            txtFiltroTipo.SelectedIndex = 0;

            LoadGridData();
        }

        protected void GridMensuales_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int mensualId = Convert.ToInt32(this.GridMensuales.Rows[e.RowIndex].Cells[0].Text);

            CONTROLADORA.ControladoraMensuales.DesactivarMensual(mensualId);

            e.Cancel = true;
            this.GridMensuales.DataSource = null;
        }

        protected void GridMensuales_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string mensualId = this.GridMensuales.Rows[e.NewEditIndex].Cells[0].Text;
            Response.Redirect("pagotransferencia.aspx?MensualId=" + mensualId);
        }

        protected void SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
                string mensualId = this.GridMensuales.Rows[e.NewSelectedIndex].Cells[0].Text;
                Response.Redirect("vermensual.aspx?MensualId=" + mensualId);

        }


    }

}
