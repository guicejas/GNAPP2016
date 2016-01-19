using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmDescuento : Form
    {
        bool parpadeo = true;
        int countParpadeo = 0;

        public frmDescuento()
        {
            InitializeComponent();

            this.TopMost = true;

            btnAceptar.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   # region TECLADO

        private void frmDescuento_KeyDown(object sender, KeyEventArgs e)
        {
            btnAceptar.Focus();

            if (e.KeyCode == Keys.Add)
            {
                e.SuppressKeyPress = true;
                btnAceptar_Click(null, null);
            }

            if (e.KeyCode == Keys.Divide)
            {
                e.SuppressKeyPress = true;
                btnCancelar_Click(null, null);
            }

            if (txtTexto.TextLength < 8)
            {

                if (e.KeyCode == Keys.NumPad0)
                {
                    e.SuppressKeyPress = true;
                    txtTexto.Text = txtTexto.Text + "0";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad1)
                {
                    e.SuppressKeyPress = true;
                    txtTexto.Text = txtTexto.Text + "1";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad2)
                {
                    e.SuppressKeyPress = true;
                    txtTexto.Text = txtTexto.Text + "2";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad3)
                {
                    e.SuppressKeyPress = true;
                    txtTexto.Text = txtTexto.Text + "3";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad4)
                {
                    e.SuppressKeyPress = true;
                    txtTexto.Text = txtTexto.Text + "4";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad5)
                {
                    e.SuppressKeyPress = true;
                    txtTexto.Text = txtTexto.Text + "5";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad6)
                {
                    e.SuppressKeyPress = true;
                    txtTexto.Text = txtTexto.Text + "6";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad7)
                {
                    e.SuppressKeyPress = true;
                    txtTexto.Text = txtTexto.Text + "7";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad8)
                {
                    e.SuppressKeyPress = true;
                    txtTexto.Text = txtTexto.Text + "8";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.NumPad9)
                {
                    e.SuppressKeyPress = true;
                    txtTexto.Text = txtTexto.Text + "9";
                    btnAceptar.Focus();
                }

                if (e.KeyCode == Keys.Decimal)
                {
                    e.SuppressKeyPress = true;
                    if (txtTexto.Text.Contains(",") == false)
                    {
                        if (txtTexto.Text.Length == 0)
                        {
                            txtTexto.Text = txtTexto.Text + "0,";
                        }
                        else
                        {
                            txtTexto.Text = txtTexto.Text + ",";
                        }
                    }
                }
            }
        }

     # endregion


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text.Length > 0 && Convert.ToDecimal(txtTexto.Text) > 0)
            {
                btnAceptar.Focus();
                CONTROLADORA.ControladoraDescuentos.AgregarDescuento(Convert.ToDecimal(txtTexto.Text));
                timerConfirmacion.Enabled = true;
            }
            else
            {
                error();
            }
                

        }


        private void error()
        {
            timerError.Enabled = true;
            txtTexto.Clear();

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

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            if (txtTexto.Text != "")
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
            txtTexto.Enabled = false;

            if (countParpadeo == 7)
            {
                Close();
            }
        }


    }
}
