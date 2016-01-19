using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Configuration;
using System.Text;

namespace APPWEB.Garage
{
    public partial class vehiculos : System.Web.UI.Page
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
            GridVehiculos.DataSource = CONTROLADORA.ControladoraVehiculos.ListarVehiculos();
            GridVehiculos.DataBind();
        }

        protected void GridVehiculos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridVehiculos.PageIndex = e.NewPageIndex;
            LoadGridData();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtFiltroPatente.Text != "" || txtFiltroCaja.Text != "" || txtFiltroClase.Text != "" || txtFiltroEntrada.Value != "" || txtFiltroSalida.Value != "" || txtFiltroEstado.SelectedIndex != 0)
            {
                GridVehiculos.DataSource = CONTROLADORA.ControladoraVehiculos.ListarVehiculosFiltrados(txtFiltroPatente.Text, txtFiltroEstado.SelectedValue.ToString(), txtFiltroClase.Text, txtFiltroEntrada.Value, txtFiltroSalida.Value, txtFiltroCaja.Text);
            GridVehiculos.DataBind();
            }

        }

        protected void btnReestablecer_Click(object sender, EventArgs e)
        {
            txtFiltroPatente.Text = "";
            txtFiltroCaja.Text = "";
            txtFiltroClase.Text = "";
            txtFiltroEntrada.Value = "";
            txtFiltroSalida.Value = "";
            txtFiltroEstado.SelectedIndex = 0;
            
            LoadGridData();
        }

        //public List<MODELO.Vehiculo> GetVehiculosFilter()
        //{
        //    string patente = null;
        //    string patenteTaxi = null;
        //    string año = null;

        //    if (txtFiltroPatente.Text != "")
        //    {
        //        patente = txtFiltroPatente.Text;
        //    }

        //    if (txtFiltroPatenteTaxi.Text != "")
        //    {
        //        patenteTaxi = txtFiltroPatenteTaxi.Text;
        //    }

        //    if (txtFiltroAño.Text != "")
        //    {
        //        año = txtFiltroAño.Text;
        //    }

        //    return ControladoraVehiculos.getINSTANCIA.ListarVehiculosFiltrados(ctrlFlotas.ObtenerFlotadeUsuario(this.Context.User.Identity.Name).Id.ToString(), patente, patenteTaxi, año);
        //}



    }
}