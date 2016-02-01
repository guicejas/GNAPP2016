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
    public partial class frmLogin : Form
    {
        bool parpadeo = true;
        int countParpadeo = 0;

        public frmLogin()
        {
            InitializeComponent();

            if (CONTROLADORA.ControladoraSistema.Sistema().CheckSiempreTOP)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }

            txtPassword.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            txtPassword.Focus();
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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
            string pass = CONTROLADORA.ControladoraSistema.Sistema().password.ToString();
            if (txtPassword.Text == pass)
            {
                frmAdministracion ofrmAdministracion = new frmAdministracion();
                this.Hide();
                ofrmAdministracion.ShowDialog();
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
            txtPassword.Clear();

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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                lblError.Visible = false;
                countParpadeo = 0;
                timerError.Enabled = false;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();



        }


    }
}
