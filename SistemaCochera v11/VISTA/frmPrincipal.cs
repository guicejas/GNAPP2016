using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CONTROLADORA;
using MODELO;
using System.Threading;

namespace VISTA
{
    public partial class frmPrincipal : Form
    {
        public string Modo = "";
        public string Tipeo = "";
        Vehiculo oVehiculo;
        bool parpadeo = true;
        int countParpadeo = 0;
        string oPatente;

        public MODELO.Sistema miSistema = ControladoraSistema.Sistema();



        public frmPrincipal()
        {
            InitializeComponent();
            this.MaximumSize = SystemInformation.PrimaryMonitorSize;
            this.Size = SystemInformation.PrimaryMonitorSize;
            validacionChecks();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            limpiarPantalla();
            btnFoco.Focus();
        }

        private void validacionChecks()
        {
            miSistema = ControladoraSistema.Sistema();

           if (miSistema.CheckSiempreMaximizado)
            {
                this.MaximizeBox = false;
                this.MinimumSize = SystemInformation.PrimaryMonitorSize;
            }
            else
            {
                this.MaximizeBox = true;
                this.MinimumSize = new System.Drawing.Size(811, 879);
           }

            if (miSistema.CheckSiempreTOP)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        

        private void limpiarPantalla()
        {
            gboxControles.Enabled = false;
            gboxControles.Visible = false;
            gboxNumeros.Enabled = false;

            btnControles.Enabled = true;
            btnCancelar.Enabled = false;

            //btnAdministracion.Enabled = true;
            btnIngreso.Enabled = true;
            btnSalida.Enabled = true;

            txtTexto.Clear();
            txtClase.Clear();
            btnIngreso.Text = "INGRESO";
            btnSalida.Text = "SALIDA";
            Modo = "";
            Tipeo = "";
            lblEstado.Text = "";
            lblPesos.Visible = false;

            timerCaja.Enabled = false;


            this.button1_Click(null, null); //TEMPORAL

            btnFoco.Focus();

        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();

        }

        private void timerEstado_Tick(object sender, EventArgs e)
        {
            gboxNumeros.Enabled = true;
            txtTexto.Clear();
            timerEstado.Enabled = false;

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

        private void timerCaja_Tick(object sender, EventArgs e)
        {
            txtTexto.Clear();
            lblEstado.Text = "";
            lblPesos.Visible = false;
            timerCaja.Enabled = false;

        }

# region TECLADO FISICO
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                e.SuppressKeyPress = true;
                btn0_Click(null, null);
            }

            if (e.KeyCode == Keys.NumPad1)
            {
                e.SuppressKeyPress = true;
                btn1_Click(null, null);
            }

            if (e.KeyCode == Keys.NumPad2)
            {
                e.SuppressKeyPress = true;
                btn2_Click(null, null);
            }

            if (e.KeyCode == Keys.NumPad3)
            {
                e.SuppressKeyPress = true;
                btn3_Click(null, null);
            }

            if (e.KeyCode == Keys.NumPad4)
            {
                e.SuppressKeyPress = true;
                btn4_Click(null, null);
            }

            if (e.KeyCode == Keys.NumPad5)
            {
                e.SuppressKeyPress = true;
                btn5_Click(null, null);
            }

            if (e.KeyCode == Keys.NumPad6)
            {
                e.SuppressKeyPress = true;
                btn6_Click(null, null);
            }

            if (e.KeyCode == Keys.NumPad7)
            {
                e.SuppressKeyPress = true;
                btn7_Click(null, null);
            }

            if (e.KeyCode == Keys.NumPad8)
            {
                e.SuppressKeyPress = true;
                btn8_Click(null, null);
            }

            if (e.KeyCode == Keys.NumPad9)
            {
                e.SuppressKeyPress = true;
                btn9_Click(null, null);
            }

            if (e.KeyCode == Keys.Decimal)
            {
                e.SuppressKeyPress = true;
                btnPunto_Click(null, null);
            }

            if (e.KeyCode == Keys.Add)
            {
                e.SuppressKeyPress = true;
                btnIngreso_Click(null, null);
            }

            if (e.KeyCode == Keys.Subtract)
            {
                e.SuppressKeyPress = true;
                btnSalida_Click(null, null);
            }

            if (e.KeyCode == Keys.Divide)
            {
                e.SuppressKeyPress = true;
                btnCancelar_Click(null, null);
            }

            if (e.KeyCode == Keys.Multiply)
            {
                e.SuppressKeyPress = true;
                if(btnControles.Enabled)
                btnControles_Click(null, null);
            }

        }
# endregion

# region BOTONES NUMERICOS
        private void btn0_Click(object sender, EventArgs e)
        {
            if (btn0.Enabled == true)
            {
                if (Tipeo != "Clase")
                {
                    txtTexto.Text = txtTexto.Text + "0";
                }
                else
                {
                    txtClase.Text = "0";
                }
            }

            if (btnAdministracion.Enabled == true)
            {
                btnAdministracion_Click(null, null);
            }
            btnFoco.Focus();
        }



        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (btnPunto.Enabled == true)
            {
                if (Tipeo == "Precio")
                {
                    

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
                else
                {
                    ;
                }
            }
            btnFoco.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Enabled == true)
            {

                if (Tipeo != "Clase")
                {
                    txtTexto.Text = txtTexto.Text + "1";

                }
                else
                {
                    txtClase.Text = "1";
                }
            }

