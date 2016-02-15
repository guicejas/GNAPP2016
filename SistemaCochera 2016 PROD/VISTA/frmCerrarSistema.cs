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
    public partial class frmCerrarSistema : Form
    {
        bool parpadeo = true;
        int countParpadeo = 0;

        MODELO.Sistema miSistema;

        public frmCerrarSistema()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigoSeguridad.Focus();

            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            txtCodigoSeguridad.Focus();

            if (miSistema.CheckCodigoCerrar)
            {
                string pass = miSistema.CodigoCierre.ToString();
                if (txtCodigoSeguridad.Text == pass)
                {
                    Application.ExitThread();
                }
                else
                {
                    error();
                }
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void error()
        {
            timerError.Enabled = true;
            txtCodigoSeguridad.Clear();

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

        private void txtCodigoSeguridad_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoSeguridad.Text != "")
            {
                lblError.Visible = false;
                countParpadeo = 0;
                timerError.Enabled = false;
            }
        }

        private void txtCodigoSeguridad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                e.SuppressKeyPress = true;
                btnSalir_Click(null, null);
            }


            if (e.KeyCode == Keys.Divide)
            {
                e.SuppressKeyPress = true;
                btnCancelar_Click(null, null);
            }
        }

        private void frmCerrarSistema_Load(object sender, EventArgs e)
        {
            txtCodigoSeguridad.Focus();

            miSistema = CONTROLADORA.ControladoraSistema.Sistema();

            if (miSistema.CheckSiempreTOP)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }

            if (miSistema.CheckCodigoCerrar)
            {
                lblContraseña.Visible = true;
                txtCodigoSeguridad.Visible = true;
                txtCodigoSeguridad.Focus();

            }
            else
            {
                lblContraseña.Visible = false;
                txtCodigoSeguridad.Visible = false;
            }

            txtCodigoSeguridad.Focus();

        }

        private void frmCerrarSistema_KeyDown(object sender, KeyEventArgs e)
        {
            txtCodigoSeguridad.Focus();

            if (e.KeyCode == Keys.Add)
            {
                e.SuppressKeyPress = true;
                btnSalir_Click(null, null);
            }


            if (e.KeyCode == Keys.Divide)
            {
                e.SuppressKeyPress = true;
                btnCancelar_Click(null, null);
            }

        }
    }
}
