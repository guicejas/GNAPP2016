using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CONTROLADORA
{
    public class ControladoraReporteHTML
    {
        public static string report_string = "";

        public static string ReporteGananciasMensual(string mes, string ano)
        {
            string report_string = "";

            List<MODELO.Caja> oCajas = MODELO.Contexto.ObtenerInstancia().Cajas.ToList();

            if (Convert.ToInt32(mes) > 0)
                oCajas = oCajas.Where(x => x.FechaHoraApertura.Value.Month == Convert.ToInt32(mes)).ToList();

            if (ano != "")
                oCajas = oCajas.Where(x => x.FechaHoraApertura.Value.Year == Convert.ToInt32(ano)).ToList();

            
            if (oCajas.Count != 0)
            {
                report_string = GenerarCodigoGanancias(oCajas);
            }
            else
            {
                report_string = "NO HAY DATOS<br/>";
            }
            return report_string;
        }

        public static string ReporteGananciasPeriodo(string desde, string hasta, int detallado)
        {
            string report_string = "";

            List<MODELO.Caja> oCajas = MODELO.Contexto.ObtenerInstancia().Cajas.ToList();

            IFormatProvider culture = new CultureInfo("en-US", true);
            DateTime dtdesde = DateTime.ParseExact(desde, "dd/MM/yyyy", culture);
            DateTime dthasta = DateTime.ParseExact(hasta, "dd/MM/yyyy", culture);

            oCajas = oCajas.Where(x => x.FechaHoraApertura.Value.ToUniversalTime() >= dtdesde && x.FechaHoraApertura.Value.ToUniversalTime() <= dthasta).ToList();

            if (oCajas.Count != 0)
            {
                report_string += GenerarCodigoGanancias(oCajas);

                if (detallado == 1)
                {
                    //report_string += GenerarCodigoDetalladoGanancias(oCajas);
                      
                }

            }
            else
            {
                report_string = "NO HAY DATOS<br/>";
            }
            return report_string;
        }

        public static string GenerarCodigoGanancias(List<MODELO.Caja> oCajas)
        {
            string report_string = "";

            decimal total = oCajas.Sum(x => x.TotalNeto);
            decimal totalDescuentos = oCajas.Sum(x => x.TotalDescuentos);
            int vehiculos = oCajas.Sum(x => x.Vehiculo.Count);
            decimal cajamax = oCajas.Max(x => x.TotalNeto);
            decimal cajamin = oCajas.Where(x => x.TotalNeto > 0).Min(x => x.TotalNeto);
            decimal cajaprom = Math.Round(oCajas.Where(x => x.TotalNeto > 0).Average(x => x.TotalNeto), 2);
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

        public static string GenerarCodigoDetalladoGanancias(List<MODELO.Caja> oCajas)
        {
            string report_string = "";

            TimeSpan horamanana = TimeSpan.ParseExact("07", "hh", CultureInfo.InvariantCulture);
            TimeSpan horatarde = TimeSpan.ParseExact("15", "hh", CultureInfo.InvariantCulture);
            TimeSpan horanoche = TimeSpan.ParseExact("23", "hh", CultureInfo.InvariantCulture);


            List<MODELO.Caja> oCajasManana = oCajas.Where(x => x.FechaHoraApertura.Value.TimeOfDay.Hours >= horamanana.Hours && x.FechaHoraApertura.Value.TimeOfDay.Hours < horatarde.Hours).ToList();
            List<MODELO.Caja> oCajasTarde = oCajas.Where(x => x.FechaHoraApertura.Value.TimeOfDay.Hours >= horatarde.Hours && x.FechaHoraApertura.Value.TimeOfDay.Hours < horanoche.Hours).ToList();
            List<MODELO.Caja> oCajasNoche = oCajas.Where(x => x.FechaHoraApertura.Value.TimeOfDay.Hours >= horanoche.Hours && x.FechaHoraApertura.Value.TimeOfDay.Hours < horamanana.Hours).ToList();



            decimal total = oCajas.Sum(x => x.TotalNeto);
            decimal totalDescuentos = oCajas.Sum(x => x.TotalDescuentos);
            int vehiculos = oCajas.Sum(x => x.Vehiculo.Count);
            decimal cajamax = oCajas.Max(x => x.TotalNeto);
            decimal cajamin = oCajas.Where(x => x.TotalNeto > 0).Min(x => x.TotalNeto);
            decimal cajaprom = Math.Round(oCajas.Where(x => x.TotalNeto > 0).Average(x => x.TotalNeto), 2);
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

        public static string ReporteMensuales()
        {
            string report_string = "";

            List<MODELO.Mensual> oMensuales = MODELO.Contexto.ObtenerInstancia().Mensuales.Where(x => x.Activo == true).ToList();
            List<MODELO.Mensual> oMensualesPagaron = oMensuales.Where(x => (x.PagoMensual.Count > 0)).Where(x => x.PagoMensual.Last().MesSaldado == DateTime.Today.Month && x.PagoMensual.Last().Fecha.Year == DateTime.Today.Year).ToList();
            List<MODELO.Mensual> oMensualesDeben = oMensuales.Where(x => (x.PagoMensual.Count < 1) || (x.PagoMensual.Last().MesSaldado < DateTime.Today.Month && x.PagoMensual.Last().Fecha.Year == DateTime.Today.Year)).ToList();


            if (oMensualesDeben.Count != 0)
            {
                report_string += "<h4 class='text-danger'><b>Mensuales morosos</b></h4><table class='table table-striped table-hover'><thead><tr><th>#</th><th>Nombre y Apellido</th><th>Ultimo mes pago</th><th>Fecha de ultimo pago</th></tr></thead><tbody><tr>";
                report_string += GenerarCodigoMensuales(oMensualesDeben);
                report_string += "</tr></tbody></table>";
            }
            if (oMensualesPagaron.Count != 0)
            {
                report_string += "<h4 class='text-success'><b>Mensuales al dia</b></h4><table class='table table-striped table-hover'><thead><tr><th>#</th><th>Nombre y Apellido</th><th>Ultimo mes pago</th><th>Fecha de ultimo pago</th></tr></thead><tbody><tr>";
                report_string += GenerarCodigoMensuales(oMensualesPagaron.OrderByDescending(x => x.PagoMensual.LastOrDefault().Fecha).ToList());
                report_string += "</tr></tbody></table>";
            }
            else if (oMensualesPagaron.Count == 0)
            {
                report_string = "<br/>NO HAY DATOS<br/>";
            }
            return report_string;
        }

        public static string GenerarCodigoMensuales(List<MODELO.Mensual> oMensuales)
        {
            string report_string = "";


            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("es-ES");
            string MES = DateTime.ParseExact("2/01/01", "M/dd/yy", culture).ToString("MMMM", culture).ToUpper();

            for (int i = 0; i < oMensuales.Count; i++)
            {

                report_string += "<td>"+(i + 1) + "</td><td>" + oMensuales[i].NombreApellido.ToString()+"</td>";

                if (oMensuales[i].PagoMensual.Count > 0)
                {
                    object mes = oMensuales[i].PagoMensual.LastOrDefault().MesSaldado;
                    report_string += "<td>" + Convert.ToDateTime(mes+"/01/01").ToString("MMMM", culture).ToUpper() +" ("+mes+")"+ "</td>";
                    report_string += "<td>" + oMensuales[i].PagoMensual.LastOrDefault().Fecha.ToString("dd/MM/yyyy") + "</td>";
                    report_string += "<tr>";
                }
                else
                {
                    report_string += "<td></td>";
                    report_string += "<td></td>";
                    report_string += "<tr>";
                }

                
            } 
            
            return report_string;
        }

        public static void ReporteFacturacion()
        {
        }

    }
}