            if (btnCantidadVechiculos.Enabled == true)
            {
                btnCantidad_Click(null, null);
            }
            btnFoco.Focus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Enabled == true)
            {
                if (Tipeo != "Clase")
                {
                    txtTexto.Text = txtTexto.Text + "2";
                }
                else
                {
                    txtClase.Text = "2";
                }
            }

            if (btnListado.Enabled == true)
            {
                btnListado_Click(null, null);
            }

            btnFoco.Focus();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Enabled == true)
            {
                if (Tipeo != "Clase")
                {
                    txtTexto.Text = txtTexto.Text + "3";
                }
                else
                {
                    txtClase.Text = "3";
                }
            }

            if (btnPagoMensuales.Enabled == true)
            {
                btnPagoMensuales_Click(null, null);
            }
            btnFoco.Focus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Enabled == true)
            {
                if (Tipeo != "Clase")
                {
                    txtTexto.Text = txtTexto.Text + "4";
                }
                else
                {
                    txtClase.Text = "4";
                }
            }

            if (btnCajaParcial.Enabled == true)
            {
                btnCaja_Click(null, null);
            }

            btnFoco.Focus();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Enabled == true)
            {
                if (Tipeo != "Clase")
                {
                    txtTexto.Text = txtTexto.Text + "5";
                }
                else
                {
                    txtClase.Text = "5";
                }
            }

            if (btnListadoMovimientos.Enabled == true)
            {
                btnListadoMovimientos_Click(null, null);
            }

            btnFoco.Focus();

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Enabled == true)
            {
                if (Tipeo != "Clase")
                {
                    txtTexto.Text = txtTexto.Text + "6";
                }
                else
                {
                    txtClase.Text = "6";
                }
            }

            if (btnDescuentos.Enabled == true)
            {
                btnDescuentos_Click(null, null);
            }
            btnFoco.Focus();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Enabled == true)
            {
                if (Tipeo != "Clase")
                {
                    txtTexto.Text = txtTexto.Text + "7";
                }
                else
                {
                    txtClase.Text = "7";
                }
            }
            if (btnCerrarCaja.Enabled == true)
            {
                btnCerrarCaja_Click(null, null);
            }

            btnFoco.Focus();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Enabled == true)
            {
                if (Tipeo != "Clase")
                {
                    txtTexto.Text = txtTexto.Text + "8";
                }
                else
                {
                    txtClase.Text = "8";
                }
            }
            if (btnListarEstadias.Enabled == true)
            {
                btnListarEstadias_Click(null, null);
            }

            btnFoco.Focus();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Enabled == true)
            {
                if (Tipeo != "Clase")
                {
                    txtTexto.Text = txtTexto.Text + "9";
                }
                else
                {
                    txtClase.Text = "9";
                }
            }

        }

