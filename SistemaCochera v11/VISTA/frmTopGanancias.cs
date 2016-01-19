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
    public partial class frmTopGanancias : Form
    {
        public frmTopGanancias()
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

        private void frmTopGanancias_Load(object sender, EventArgs e)
        {
            bdsCajasTop.DataSource = MODELO.Contexto.ObtenerInstancia().Cajas.OrderByDescending(x=> x.Total).Take(10);

            DataGridViewRowCollection grilla = dgridCajasTOP.Rows;
            for (int i = 0; i < 11; i++)
                grilla[i].SetValues(i+1);
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
