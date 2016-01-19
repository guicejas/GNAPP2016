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
    public partial class frmTelefonoEstadia : Form
    {
        bool parpadeo = true;
        int countParpadeo = 0;
        MODELO.Vehiculo oVehiculo;

        public frmTelefonoEstadia(MODELO.Vehiculo miVehiculo)
        {
            InitializeComponent();

            this.TopMost = true;

            oVehiculo = miVehiculo;

            btnAceptar.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text.Length > 0)
            {
                btnAceptar.Focus();
                oVehiculo.Telefono = txtTexto.Text;
                CONTROLADORA.ControladoraVehiculos.ModificarVehiculo(oVehiculo);

                this.Close();
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



        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            lblError.Visible = false;
            countParpadeo = 0;
            timerError.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        # region TECLADO

        private void frmTelefonoMensual_KeyDown(object sender, KeyEventArgs e)
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

            if (e.KeyCode == Keys.Subtract)
            {
                e.SuppressKeyPress = true;
                btnBorrar_Click(null, null);
            }

            if (txtTexto.TextLength < 25)
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
                    txtTexto.Text = txtTexto.Text + " - ";
                    btnAceptar.Focus();
                }

            }
        }

        # endregion
    }
}
