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
    public partial class frmAdministracion : Form
    {
        bool parpadeo = true;
        int countParpadeo = 0;
        //MODELO.Impresion oImpresion;
        string accionClase;

        MODELO.Sistema miSistema = CONTROLADORA.ControladoraSistema.Sistema();

        public frmAdministracion()
        {
            InitializeComponent();
        }


        private void frmAdministracion_Load(object sender, EventArgs e)
        {
            if (CONTROLADORA.ControladoraSistema.Sistema().CheckSiempreTOP)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
            
            //TAB IMPRESORA
            txtNombreImpresora.Text = MODELO.Contexto.ObtenerInstancia().Sistemas.FirstOrDefault().NombreImpresora.ToString();

            //TAB CLASES
            bdsClases.Clear();
            bdsClases.DataSource = CONTROLADORA.ControladoraClases.ListarClases();

            //TAB IMPRESION
            bdsImpresiones.Clear();
            bdsImpresiones.DataSource = CONTROLADORA.ControladoraImpresion.ListarImpresiones();
            //bdsImpresiones_CurrentChanged(null, null);

            //TAB NUMERACION
            lblTicketActual.Text = "Ticket actual # " + CONTROLADORA.ControladoraSistema.Sistema().NumeracionTickets;
            lblCajaActual.Text = "Caja actual # " + CONTROLADORA.ControladoraSistema.Sistema().NumeracionCajas;

            //TAB AVANZADAS
            this.checkSiempreTop.Checked = miSistema.CheckSiempreTOP;
            this.checkSiempreMaximizado.Checked = miSistema.CheckSiempreMaximizado;
            this.checkCodigoSalir.Checked = miSistema.CheckCodigoCerrar;
        }


//MOVERSE DE TAB
        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(tabMenu.SelectedIndex == 1)
                btnCancelarClase_Click(null, null);
            if(tabMenu.SelectedIndex == 2)
                btnCancelarImpresion_Click(null, null);
            if(tabMenu.SelectedIndex == 4)
                btnCancelarImpresora_Click(null, null);
            if (tabMenu.SelectedIndex == 5)
            {
                btnCancelarPass_Click(null, null);
                btnCancelarCodigo_Click(null, null);
            }
            if(tabMenu.SelectedIndex == 6)
                btnCancelarAvanzadas_Click(null, null);
        }

//SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdministracion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Divide)
            {
                e.SuppressKeyPress = true;
                btnSalir_Click(null, null);
            }
        }

//TAB CONTRASEÑA
        #region TAB CONTRASEÑA
        private void Error(string tipoError)
        {
            lblEstadoContraseña.Text = tipoError;
            lblErrorContraseña.Visible = true;
            timerError.Enabled = true;
        }

        private void btnGuardarPass_Click(object sender, EventArgs e)
        {
            MODELO.Sistema oSistema = CONTROLADORA.ControladoraSistema.Sistema();

            if (txtPassActual.Text == "")
            {
                Error("Debe introducir la contraseña actual");
                return;
            }
            if (txtPassActual.Text != oSistema.password.ToString())
            {
                Error("La contraseña actual es incorrecta");
                return;
            }
            if (txtPassNuevo.Text == "")
            {
                Error("Debe introducir la nueva contraseña");
                return;
            }
            if (txtPassNuevo.Text.Length < 4)
            {
                Error("La nueva contraseña es demasiado corta. Debe contener entre 4 y 8 caracteres.");
                return;
            }
            if (txtPassNuevoRepite.Text == "")
            {
                Error("Debe repetir la nueva contraseña ");
                return;
            }
            if (txtPassNuevo.Text != txtPassNuevoRepite.Text)
            {
                Error("La nueva contraseña no coincide con la repetición");
                return;
            }

           
           oSistema.password = txtPassNuevo.Text;
           MODELO.Contexto.ObtenerInstancia().Sistemas.ApplyCurrentValues(oSistema);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();

            txtPassActual.Clear();
            txtPassNuevo.Clear();
            txtPassNuevoRepite.Clear();

            lblEstadoContraseña.Text = "Contraseña de administrador modificada correctamente.";

        }

        private void btnCancelarPass_Click(object sender, EventArgs e)
        {
            txtPassActual.Clear();
            txtPassNuevo.Clear();
            txtPassNuevoRepite.Clear();
            timerError.Enabled = false;
            countParpadeo = 0;
            lblErrorContraseña.Visible = false;
            lblEstadoContraseña.Text = "";
        }

        private void txtPassActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtPassNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtPassNuevoRepite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void timerError_Tick(object sender, EventArgs e)
        {
            if (parpadeo)
            {
                countParpadeo++;
                lblErrorContraseña.Visible = true;
                parpadeo = false;
            }
            else
            {
                countParpadeo++;
                lblErrorContraseña.Visible = false;
                parpadeo = true;
            }
            if (countParpadeo == 10)
            {
                lblErrorContraseña.Visible = false;
                countParpadeo = 0;
                timerError.Enabled = false;

            }
        }

