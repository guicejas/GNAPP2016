using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CONTROLADORA;

namespace VISTA
{
    public partial class frmMensuales : Form
    {
        MODELO.Mensual oMensual;

        public frmMensuales()
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
        }

        private void frmMensuales_Load(object sender, EventArgs e)
        {
            bdsMensuales.DataSource = null;
            lblSinResultados.Visible = false;
            cboxTipo.SelectedIndex = 0;

            txtNombreApellido.Clear();
            txtPatente.Clear();
            txtRazonSocial.Clear();
            cboxTipo.SelectedIndex = 0;

            ArmarGrilla();

        }

        private void ArmarGrilla()
        {
            bdsMensuales.DataSource = CONTROLADORA.ControladoraMensuales.ListarMensuales();
            lblResultados.Text = bdsMensuales.Count.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoMensual_Click(object sender, EventArgs e)
        {
            frmNuevoMensual ofrmNuevoMensual = new frmNuevoMensual();

            DialogResult drABIERTO = ofrmNuevoMensual.ShowDialog();
            if (drABIERTO == DialogResult.OK)
            {
                ArmarGrilla();
                MessageBox.Show("El Mensual se guardo correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (bdsMensuales.Current != null)
            {
                oMensual = (MODELO.Mensual)bdsMensuales.Current;

                frmNuevoMensual ofrmNuevoMensual = new frmNuevoMensual(oMensual);
                DialogResult drABIERTO = ofrmNuevoMensual.ShowDialog();
                if (drABIERTO == DialogResult.OK)
                {
                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Mensual", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (bdsMensuales.Current != null)
            {
                oMensual = (MODELO.Mensual)bdsMensuales.Current;

                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar al Mensual: " + oMensual.NombreApellido + " ?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    oMensual.Activo = false;
                    oMensual.FechaBaja = DateTime.Now;
                    CONTROLADORA.ControladoraMensuales.ModificarMensual(oMensual);

                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Mensual", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (bdsMensuales.Current != null)
            {
                oMensual = (MODELO.Mensual)bdsMensuales.Current;

                frmVerMensual ofrmVerMensual = new frmVerMensual(oMensual);
                DialogResult drABIERTO = ofrmVerMensual.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Mensual", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            frmMensuales_Load(null, null);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblSinResultados.Visible = false;

            string nombreyapellido = txtNombreApellido.Text.ToString();
            string patente = txtPatente.Text.ToString();
            string razonsocial = txtRazonSocial.Text.ToString();
            string tipo = cboxTipo.Text.ToString();

            bdsMensuales.DataSource = CONTROLADORA.ControladoraMensuales.ListarMensualesFiltrados(nombreyapellido, patente, razonsocial, tipo);

            lblResultados.Text = bdsMensuales.Count.ToString();
        }
    }
}
