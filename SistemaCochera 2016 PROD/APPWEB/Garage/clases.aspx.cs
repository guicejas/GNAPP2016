using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Objects;

namespace APPWEB.Garage
{
    public partial class clases : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listClases.DataSource = CONTROLADORA.ControladoraClases.ListarClases();
                listClases.DataBind();

                MODELO.Clase selected = CONTROLADORA.ControladoraClases.BuscarClase(listClases.SelectedValue.ToString());
                MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, selected);
                txtCodigo.Text = selected.Codigo;
                txtDescripcion.Text = selected.Descripcion;
                txtPrecioHora.Value = selected.PrecioHora.ToString();
                txtPrecioEstadia12.Value = selected.PrecioMediaEstadia.ToString();
                txtPrecioEstadia24.Value = selected.PrecioEstadia.ToString();
                txtCambioMediaEstadia.Value = selected.TiempoCambioEstadia.Value.ToString();
                spanClase.InnerText = selected.Descripcion; 
            }

            txtPrecioHora.Disabled = true;
            txtPrecioEstadia12.Disabled = true;
            txtPrecioEstadia24.Disabled = true;
            txtCambioMediaEstadia.Disabled = true;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            txtPrecioHora.Disabled = false;
            txtPrecioEstadia12.Disabled = false;
            txtPrecioEstadia24.Disabled = false;
            txtCambioMediaEstadia.Disabled = false;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            MODELO.Clase oClase = CONTROLADORA.ControladoraClases.BuscarClase(listClases.SelectedValue.ToString());

            oClase.PrecioHora = Convert.ToDecimal(txtPrecioHora.Value);
            oClase.PrecioMediaEstadia = Convert.ToDecimal(txtPrecioEstadia12.Value);
            oClase.PrecioEstadia = Convert.ToDecimal(txtPrecioEstadia24.Value);
            if (txtCambioMediaEstadia.Value != "")
                oClase.TiempoCambioEstadia = Convert.ToInt32(txtCambioMediaEstadia.Value);


            MODELO.Contexto.ObtenerInstancia().Clases.ApplyCurrentValues(oClase);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oClase);

            txtPrecioHora.Disabled = true;
            txtPrecioEstadia12.Disabled = true;
            txtPrecioEstadia24.Disabled = true;
            txtCambioMediaEstadia.Disabled = true;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            MODELO.Clase selected = CONTROLADORA.ControladoraClases.BuscarClase(listClases.SelectedValue.ToString());
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, selected);

            txtPrecioHora.Value = selected.PrecioHora.ToString();
            txtPrecioEstadia12.Value = selected.PrecioMediaEstadia.ToString();
            txtPrecioEstadia24.Value = selected.PrecioEstadia.ToString();
            txtCambioMediaEstadia.Value = selected.TiempoCambioEstadia.Value.ToString();

            txtPrecioHora.Disabled = true;
            txtPrecioEstadia12.Disabled = true;
            txtPrecioEstadia24.Disabled = true;
            txtCambioMediaEstadia.Disabled = true;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }


        protected void listClases_IndexChanged(object sender, EventArgs e)
        {
            MODELO.Clase selected = CONTROLADORA.ControladoraClases.BuscarClase(listClases.SelectedValue.ToString());
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, selected);

            txtPrecioHora.Value = selected.PrecioHora.ToString();
            txtPrecioEstadia12.Value = selected.PrecioMediaEstadia.ToString();
            txtPrecioEstadia24.Value = selected.PrecioEstadia.ToString();
            txtDescripcion.Text = selected.Descripcion;
            txtCodigo.Text = selected.Codigo;
            txtCambioMediaEstadia.Value = selected.TiempoCambioEstadia.Value.ToString();
            spanClase.InnerText = selected.Descripcion; 

            txtPrecioHora.Disabled = true;
            txtPrecioEstadia12.Disabled = true;
            txtPrecioEstadia24.Disabled = true;
            txtCambioMediaEstadia.Disabled = true;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

    }
}