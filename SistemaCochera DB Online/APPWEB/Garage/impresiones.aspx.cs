using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Objects;

namespace APPWEB.Garage
{
    public partial class impresiones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listImpresiones.DataSource = CONTROLADORA.ControladoraImpresion.ListarImpresiones();
                listImpresiones.DataBind();

                MODELO.Impresion selected = CONTROLADORA.ControladoraImpresion.BuscarImpresion(listImpresiones.SelectedValue.ToString());
                MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, selected);

                txtEncabezado1.Text = selected.Encabezado1;
                txtEncabezado2.Text = selected.Encabezado2;
                txtEncabezado3.Text = selected.Encabezado3;
                txtEncabezado4.Text = selected.Encabezado4;
                txtEncabezado5.Text = selected.Encabezado5;

                txtPie1.Text = selected.Pie1;
                txtPie2.Text = selected.Pie2;
                txtPie3.Text = selected.Pie3;
                txtPie4.Text = selected.Pie4;
                txtPie5.Text = selected.Pie5;

                spanImpresion.InnerText = selected.Descripcion;
            }


            txtEncabezado1.Enabled = false;
            txtEncabezado2.Enabled = false;
            txtEncabezado3.Enabled = false;
            txtEncabezado4.Enabled = false;
            txtEncabezado5.Enabled = false;

            txtPie1.Enabled = false;
            txtPie2.Enabled = false;
            txtPie3.Enabled = false;
            txtPie4.Enabled = false;
            txtPie5.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            txtEncabezado1.Enabled = true;
            txtEncabezado2.Enabled = true;
            txtEncabezado3.Enabled = true;
            txtEncabezado4.Enabled = true;
            txtEncabezado5.Enabled = true;

            txtPie1.Enabled = true;
            txtPie2.Enabled = true;
            txtPie3.Enabled = true;
            txtPie4.Enabled = true;
            txtPie5.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;


        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            MODELO.Impresion oImpresion = CONTROLADORA.ControladoraImpresion.BuscarImpresion(listImpresiones.SelectedValue.ToString());

            oImpresion.Encabezado1 = txtEncabezado1.Text;
            oImpresion.Encabezado2 = txtEncabezado2.Text;
            oImpresion.Encabezado3 = txtEncabezado3.Text;
            oImpresion.Encabezado4 = txtEncabezado4.Text;
            oImpresion.Encabezado5 = txtEncabezado5.Text;

            oImpresion.Pie1 = txtPie1.Text;
            oImpresion.Pie2 = txtPie2.Text;
            oImpresion.Pie3 = txtPie3.Text;
            oImpresion.Pie4 = txtPie4.Text;
            oImpresion.Pie5 = txtPie5.Text;

            MODELO.Contexto.ObtenerInstancia().Impresiones.ApplyCurrentValues(oImpresion);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oImpresion);


            txtEncabezado1.Enabled = false;
            txtEncabezado2.Enabled = false;
            txtEncabezado3.Enabled = false;
            txtEncabezado4.Enabled = false;
            txtEncabezado5.Enabled = false;

            txtPie1.Enabled = false;
            txtPie2.Enabled = false;
            txtPie3.Enabled = false;
            txtPie4.Enabled = false;
            txtPie5.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            MODELO.Impresion selected = CONTROLADORA.ControladoraImpresion.BuscarImpresion(listImpresiones.SelectedValue.ToString());
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, selected);
            txtEncabezado1.Text = selected.Encabezado1;
            txtEncabezado2.Text = selected.Encabezado2;
            txtEncabezado3.Text = selected.Encabezado3;
            txtEncabezado4.Text = selected.Encabezado4;
            txtEncabezado5.Text = selected.Encabezado5;

            txtPie1.Text = selected.Pie1;
            txtPie2.Text = selected.Pie2;
            txtPie3.Text = selected.Pie3;
            txtPie4.Text = selected.Pie4;
            txtPie5.Text = selected.Pie5;

            txtEncabezado1.Enabled = false;
            txtEncabezado2.Enabled = false;
            txtEncabezado3.Enabled = false;
            txtEncabezado4.Enabled = false;
            txtEncabezado5.Enabled = false;

            txtPie1.Enabled = false;
            txtPie2.Enabled = false;
            txtPie3.Enabled = false;
            txtPie4.Enabled = false;
            txtPie5.Enabled = false;


            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }


        
        protected void listImpresiones_IndexChanged(object sender, EventArgs e)
        {
            MODELO.Impresion selected = CONTROLADORA.ControladoraImpresion.BuscarImpresion(listImpresiones.SelectedValue.ToString());
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, selected);

            txtEncabezado1.Text = selected.Encabezado1;
            txtEncabezado2.Text = selected.Encabezado2;
            txtEncabezado3.Text = selected.Encabezado3;
            txtEncabezado4.Text = selected.Encabezado4;
            txtEncabezado5.Text = selected.Encabezado5;

            txtPie1.Text = selected.Pie1;
            txtPie2.Text = selected.Pie2;
            txtPie3.Text = selected.Pie3;
            txtPie4.Text = selected.Pie4;
            txtPie5.Text = selected.Pie5;

            spanImpresion.InnerText = selected.Descripcion;

            txtEncabezado1.Enabled = false;
            txtEncabezado2.Enabled = false;
            txtEncabezado3.Enabled = false;
            txtEncabezado4.Enabled = false;
            txtEncabezado5.Enabled = false;

            txtPie1.Enabled = false;
            txtPie2.Enabled = false;
            txtPie3.Enabled = false;
            txtPie4.Enabled = false;
            txtPie5.Enabled = false;


            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}