// CODIGO
        private void btnGuardarCodigo_Click(object sender, EventArgs e)
        {
            MODELO.Sistema oSistema = CONTROLADORA.ControladoraSistema.Sistema();

            if (txtCodigoActual.Text == "")
            {
                Error("Debe introducir el código actual");
                return;
            }
            if (txtCodigoActual.Text != oSistema.CodigoCierre.ToString())
            {
                Error("El código actual es incorrecta");
                return;
            }
            if (txtCodigoNuevo.Text == "")
            {
                Error("Debe introducir el nuevo código");
                return;
            }
            if (txtCodigoNuevo.Text.Length < 4)
            {
                Error("El nuevo código es demasiado corto. Debe contener entre 4 y 8 caracteres.");
                return;
            }
            if (txtCodigoNuevoRepite.Text == "")
            {
                Error("Debe repetir el nuevo código ");
                return;
            }
            if (txtCodigoNuevo.Text != txtCodigoNuevoRepite.Text)
            {
                Error("El nuevo código no coincide con la repetición");
                return;
            }


            oSistema.CodigoCierre = txtCodigoNuevo.Text;
            MODELO.Contexto.ObtenerInstancia().Sistemas.ApplyCurrentValues(oSistema);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();

            txtCodigoActual.Clear();
            txtCodigoNuevo.Clear();
            txtCodigoNuevoRepite.Clear();

            lblEstadoContraseña.Text = "Codigo de cierre modificado correctamente.";

        }

        private void btnCancelarCodigo_Click(object sender, EventArgs e)
        {
            txtCodigoActual.Clear();
            txtCodigoNuevo.Clear();
            txtCodigoNuevoRepite.Clear();
            timerError.Enabled = false;
            countParpadeo = 0;
            lblErrorContraseña.Visible = false;
            lblEstadoContraseña.Text = "";

        }

        #endregion

//TAB IMPRESORA
        #region TAB IMPRESORA
        private void btnEditarImpresora_Click(object sender, EventArgs e)
        {
            btnEditarImpresora.Enabled = false;
            btnResetearImpresora.Enabled = false;
            btnGuardarImpresora.Visible = true;
            btnCancelarImpresora.Visible = true;
            txtNombreImpresora.Enabled = true;
        }

        private void btnCancelarImpresora_Click(object sender, EventArgs e)
        {
            txtNombreImpresora.Text = MODELO.Contexto.ObtenerInstancia().Sistemas.FirstOrDefault().NombreImpresora.ToString();
            btnEditarImpresora.Enabled = true;
            btnResetearImpresora.Enabled = true;
            btnGuardarImpresora.Visible = false;
            btnCancelarImpresora.Visible = false;
            txtNombreImpresora.Enabled = false;
        }

        private void btnResetearImpresora_Click(object sender, EventArgs e)
        {
            txtNombreImpresora.Text = "EPSON TM-T88V Receipt";
            MODELO.Contexto.ObtenerInstancia().Sistemas.FirstOrDefault().NombreImpresora = txtNombreImpresora.Text;
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
        }

        private void btnGuardarImpresora_Click(object sender, EventArgs e)
        {
            MODELO.Contexto.ObtenerInstancia().Sistemas.FirstOrDefault().NombreImpresora = txtNombreImpresora.Text;
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            btnEditarImpresora.Enabled = true;
            btnResetearImpresora.Enabled = true;
            btnGuardarImpresora.Visible = false;
            btnCancelarImpresora.Visible = false;
            txtNombreImpresora.Enabled = false;
        }
        #endregion

