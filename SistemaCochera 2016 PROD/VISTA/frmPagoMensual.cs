using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;

namespace VISTA
{
    public partial class frmPagoMensual : Form
    {
        bool parpadeo = true;
        int countParpadeo = 0;
        int paso = 0;
        MODELO.Mensual oMensual;

        public frmPagoMensual()
        {
            InitializeComponent();
            this.TopMost = true;

            //txtCliente.Focus();
            txtCliente.BackColor = Color.Khaki;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   # region TECLADO

        private void frmPagoMensual_KeyDown(object sender, KeyEventArgs e)
        {
            //txtCliente.Focus();

            lblError.Visible = false;
            countParpadeo = 0;
            timerError.Enabled = false;

            if (e.KeyCode == Keys.Add)
            {
                e.SuppressKeyPress = true;
                //btnAceptar_Click(null, null);

                if (txtCliente.TextLength > 0)
                { 

                oMensual = CONTROLADORA.ControladoraMensuales.BuscarMensual(Convert.ToInt32(txtCliente.Text));

                if (oMensual != null)
                {
                    lblClienteEncontrado.Visible = true;
                    paso = 1;
                    txtCliente.BackColor = Color.White;
                    txtMes.BackColor = Color.Khaki;

                    lblNombreApellido.Text = oMensual.NombreApellido;
                    lblRazonSocial.Text = oMensual.RazonSocial;
                    lblFactura.Text = oMensual.TipoFactura;
                    lblVehiculo.Text = oMensual.Vehiculo;
                    lblPatente.Text = oMensual.Patente;
                    lblTipoMensual.Text = oMensual.TipoMensual;
                    lblPrecioSugerido.Text = "$ " + oMensual.PrecioSugerido.ToString();
                    lblObservaciones.Text = oMensual.Observaciones;
                    try
                    {
                        lblUltimoMes.Text = oMensual.PagoMensual.Last().MesSaldado.ToString();
                    }
                    catch { }
                    
                }
                else
                {
                    error();

                }


                }

                if (txtMes.TextLength > 0)
                { paso = 2;
                txtMes.BackColor = Color.White;
                txtMonto.BackColor = Color.Khaki;
                }

                if (txtMonto.TextLength > 0)
                { paso = 3;
                txtMonto.BackColor = Color.White;
                }

                if (paso == 3)
                { btnAceptar_Click(null, null); }
                
            }

            if (e.KeyCode == Keys.Divide)
            {
                e.SuppressKeyPress = true;
                btnCancelar_Click(null, null);
            }

            if (paso == 0)
            teclasCliente(e);

            if (paso == 1)
            teclasMes(e);

            if (paso == 2)
            teclasMonto(e);
            
        }

        
        private void teclasCliente(KeyEventArgs e)
        {
            if (txtCliente.Text.Length < 5)
            {

                if (e.KeyCode == Keys.NumPad0)
                {
                    e.SuppressKeyPress = true;
                    txtCliente.Text = txtCliente.Text + "0";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad1)
                {
                    e.SuppressKeyPress = true;
                    txtCliente.Text = txtCliente.Text + "1";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad2)
                {
                    e.SuppressKeyPress = true;
                    txtCliente.Text = txtCliente.Text + "2";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad3)
                {
                    e.SuppressKeyPress = true;
                    txtCliente.Text = txtCliente.Text + "3";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad4)
                {
                    e.SuppressKeyPress = true;
                    txtCliente.Text = txtCliente.Text + "4";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad5)
                {
                    e.SuppressKeyPress = true;
                    txtCliente.Text = txtCliente.Text + "5";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad6)
                {
                    e.SuppressKeyPress = true;
                    txtCliente.Text = txtCliente.Text + "6";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad7)
                {
                    e.SuppressKeyPress = true;
                    txtCliente.Text = txtCliente.Text + "7";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad8)
                {
                    e.SuppressKeyPress = true;
                    txtCliente.Text = txtCliente.Text + "8";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad9)
                {
                    e.SuppressKeyPress = true;
                    txtCliente.Text = txtCliente.Text + "9";
                    btnCancelar.Focus();
                }

            }

        }

        private void teclasMes(KeyEventArgs e)
        {
            if (txtMes.Text.Length < 2)
            {

                if (e.KeyCode == Keys.NumPad0)
                {
                    e.SuppressKeyPress = true;
                    txtMes.Text = txtMes.Text + "0";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad1)
                {
                    e.SuppressKeyPress = true;
                    txtMes.Text = txtMes.Text + "1";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad2)
                {
                    e.SuppressKeyPress = true;
                    txtMes.Text = txtMes.Text + "2";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad3)
                {
                    e.SuppressKeyPress = true;
                    txtMes.Text = txtMes.Text + "3";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad4)
                {
                    e.SuppressKeyPress = true;
                    txtMes.Text = txtMes.Text + "4";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad5)
                {
                    e.SuppressKeyPress = true;
                    txtMes.Text = txtMes.Text + "5";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad6)
                {
                    e.SuppressKeyPress = true;
                    txtMes.Text = txtMes.Text + "6";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad7)
                {
                    e.SuppressKeyPress = true;
                    txtMes.Text = txtMes.Text + "7";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad8)
                {
                    e.SuppressKeyPress = true;
                    txtMes.Text = txtMes.Text + "8";
                    btnCancelar.Focus();
                }

                if (e.KeyCode == Keys.NumPad9)
                {
                    e.SuppressKeyPress = true;
                    txtMes.Text = txtMes.Text + "9";
                    btnCancelar.Focus();
                }

            }

            if (txtMes.Text.Length > 0)
            if (Convert.ToInt16(txtMes.Text) > 12)
                txtMes.Clear();

        }

        private void teclasMonto(KeyEventArgs e)
        {
            if (txtMonto.Text.Length < 7)
            {

                if (e.KeyCode == Keys.NumPad0)
                {
                    e.SuppressKeyPress = true;
                    txtMonto.Text = txtMonto.Text + "0";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad1)
                {
                    e.SuppressKeyPress = true;
                    txtMonto.Text = txtMonto.Text + "1";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad2)
                {
                    e.SuppressKeyPress = true;
                    txtMonto.Text = txtMonto.Text + "2";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad3)
                {
                    e.SuppressKeyPress = true;
                    txtMonto.Text = txtMonto.Text + "3";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad4)
                {
                    e.SuppressKeyPress = true;
                    txtMonto.Text = txtMonto.Text + "4";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad5)
                {
                    e.SuppressKeyPress = true;
                    txtMonto.Text = txtMonto.Text + "5";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad6)
                {
                    e.SuppressKeyPress = true;
                    txtMonto.Text = txtMonto.Text + "6";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad7)
                {
                    e.SuppressKeyPress = true;
                    txtMonto.Text = txtMonto.Text + "7";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad8)
                {
                    e.SuppressKeyPress = true;
                    txtMonto.Text = txtMonto.Text + "8";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad9)
                {
                    e.SuppressKeyPress = true;
                    txtMonto.Text = txtMonto.Text + "9";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.Decimal)
                {
                    e.SuppressKeyPress = true;
                    if (txtMonto.Text.Contains(",") == false)
                    {
                        if (txtMonto.Text.Length == 0)
                        {
                            txtMonto.Text = txtMonto.Text + "0,";
                        }
                        else
                        {
                            txtMonto.Text = txtMonto.Text + ",";
                        }
                    }
                }
            }

        }


     # endregion


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text.Length > 0 && txtMes.Text.Length > 0 && txtMonto.Text.Length > 0)
            {
                btnAceptar.Enabled = false;
                btnCancelar.Enabled = false;
                txtCliente.Enabled = false;
                txtMes.Enabled = false;
                txtMonto.Enabled = false;

                CONTROLADORA.ControladoraMensuales.AgregarPagoMensual(oMensual, Convert.ToInt32(txtMes.Text), Convert.ToDecimal(txtMonto.Text));
                timerConfirmacion.Enabled = true;
            }
        }


        private void error()
        {
            timerError.Enabled = true;
            txtCliente.Clear();

        }

        private void timerError_Tick(object sender, EventArgs e)
        {
            if (parpadeo)
            {
                countParpadeo++;
                lblError.Visible = true;
                parpadeo = false;
            }
            else
            {
                countParpadeo++;
                lblError.Visible = false;
                parpadeo = true;
            }
            if (countParpadeo == 10)
            {
                lblError.Visible = false;
                countParpadeo = 0;
                timerError.Enabled = false;

            }
        }

        private void timerConfirmacion_Tick(object sender, EventArgs e)
        {

                countParpadeo++;
                lblConfirmacion.Visible = true;
                btnAceptar.Enabled = false;
                btnCancelar.Enabled = false;
                txtCliente.Enabled = false;
                txtMes.Enabled = false;
                txtMonto.Enabled = false;

            if (countParpadeo == 7)
            {
                Close();
            }
        }

        private void frmPagoMensual_Load(object sender, EventArgs e)
        {

        }


    }
}
