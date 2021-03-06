﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Objects;

namespace APPWEB.Garage
{
    public partial class vermensual : System.Web.UI.Page
    {
        int nro=0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int nro = Convert.ToInt32(Request.QueryString["MensualId"]);

                listTipoMensualidad.Items.Add("24HS");
                listTipoMensualidad.Items.Add("DIURNO");
                listTipoMensualidad.Items.Add("NOCTURNO");

                listTipoFactura.Items.Add("A");
                listTipoFactura.Items.Add("B");


                MODELO.Mensual editMensual = CONTROLADORA.ControladoraMensuales.BuscarMensualID(nro);

                txtCodigo.Text = editMensual.Codigo.ToString();
                txtNombreyApellido.Text = editMensual.NombreApellido;
                txtVehiculo.Text = editMensual.Vehiculo;
                txtPatente.Text = editMensual.Patente;
                txtDomicilio.Text = editMensual.Domicilio;
                txtDomicilioFiscal.Text = editMensual.DomicilioFiscal;
                txtTelefono.Text = editMensual.Telefono;
                txtRazonSocial.Text = editMensual.RazonSocial;
                txtCUIL.Text = editMensual.CUIL;
                listTipoFactura.SelectedValue = editMensual.TipoFactura;
                txtPrecioMensualidad.Value = editMensual.PrecioSugerido.ToString();
                listTipoMensualidad.SelectedValue = editMensual.TipoMensual;
                txtObservaciones.Value = editMensual.Observaciones;

                GridHistorialPagos.DataSource = CONTROLADORA.ControladoraMensuales.ListarPagosMensuales(editMensual);
                GridHistorialPagos.DataBind();

                try
                {
                    txtUltimoMesPago.InnerText = editMensual.PagoMensual.Last().MesSaldado.ToString();
                    txtFechaUltimoMesPago.InnerText = editMensual.PagoMensual.Last().Fecha.Date.ToShortDateString();
                }
                catch
                {
                }

                linkProxMensual.HRef = "vermensual.aspx?MensualId=" + CONTROLADORA.ControladoraMensuales.ProxMensual(editMensual);
                linkPrevMensual.HRef = "vermensual.aspx?MensualId=" + CONTROLADORA.ControladoraMensuales.PrevMensual(editMensual);
                spanMensual.InnerText = editMensual.NombreApellido;

            }

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = true;
            btnCancelar.Text = "Volver";


        }

        protected void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            int nro = Convert.ToInt32(Request.QueryString["MensualId"]);

            Response.Redirect("pagotransferencia.aspx?MensualId="+nro);
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombreyApellido.Enabled = true;
            txtVehiculo.Enabled = true;
            txtPatente.Enabled = true;
            txtDomicilio.Enabled = true;
            txtDomicilioFiscal.Enabled = true;
            txtTelefono.Enabled = true;
            txtRazonSocial.Enabled = true;
            txtCUIL.Enabled = true;
            listTipoFactura.Enabled = true;
            txtPrecioMensualidad.Disabled = false;
            listTipoMensualidad.Enabled = true;
            txtObservaciones.Disabled = false;

            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Text = "Cancelar";


        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            MODELO.Mensual oMensual = CONTROLADORA.ControladoraMensuales.BuscarMensual(Convert.ToInt32(txtCodigo.Text));


            oMensual.NombreApellido = txtNombreyApellido.Text;
            oMensual.Vehiculo = txtVehiculo.Text;
            oMensual.Patente = txtPatente.Text;
            oMensual.Domicilio = txtDomicilio.Text;
            oMensual.DomicilioFiscal = txtDomicilioFiscal.Text;
            oMensual.Telefono = txtTelefono.Text;
            oMensual.RazonSocial = txtRazonSocial.Text;
            oMensual.CUIL = txtCUIL.Text;
            oMensual.TipoFactura = listTipoFactura.SelectedValue;
            oMensual.PrecioSugerido = Convert.ToDecimal(txtPrecioMensualidad.Value);
            oMensual.TipoMensual = listTipoMensualidad.SelectedValue;
            oMensual.Observaciones = txtObservaciones.Value;

            MODELO.Contexto.ObtenerInstancia().Mensuales.ApplyCurrentValues(oMensual);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oMensual);

            txtNombreyApellido.Enabled = false;
            txtVehiculo.Enabled = false;
            txtPatente.Enabled = false;
            txtDomicilio.Enabled = false;
            txtDomicilioFiscal.Enabled = false;
            txtTelefono.Enabled = false;
            txtRazonSocial.Enabled = false;
            txtCUIL.Enabled = false;
            listTipoFactura.Enabled = false;
            txtPrecioMensualidad.Disabled = true;
            listTipoMensualidad.Enabled = false;
            txtObservaciones.Disabled = true;

            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Text = "Volver";

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("mensuales.aspx");
        }

    }
}