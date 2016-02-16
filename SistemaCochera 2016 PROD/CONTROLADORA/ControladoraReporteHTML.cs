using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONTROLADORA
{
    public class ControladoraReporteHTML
    {
        public static string report_string = "";

        public static string ReporteGananciasMensual(string mes, string ano)
        {

            List<MODELO.Caja> oCajas = MODELO.Contexto.ObtenerInstancia().Cajas.ToList();

            if (Convert.ToInt32(mes) > 0)
                oCajas = oCajas.Where(x => x.FechaHoraApertura.Value.Month == Convert.ToInt32(mes)).ToList();

            if (ano != "")
                oCajas = oCajas.Where(x => x.FechaHoraApertura.Value.Year == Convert.ToInt32(ano)).ToList();

            
            if (oCajas.Count != 0)
            {
                report_string = GenerarCodigo(oCajas);
            }
            else
            {
                report_string += "NO HAY DATOS<br/>";
            }
            return report_string;
        }

        public static string ReporteGananciasPeriodo(string desde, string hasta)
        {

            List<MODELO.Caja> oCajas = MODELO.Contexto.ObtenerInstancia().Cajas.ToList();

            oCajas = oCajas.Where(x => x.FechaHoraApertura.Value > Convert.ToDateTime(desde) && x.FechaHoraApertura.Value < Convert.ToDateTime(hasta)).ToList();

            if (oCajas.Count != 0)
            {
                report_string = GenerarCodigo(oCajas);

            }
            else
            {
                report_string += "NO HAY DATOS<br/>";
            }
            return report_string;
        }

        public static string GenerarCodigo(List<MODELO.Caja> oCajas)
        {
            string report_string = "";

            decimal total = oCajas.Sum(x => x.TotalNeto);
            decimal totalDescuentos = oCajas.Sum(x => x.TotalDescuentos);
            int vehiculos = oCajas.Sum(x => x.Vehiculo.Count);
            decimal cajamax = oCajas.Max(x => x.TotalNeto);
            decimal cajamin = oCajas.Min(x => x.TotalNeto);
            decimal cajaprom = Math.Round(oCajas.Average(x => x.TotalNeto), 2);
            int vehiculosMax = oCajas.Max(x => x.Vehiculo.Count);
            int vehiculosMin = oCajas.Min(x => x.Vehiculo.Count);
            double vehiculosProm = Math.Round(oCajas.Average(x => x.Vehiculo.Count), 2);

            report_string += "<br/>\r\n";
            report_string += "<b>TOTAL RECAUDADO: $ " + total + "</b><br/><br/>";
            report_string += "Caja Máxima: $ " + cajamax + "<br/>";
            report_string += "Caja Mínima: $ " + cajamin + "<br/>";
            report_string += "Caja Promedio: $ " + cajaprom + "<br/><br/>";
            report_string += "Total Descuentos Aplicados: $ " + totalDescuentos + "<br/><br/>";
            report_string += "TOTAL VEHÍCULOS: " + vehiculos + "<br/>";
            report_string += "Vehículos Máximo: " + vehiculosMax + "<br/>";
            report_string += "Vehículos Mínimo: " + vehiculosMin + "<br/>";
            report_string += "Vehículos Promedio: " + vehiculosProm + "<br/>";

            return report_string;
        }
    }
}