# endregion


        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            if (Modo == "Ingreso")
            {
                if (Tipeo == "Patente")
                {
                    if (txtTexto.Text.Length == 3)
                    {
                        txtClase.Text = "?";
                        Tipeo = "Clase";
                        lblEstado.Text = "INGRESO | Introduzca la Clase";
                    }
                }

                if (Tipeo == "Precio")
                {



                    btnIngreso.Text = "ACEPTAR";

                    if (txtTexto.Text.Length > 0)
                    {
                        if (Convert.ToDecimal(txtTexto.Text) > 0)
                        {
                            lblEstado.Text = "INGRESO | ¿Aceptar ingreso?";
                            btnIngreso.Enabled = true;

                            if (txtTexto.Text.Contains(","))
                            {
                                if (txtTexto.Text.Substring(txtTexto.Text.IndexOf(",") + 1).Length > 1)
                                {
                                    gboxNumeros.Enabled = false;
                                }

                            }


                            if (txtTexto.Text.Length == 7)
                            {
                                gboxNumeros.Enabled = false;
                            }
                        }

                    }
                }

            }

            if (Modo == "Salida")
            {
                if (Tipeo == "Patente")
                {
                    if (txtTexto.Text.Length == 1)
                    {
                        txtTexto.Text = txtTexto.Text + " ";
                    }


                    if (txtTexto.Text.Length == 5)
                    {
                        //VALIDAR EXISTENTE
                        oVehiculo = ControladoraVehiculos.VerificarVehiculo(txtTexto.Text);
                        if (oVehiculo != null)
                        {

                            timerError.Enabled = false;
                            lblError.Visible = false;
                            countParpadeo = 0;
                            gboxNumeros.Enabled = false;
                            btnSalida.Enabled = true;
                            btnSalida.Text = "ACEPTAR";
                            Tipeo = "";

                            //  txtTexto.Text = "$14,00";
                            lblEstado.Text = "SALIDA | ¿Aceptar salida?";
                            return;
                        }
                        else
                        {
                            lblError.Text = "ERROR! VEHICULO INEXISTENTE";
                            timerError.Enabled = true;
                            //lblEstado.Text = "SALIDA | Introduzca numero de Patente     ERROR! VEHICULO INEXISTENTE";
                            gboxNumeros.Enabled = false;
                            timerEstado.Enabled = true;
                            return;
                        }

                    }
                }

            }

            btnFoco.Focus();
        }

        private void txtClase_TextChanged(object sender, EventArgs e)
        {
            if (Tipeo == "Clase")
            {
                if (txtClase.Text.Length == 1 && txtClase.Text != "?")
                {

                    // Es clase 9?
                    if (txtClase.Text == "9")
                    {
                        oPatente = txtTexto.Text;
                        lblEstado.Text = "INGRESO | Ingresar Precio";
                        Tipeo = "Precio";

                        lblPesos.Visible = true;
                        txtTexto.Clear();
                        return;
                    }

                    // VALIDANDO SI LA CLASE ES EXISTENTE
                    if (ControladoraClases.VerificarClase(txtClase.Text))
                    {
                        timerError.Enabled = false;
                        lblError.Visible = false;
                        countParpadeo = 0;
                        gboxNumeros.Enabled = false;
                        btnIngreso.Enabled = true;
                        btnIngreso.Text = "ACEPTAR";

                        lblEstado.Text = "INGRESO | ¿Aceptar ingreso?";

                    }
                    else
                    {
                        lblError.Text = "ERROR! CLASE INEXISTENTE";
                        timerError.Enabled = true;
                        txtClase.Text = "?";
                        return;
                    }




                }
            }

            btnFoco.Focus();
        }


        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (btnIngreso.Enabled == true)
            {
                if (btnIngreso.Text == "INGRESO")
                {
                    lblEstado.Text = "INGRESO | Introduzca numero de Patente";

                    gboxNumeros.Enabled = true;

                    btnCancelar.Enabled = true;

                    btnIngreso.Enabled = false;
                    btnSalida.Enabled = false;
                    btnControles.Enabled = false;

                    Modo = "Ingreso";
                    Tipeo = "Patente";
                };

                if (btnIngreso.Text == "ACEPTAR")
                {
                    oVehiculo = new Vehiculo();
                    oVehiculo.Clase = ControladoraClases.BuscarClase(txtClase.Text);
                    oVehiculo.FechaHoraEntrada = DateTime.Now;
                    ControladoraSistema.Sistema().NumeracionTickets++;
                    oVehiculo.NroTicket = ControladoraSistema.Sistema().NumeracionTickets.Value;
                    

                    if (Tipeo == "Precio")
                    {
                        //GENERAR INGRESO PARA CLASE 9 CON PRECIO

                        oVehiculo.Patente = oPatente;
                        oVehiculo.Precio = Convert.ToDecimal(txtTexto.Text);
                        oVehiculo.Caja = ControladoraCajas.BuscarCajaAbierta();
                        oVehiculo.Caja.Total += Convert.ToDecimal(oVehiculo.Precio.Value);
                        lblPesos.Visible = false;

                        //limpiarPantalla();

                    }
                    else
                    {
                        
                        oVehiculo.Patente = txtTexto.Text;


                    }

                    //GENERANDO INGRESO -->
                    oVehiculo.Estado = "Activo";
                    ControladoraVehiculos.GenerarEntradaVehiculo(oVehiculo);

                    //IMPRIMIR TICKET
                    if (oVehiculo.Clase.Codigo == "9") //CLASE 9
                    {

                        frmTelefonoEstadia ofrmTelefonoEstadia = new frmTelefonoEstadia(oVehiculo);
                        ofrmTelefonoEstadia.ShowDialog();

                         ControladoraImpresion.ImprimirTicketClase9(oVehiculo);                                  //IMPRESION
                         ControladoraImpresion.ImprimirTicketClase9Duplicado(oVehiculo);                         //IMPRESION
                    }
                    else // CLASE COMUN
                    {
                         ControladoraImpresion.ImprimirTicketEntrada(oVehiculo);                                 //IMPRESION
                    }

                    limpiarPantalla();

                }


                
            }
            btnFoco.Focus();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (btnSalida.Enabled == true)
            {
                if (btnSalida.Text == "SALIDA")
                {
                    lblEstado.Text = "SALIDA | Introduzca numero de Patente";

                    gboxNumeros.Enabled = true;
                    btnCancelar.Enabled = true;

                    btnIngreso.Enabled = false;
                    btnSalida.Enabled = false;
                    btnControles.Enabled = false;

                    Modo = "Salida";
                    Tipeo = "Patente";
                    return;
                }

                if (btnSalida.Text == "ACEPTAR")
                {
                    //GENERAR SALIDA

                    if (oVehiculo.Clase.Codigo == "9") // SALIDA PARA CLASE 9
                    {
                        
                        oVehiculo.FechaHoraSalida = DateTime.Now;

                    }
                    else // SALIDA PARA CLASE COMUN
                    {
                        // MOSTRAR PRECIO A PAGAR
                        lblPesos.Visible = true;
                        oVehiculo.FechaHoraSalida = DateTime.Now;
                        oVehiculo.Precio = CONTROLADORA.ControladoraFormulas.Truncar2decimales(oVehiculo.CalculaTarifa);
                        txtTexto.Text = oVehiculo.Precio.ToString();
                        oVehiculo.Caja = ControladoraCajas.BuscarCajaAbierta();
                        oVehiculo.Caja.Total += Convert.ToDecimal(oVehiculo.Precio);
                    }


                    CONTROLADORA.ControladoraVehiculos.GenerarSalidaVehiculo(oVehiculo);

                    lblEstado.Text = "SALIDA | ¿Imprimir ticket de salida?";

                    btnSalida.Text = "IMPRIMIR";

                    return;

                }

                if (btnSalida.Text == "IMPRIMIR")
                {
                    //IMPRIMIR TICKET DE SALIDA

                    lblPesos.Visible = false;
                    ControladoraImpresion.ImprimirTicketSalida(oVehiculo);
                    limpiarPantalla();
                    return;

                }
            }
            btnFoco.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }



        private void btnControles_Click(object sender, EventArgs e)
        {
            gboxControles.Enabled = true;
            gboxControles.Visible = true;
            gboxNumeros.Enabled = false;
            btnCancelar.Enabled = true;
            btnControles.Enabled = false;

            btnIngreso.Enabled = false;
            btnSalida.Enabled = false;
            //btnAdministracion.Enabled = false;

            lblEstado.Text = "CONTROLES | Seleccione una opción";

            Modo = "CONTROLES";

            btnFoco.Focus();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            lblPesos.Visible = true;
            decimal cajaparcial = ControladoraCajas.BuscarCajaAbierta().TotalNeto;
            txtTexto.Text = cajaparcial.ToString();
            lblEstado.Text = "CONTROLES | Caja parcial";
            timerCaja.Enabled = true;

            btnFoco.Focus();
           
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
            MODELO.Caja CajaAbierta = ControladoraCajas.BuscarCajaAbierta();
            List<MODELO.Vehiculo> VehiculosClase9 = ControladoraVehiculos.ListarVehiculosSalidaClase9(CajaAbierta);
            List<MODELO.Vehiculo> VehiculosComunes = ControladoraVehiculos.ListarVehiculosCajaActiva(CajaAbierta);
            ControladoraCajas.CerrarCaja();
            ControladoraImpresion.ImprimirCierreCaja(VehiculosComunes, VehiculosClase9, CajaAbierta);

            btnFoco.Focus();
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            lblPesos.Visible = false;
            txtTexto.Text = ControladoraVehiculos.CantAutosActivos().ToString();
            lblEstado.Text = "CONTROLES | Vehiculos en Playa";
            timerCaja.Enabled = true;

            btnFoco.Focus();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
            ControladoraImpresion.ImprimirVehiculosActivos(ControladoraVehiculos.ListarVehiculosActivos());
            btnFoco.Focus();
        }


        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
            frmLogin ofrmLogin = new frmLogin();
            ofrmLogin.ShowDialog();

            validacionChecks();

            btnFoco.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bdsLista.DataSource = CONTROLADORA.ControladoraVehiculos.ListarVehiculos();
            btnFoco.Focus();
        }

        private void btnListadoMovimientos_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
            MODELO.Caja CajaAbierta = ControladoraCajas.BuscarCajaAbierta();

            List<MODELO.Vehiculo> VehiculosClase9 = ControladoraVehiculos.ListarVehiculosSalidaClase9(CajaAbierta);
            List<MODELO.Vehiculo> VehiculosComunes = ControladoraVehiculos.ListarVehiculosCajaActiva(CajaAbierta);

            ControladoraImpresion.ImprimirMovimientosCaja(VehiculosComunes, VehiculosClase9, CajaAbierta);
            btnFoco.Focus();

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("¿Esta seguro que desea cerrar el sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}

            frmCerrarSistema ofrmCerrarSistema = new frmCerrarSistema();
            ofrmCerrarSistema.ShowDialog();
            
            e.Cancel = true;


        }

        private void btnPagoMensuales_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
            frmPagoMensual ofrmPagoMensual = new frmPagoMensual();
            ofrmPagoMensual.ShowDialog();

            validacionChecks();

            btnFoco.Focus();
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
            frmDescuento ofrmDescuento = new frmDescuento();
            ofrmDescuento.ShowDialog();

            btnFoco.Focus();
        }

        private void btnListarEstadias_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
            ControladoraImpresion.ImprimirEstadiasActivas(ControladoraVehiculos.ListarEstadiasActivas());
            btnFoco.Focus();
        }



    }
}
