using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Configuration;


using CONTROLADORA;

namespace APPWEB.Garage
{
    public partial class index : System.Web.UI.Page
    {
        int var = CONTROLADORA.ControladoraVehiculos.ActualizarDatosModelo();

        double auto = CONTROLADORA.ControladoraVehiculos.CantidadAutosActivos();
        double chata = CONTROLADORA.ControladoraVehiculos.CantidadChatasActivos();
        double moto = CONTROLADORA.ControladoraVehiculos.CantidadMotosActivos();
        double otro = CONTROLADORA.ControladoraVehiculos.CantidadOtrosActivos();
        double estadia = CONTROLADORA.ControladoraVehiculos.CantidadEstadiasActivos();
        double ocupado = CONTROLADORA.ControladoraVehiculos.CantAutosActivos();
        double total = 34;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                txtTotalVehiculos.InnerText = ocupado.ToString();

                if (ocupado > 25)
                { txtTotalVehiculos.Attributes.CssStyle.Value = "background-color: #ea2f10";
                txtLugaresDisponibles.Attributes.CssStyle.Value = "background-color: #ea2f10";
                }
                else if (ocupado > 15)
                { txtTotalVehiculos.Attributes.CssStyle.Value = "background-color: #d08002";
                txtLugaresDisponibles.Attributes.CssStyle.Value = "background-color: #d08002";
                }
                else
                { txtTotalVehiculos.Attributes.CssStyle.Value = "background-color: #3c9a5f";
                txtLugaresDisponibles.Attributes.CssStyle.Value = "background-color: #3c9a5f";
                };

                txtVehiculosHora.InnerText = (auto+chata+otro).ToString();
                txtVehiculosEstadia.InnerText = estadia.ToString();
                txtLugaresDisponibles.InnerText = (total - ocupado).ToString();

                cantidadAutos.InnerText = auto.ToString();
                cantidadChatas.InnerText = chata.ToString();
                cantidadMotos.InnerText = moto.ToString();
                cantidadOtros.InnerText = otro.ToString();
                cantidadEstadias.InnerText = estadia.ToString();

                txtDescuentos.InnerText = CONTROLADORA.ControladoraCajas.BuscarCajaAbierta().TotalDescuentos.ToString();
                txtcajaParcial.InnerText = CONTROLADORA.ControladoraCajas.BuscarCajaAbierta().TotalNeto.ToString();

                //string connectionString = WebConfigurationManager.ConnectionStrings["CocheraModeloContainerSQL"].ConnectionString;
                //SqlConnection con = new SqlConnection(connectionString);

                //// Lista Vehiculos activos
                //string selectSQL = "Select Clases.Codigo as 'Clase', FechaHoraEntrada as 'Entrada', DuplicadoNro + '-' + Patente as 'Patente' from Vehiculos inner join Clases on Vehiculos.Clase_id = Clases.id WHERE Vehiculos.Estado = 'Activo'";
                //SqlCommand cmd = new SqlCommand(selectSQL, con);
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //DataSet listVehiculos = new DataSet();
                //adapter.Fill(listVehiculos, "Vehiculos");
                //GridListaVehiculos.DataSource = listVehiculos;
                //GridListaVehiculos.DataBind();

                //// Lista movimientos de caja
                //selectSQL = "SELECT 'C'+ Clases.Codigo as 'Clase', Vehiculos.DuplicadoNro+'-'+Vehiculos.Patente as Vehiculo, Vehiculos.Precio as 'Importe', Vehiculos.FechaHoraEntrada as 'Entrada', Vehiculos.FechaHoraSalida as 'Salida' FROM vehiculos INNER JOIN cajas ON vehiculos.Caja_Id = cajas.Id INNER JOIN clases ON vehiculos.Clase_id = clases.id WHERE cajas.FechaHoraCierre is null ORDER BY vehiculos.FechaHoraSalida";
                ////SELECT NroCaja, Total as 'Recaudado', FechaHoraApertura as 'Apertura', FechaHoraCierre as 'Cierre' FROM Cajas
                //cmd = new SqlCommand(selectSQL, con);
                //adapter = new SqlDataAdapter(cmd);
                //DataSet listCajas = new DataSet();
                //adapter.Fill(listCajas, "Cajas");
                //GridCajaParcial.DataSource = listCajas;
                //GridCajaParcial.DataBind();

                GridListaVehiculos.DataSource = CONTROLADORA.ControladoraVehiculos.ListarVehiculosActivos();
                GridListaVehiculos.DataBind();

                GridCajaParcialX.DataSource = CONTROLADORA.ControladoraVehiculos.ListarVehiculosCajaActiva(CONTROLADORA.ControladoraCajas.BuscarCajaAbierta());
                GridCajaParcialX.DataBind();

                GridPagosMensualesCaja.DataSource = CONTROLADORA.ControladoraVehiculos.ListarPagosMensualesCajaActiva(CONTROLADORA.ControladoraCajas.BuscarCajaAbierta());
                GridPagosMensualesCaja.DataBind();

                ActualizarBarra();
            }

        }

        public void ActualizarBarra()
        {
            double porcAuto = 0;
            double porcChata = 0;
            double porcOtro = 0;
            double porcEstadia = 0;

            if (auto > 0)
            { porcAuto = Math.Truncate((auto * 100) / total); };
            if (chata > 0)
            { porcChata = Math.Truncate((chata * 100) / total); ; };
            if (otro > 0)
            { porcOtro = Math.Truncate((otro * 100) / total); ; };
            if (estadia > 0)
            { porcEstadia = Math.Truncate((estadia * 100) / total); ; };

            barraProgresoAutos.Attributes.CssStyle.Clear();
            barraProgresoAutos.Attributes.CssStyle.Value = "width: " + porcAuto.ToString().Replace(",", ".") + "%";
            //barraProgresoAutos.InnerText = porcAuto + "%";

            barraProgresoChatas.Attributes.CssStyle.Clear();
            barraProgresoChatas.Attributes.CssStyle.Value = "width: " + porcChata.ToString().Replace(",", ".") + "%";
            //barraProgresoChatas.InnerText = porcChata + "%";

            barraProgresoEstadias.Attributes.CssStyle.Clear();
            barraProgresoEstadias.Attributes.CssStyle.Value = "width: " + porcOtro.ToString().Replace(",", ".") + "%";
            //barraProgresoEstadias.InnerText = porcOtro + "%";

            barraProgresoEstadias.Attributes.CssStyle.Clear();
            barraProgresoEstadias.Attributes.CssStyle.Value = "width: " + porcEstadia.ToString().Replace(",", ".") + "%";
            //barraProgresoEstadias.InnerText = porcEstadia + "%";
        }
    }

}