//TAB IMPRESIONES
        #region TAB IMPRESIONES
        private void bdsImpresiones_CurrentChanged(object sender, EventArgs e)
        {
            if (bdsImpresiones.Current != null)
            {
                MODELO.Impresion oImpresion = (MODELO.Impresion)bdsImpresiones.Current;

                MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oImpresion);

                txtEncabezado1.Text = oImpresion.Encabezado1.ToString();
                txtEncabezado2.Text = oImpresion.Encabezado2.ToString();
                txtEncabezado3.Text = oImpresion.Encabezado3.ToString();
                txtEncabezado4.Text = oImpresion.Encabezado4.ToString();
                txtEncabezado5.Text = oImpresion.Encabezado5.ToString();

                txtPie1.Text = oImpresion.Pie1.ToString();
                txtPie2.Text = oImpresion.Pie2.ToString();
                txtPie3.Text = oImpresion.Pie3.ToString();
                txtPie4.Text = oImpresion.Pie4.ToString();
                txtPie5.Text = oImpresion.Pie5.ToString();


            }

        }

        private void btnEditarImpresion_Click(object sender, EventArgs e)
        {
            cboxImpresion.Enabled = false;

            gboxEncabezadoImpresion.Enabled = true;
            gboxPieImpresion.Enabled = true;

            btnCancelarImpresion.Visible = true;
            btnGuardarImpresion.Visible = true;
           // btnPruebaImpresion.Visible = true;

            btnEditarImpresion.Enabled = false;
        }

        private void btnCancelarImpresion_Click(object sender, EventArgs e)
        {
            cboxImpresion.Enabled = true;

            gboxEncabezadoImpresion.Enabled = false;
            gboxPieImpresion.Enabled = false;

            btnCancelarImpresion.Visible = false;
            btnGuardarImpresion.Visible = false;
            //btnPruebaImpresion.Visible = false;

            btnEditarImpresion.Enabled = true;

            bdsImpresiones_CurrentChanged(null, null);
        }


        private void btnGuardarImpresion_Click(object sender, EventArgs e)
        {
            MODELO.Impresion oImpresion = (MODELO.Impresion)bdsImpresiones.Current;

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

            btnCancelarImpresion_Click(null, null);

            cboxImpresion.SelectedItem = oImpresion;


        }

        private void btnPruebaImpresion_Click(object sender, EventArgs e)
        {
            CONTROLADORA.ControladoraImpresion.ImprimirTicketPrueba(txtEncabezado1.Text, txtEncabezado2.Text, txtEncabezado3.Text, txtEncabezado4.Text, txtEncabezado5.Text, txtPie1.Text, txtPie2.Text, txtPie3.Text, txtPie4.Text, txtPie5.Text);
        }
        #endregion

