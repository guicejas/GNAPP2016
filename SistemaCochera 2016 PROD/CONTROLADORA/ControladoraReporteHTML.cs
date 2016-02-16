using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONTROLADORA
{
    class ControladoraReporteHTML
    {
        static string report_string = ""; // class level variable

        static string ReporteGanancias(string mes, string ano)
        {
            List<MODELO.Caja> oCajas = MODELO.Contexto.ObtenerInstancia().Cajas.ToList();

            if (Convert.ToInt32(mes) > 0)
                oCajas = oCajas.Where(x => x.FechaHoraApertura.Value.Month == Convert.ToInt32(mes)).ToList();

            if (ano != "")
                oCajas = oCajas.Where(x => x.FechaHoraApertura.Value.Year == Convert.ToInt32(ano)).ToList();

            
            if (oCajas.Count != 0)
            {
                decimal total = oCajas.Sum(x => x.TotalNeto);
                //lblTotalR.Text = "$" + total.ToString();

                //lblCajasR.Text = oCajas.Count.ToString();

                int vehiculos = oCajas.Sum(x => x.Vehiculo.Count);
                //lblVehiculosR.Text = vehiculos.ToString();

                decimal cajamax = oCajas.Max(x => x.TotalNeto);
                //lblCajaMaximaR.Text = "$" + cajamax.ToString();

                decimal cajamin = oCajas.Min(x => x.TotalNeto);
                //lblCajaMinimaR.Text = "$" + cajamin.ToString();

                decimal cajaprom = oCajas.Average(x => x.TotalNeto);
                //lblCajaPromedioR.Text = "$" + (Math.Round(cajaprom, 2)).ToString();
                
                int vehiculosMax = oCajas.Max(x => x.Vehiculo.Count);
                //lblVehiculosMaxR.Text = vehiculosMax.ToString();

                int vehiculosMin = oCajas.Min(x => x.Vehiculo.Count);
                //lblVehiculosMinR.Text = vehiculosMin.ToString();

                double vehiculosProm = oCajas.Average(x => x.Vehiculo.Count);
                //lblVehiculosPromR.Text = Convert.ToInt32(vehiculosProm).ToString();
            }
            else
            {
                //lblTotalR.Text = "-";
                //lblCajasR.Text = "-";
                //lblVehiculosR.Text = "-";
                //lblCajaMaximaR.Text = "-";
                //lblCajaMinimaR.Text = "-";
                //lblCajaPromedioR.Text = "-";
                //lblVehiculosMaxR.Text = "-";
                //lblVehiculosMinR.Text = "-";
                //lblVehiculosPromR.Text = "-";

                //lblSinResultados.Visible = true;
            }

                report_string += "<br/>\r\n";
                report_string += "&nbsp;&nbsp;" + "Parent:" + "&nbsp;&nbsp;" + row["Parent"] + "<br/>";

        }
    }
}