//TAB CLASES
        #region TAB CLASES
        private void bdsClases_CurrentChanged(object sender, EventArgs e)
        {
            if (bdsClases.Current != null)
            {
                MODELO.Clase oClase = (MODELO.Clase)bdsClases.Current;
                //var refreshableObjects = MODELO.Contexto.ObtenerInstancia().ChangeTracker.Entries().Select(c => c.Entity).ToList();
                MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oClase);
                //MODELO.Contexto.ObtenerInstancia().ObjectStateManager.ChangeObjectState(oClase, System.Data.EntityState.Modified);

                txtCodigoClase.Text = oClase.Codigo.ToString();
                txtDescripcionClase.Text = oClase.Descripcion.ToString();
                txtPrecioHoraClase.Text = oClase.PrecioHora.ToString();
                txtPrecio12hsClase.Text = oClase.PrecioMediaEstadia.ToString();
                txtPrecio24hsClase.Text = oClase.PrecioEstadia.ToString();
                txtCambioEstadiaClase.Text = oClase.TiempoCambioEstadia.ToString();
                txtToleranciaClase.Text = oClase.MinutosTolerancia.ToString();

            }
            else
            {
                txtCodigoClase.Clear();
                txtDescripcionClase.Clear();
                txtPrecioHoraClase.Clear();
                txtPrecio12hsClase.Clear();
                txtPrecio24hsClase.Clear();
                txtCambioEstadiaClase.Clear();
                txtToleranciaClase.Clear();
            }
        }

        private void btnNuevaClase_Click(object sender, EventArgs e)
        {
            accionClase = "NUEVA";

            cboxClase.Enabled = false;

            btnGuardarClase.Visible = true;
            btnCancelarClase.Visible = true;

            gboxClase.Enabled = true;
            txtCodigoClase.Clear();
            txtDescripcionClase.Clear();
            txtPrecioHoraClase.Clear();
            txtPrecio12hsClase.Clear();
            txtPrecio24hsClase.Clear();
            txtCambioEstadiaClase.Text = "5";
            txtToleranciaClase.Text = "0";

            btnNuevaClase.Enabled = false;
            btnEditarClase.Enabled = false;
            btnEliminarClase.Enabled = false;
        }

        private void btnEditarClase_Click(object sender, EventArgs e)
        {
            if (bdsClases.Current != null)
            {
                accionClase = "EDITA";

                cboxClase.Enabled = false;

                btnGuardarClase.Visible = true;
                btnCancelarClase.Visible = true;

                gboxClase.Enabled = true;

                btnNuevaClase.Enabled = false;
                btnEditarClase.Enabled = false;
                btnEliminarClase.Enabled = false;
            }
        }


        private void btnCancelarClase_Click(object sender, EventArgs e)
        {
            gboxClase.Enabled = false;
            btnCancelarClase.Visible = false;
            btnGuardarClase.Visible = false;

            cboxClase.Enabled = true;
            btnEditarClase.Enabled = true;
            btnNuevaClase.Enabled = true;
            btnEliminarClase.Enabled = true;

            bdsClases_CurrentChanged(null, null);
        }

        private void btnEliminarClase_Click(object sender, EventArgs e)
        {
            if (bdsClases.Current != null)
            {
                MODELO.Clase oClase = (MODELO.Clase)bdsClases.Current;
                oClase.Activo = false;
                CONTROLADORA.ControladoraClases.ModificarClase(oClase);

                bdsClases.Clear();
                bdsClases.DataSource = CONTROLADORA.ControladoraClases.ListarClases();
            }
            btnCancelarClase_Click(null, null);
        }

        private void btnGuardarClase_Click(object sender, EventArgs e)
        {
            MODELO.Clase oClase = (MODELO.Clase)bdsClases.Current;
            //validaciones
            if (validacionesClases(oClase))
            {

                if (accionClase == "EDITA")
                {

                    oClase.Codigo = txtCodigoClase.Text;
                    oClase.Descripcion = txtDescripcionClase.Text;
                    oClase.PrecioHora = Convert.ToDecimal(txtPrecioHoraClase.Text);
                    oClase.PrecioMediaEstadia = Convert.ToDecimal(txtPrecio12hsClase.Text);
                    oClase.PrecioEstadia = Convert.ToDecimal(txtPrecio24hsClase.Text);
                    oClase.TiempoCambioEstadia = Convert.ToInt32(txtCambioEstadiaClase.Text);
                    oClase.MinutosTolerancia = Convert.ToInt32(txtToleranciaClase.Text);

                    CONTROLADORA.ControladoraClases.ModificarClase(oClase);

                    btnCancelarClase_Click(null, null);

                    bdsClases.Clear();
                    bdsClases.DataSource = CONTROLADORA.ControladoraClases.ListarClases();

                    cboxClase.SelectedItem = oClase;
                }


                if (accionClase == "NUEVA")
                {
                    MODELO.Clase newClase = new MODELO.Clase();

                    newClase.Activo = true;
                    newClase.Codigo = txtCodigoClase.Text;
                    newClase.Descripcion = txtDescripcionClase.Text;
                    newClase.PrecioHora = Convert.ToDecimal(txtPrecioHoraClase.Text);
                    newClase.PrecioMediaEstadia = Convert.ToDecimal(txtPrecio12hsClase.Text);
                    newClase.PrecioEstadia = Convert.ToDecimal(txtPrecio24hsClase.Text);
                    newClase.TiempoCambioEstadia = Convert.ToInt32(txtCambioEstadiaClase.Text);
                    newClase.MinutosTolerancia = Convert.ToInt32(txtToleranciaClase.Text);

                    CONTROLADORA.ControladoraClases.AgregarClase(newClase);

                    btnCancelarClase_Click(null, null);

                    bdsClases.Clear();
                    bdsClases.DataSource = CONTROLADORA.ControladoraClases.ListarClases();

                    cboxClase.SelectedItem = newClase;
                }
            }

        }


        private bool validacionesClases(MODELO.Clase oClase)
        {
            if (txtCodigoClase.Text == "")
            {
                MessageBox.Show("Debe ingresar el codigo para la clase.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPrecioHoraClase.Text == "")
            {
                MessageBox.Show("Debe ingresar el precio por hora para la clase.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPrecio12hsClase.Text == "")
            {
                MessageBox.Show("Debe ingresar el precio por 12hs para la clase.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPrecio24hsClase.Text == "")
            {
                MessageBox.Show("Debe ingresar el precio por 24hs para la clase.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCambioEstadiaClase.Text == "")
            {
                MessageBox.Show("Debe ingresar la hora de cambio de precio a 1/2 estadia para la clase.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtToleranciaClase.Text == "")
            {
                MessageBox.Show("Debe ingresar la tolerancia para la clase.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (accionClase == "NUEVA") // Si es esta dando de alta una clase nueva
            {
                if (CONTROLADORA.ControladoraClases.BuscarClase(txtCodigoClase.Text) != null)
                {
                    MessageBox.Show("El código que ingreso ya pertenece a otra clase.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (accionClase == "EDITA" && oClase.Codigo != txtCodigoClase.Text) // Si es esta modificando una clase y modifico el codigo
            {
                if (CONTROLADORA.ControladoraClases.BuscarClase(txtCodigoClase.Text) != null)
                {
                    MessageBox.Show("El código que ingreso ya pertenece a otra clase.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            try
            {
                Convert.ToInt32(txtCodigoClase.Text);
            }
            catch
            {
                MessageBox.Show("El codigo de la clase debe estar comprendido entre 1 y 8", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                Convert.ToDecimal(txtPrecioHoraClase.Text);
            }
            catch
            {
                MessageBox.Show("El precio por hora es incorrecto. Ingreselo en formato $xx,xx", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                Convert.ToDecimal(txtPrecio12hsClase.Text);
            }
            catch
            {
                MessageBox.Show("El precio por estadia de 12hs es incorrecto. Ingreselo en formato $xx,xx", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                Convert.ToDecimal(txtPrecio24hsClase.Text);
            }
            catch
            {
                MessageBox.Show("El precio por estadia de 24hs es incorrecto. Ingreselo en formato $xx,xx", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                Convert.ToInt32(txtCambioEstadiaClase.Text);
            }
            catch
            {
                MessageBox.Show("El tiempo de cambio debe ser numerico y entero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                Convert.ToInt32(txtToleranciaClase.Text);
            }
            catch
            {
                MessageBox.Show("El tiempo de tolerancia debe ser numerico y entero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true;
        }


        private void txtPrecioHoraClase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46 && e.KeyChar != 44)
                e.Handled = true;
            if (e.KeyChar == 46)
                e.KeyChar = (char)44;
            if (e.KeyChar == 46 && txtPrecioHoraClase.Text.IndexOf(',') >= 0)
                e.Handled = true;
            if (e.KeyChar == 44 && txtPrecioHoraClase.Text.IndexOf(',') >= 0)
                e.Handled = true;
        }

        private void txtPrecio12hsClase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46 && e.KeyChar != 44)
                e.Handled = true;
            if (e.KeyChar == 46)
                e.KeyChar = (char)44;
            if (e.KeyChar == 46 && txtPrecio12hsClase.Text.IndexOf(',') >= 0)
                e.Handled = true;
            if (e.KeyChar == 44 && txtPrecio12hsClase.Text.IndexOf(',') >= 0)
                e.Handled = true;
        }

        private void txtPrecio24hsClase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46 && e.KeyChar != 44)
                e.Handled = true;
            if (e.KeyChar == 46)
                e.KeyChar = (char)44;
            if (e.KeyChar == 46 && txtPrecio24hsClase.Text.IndexOf(',') >= 0)
                e.Handled = true;
            if (e.KeyChar == 44 && txtPrecio24hsClase.Text.IndexOf(',') >= 0)
                e.Handled = true;
        }

        private void txtCambioEstadiaClase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtToleranciaClase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtCodigoClase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 57)
            {
                e.KeyChar = (char)65;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        #endregion

//TAB NUMERACION
        #region TAB NUMERACION
        private void btnReiniciarTickets_Click(object sender, EventArgs e)
        {
            MODELO.Sistema oSistema = CONTROLADORA.ControladoraSistema.Sistema();

            oSistema.NumeracionTickets = 0;
            MODELO.Contexto.ObtenerInstancia().Sistemas.ApplyCurrentValues(oSistema);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().DetectChanges();

            lblTicketActual.Text = "Ticket actual # " + CONTROLADORA.ControladoraSistema.Sistema().NumeracionTickets;

        }

        private void btnReiniciarCajas_Click(object sender, EventArgs e)
        {
            MODELO.Sistema oSistema = CONTROLADORA.ControladoraSistema.Sistema();

            oSistema.NumeracionCajas = 0;

            MODELO.Contexto.ObtenerInstancia().Sistemas.ApplyCurrentValues(oSistema);
            MODELO.Contexto.ObtenerInstancia().DetectChanges();
            MODELO.Contexto.ObtenerInstancia().SaveChanges();

            lblCajaActual.Text = "Caja actual # " + CONTROLADORA.ControladoraSistema.Sistema().NumeracionCajas;
        }
        #endregion

//TAB BUSCAR
        #region TAB BUSCAR
        private void btnListadoVehiculos_Click(object sender, EventArgs e)
        {
                frmListadoVehiculos ofrmListadoVehiculos = new frmListadoVehiculos();
                ofrmListadoVehiculos.ShowDialog();
        }

        private void btnListadoCajas_Click(object sender, EventArgs e)
        {
            frmListadoCajas ofrmListadoCajas = new frmListadoCajas();
            ofrmListadoCajas.ShowDialog();
        }

        private void btnTop10Ganancias_Click(object sender, EventArgs e)
        {
            frmTopGanancias ofrmTopGanancias = new frmTopGanancias();
            ofrmTopGanancias.ShowDialog();
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            frmGanancias ofrmGanancias = new frmGanancias();
            ofrmGanancias.ShowDialog();
        }

        private void btnMensuales_Click(object sender, EventArgs e)
        {
            frmMensuales ofrmMensuales = new frmMensuales();
            ofrmMensuales.ShowDialog();
        }
        #endregion

//TAB AVANZADAS
        #region TAB AVANZADAS
        private void btnGuardarAvanzadas_Click(object sender, EventArgs e)
        {
            miSistema.CheckSiempreTOP = this.checkSiempreTop.Checked;
            miSistema.CheckSiempreMaximizado = this.checkSiempreMaximizado.Checked;
            miSistema.CheckCodigoCerrar = this.checkCodigoSalir.Checked;

            CONTROLADORA.ControladoraSistema.ModificarSistema(miSistema);

            lblEstadoAvanzadas.Text = "Cambios guardados correctamente";
        }

        private void btnCancelarAvanzadas_Click(object sender, EventArgs e)
        {
            this.checkSiempreTop.Checked = miSistema.CheckSiempreTOP;
            this.checkSiempreMaximizado.Checked = miSistema.CheckSiempreMaximizado;
            this.checkCodigoSalir.Checked = miSistema.CheckCodigoCerrar;

            lblEstadoAvanzadas.Text = "";
        }

        private void btnResetearAvanzadas_Click(object sender, EventArgs e)
        {
            this.checkSiempreTop.Checked = true;
            this.checkSiempreMaximizado.Checked = true;
            this.checkCodigoSalir.Checked = true;

        }

        #endregion










    }
}
