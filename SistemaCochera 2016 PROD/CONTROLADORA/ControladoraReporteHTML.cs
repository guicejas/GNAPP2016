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

        public static string ReporteGananciasMensual(string mes, string ano, string detallado)
        {
            string report_string = "";

            List<MODELO.Caja> oCajas = MODELO.Contexto.ObtenerInstancia().Cajas.ToList();

            if (Convert.ToInt32(mes) > 0)
                oCajas = oCajas.Where(x => x.FechaHoraApertura.Value.Month == Convert.ToInt32(mes)).ToList();

            if (ano != "")
                oCajas = oCajas.Where(x => x.FechaHoraApertura.Value.Year == Convert.ToInt32(ano)).ToList();

            
            if (oCajas.Count != 0)
            {
                report_string += "<table>";
                report_string += GenerarCodigoGanancias(oCajas);
                report_string += GenerarCodigoDetalladoGanancias(oCajas);
                
                //if (detallado == "1")
                //{
                    
                //}

                report_string += "</table>";
            }
            else
            {
                report_string = "NO HAY DATOS<br/>";
            }
            return report_string;
        }

        public static string ReporteGananciasPeriodo(string desde, string hasta, string detallado)
        {
            string report_string = "";

            List<MODELO.Caja> oCajas = MODELO.Contexto.ObtenerInstancia().Cajas.ToList();

            IFormatProvider culture = new CultureInfo("en-US", true);
            DateTime dtdesde = DateTime.ParseExact(desde, "dd/MM/yyyy", culture);
            DateTime dthasta = DateTime.ParseExact(hasta, "dd/MM/yyyy", culture);

            oCajas = oCajas.Where(x => x.FechaHoraApertura.Value.ToUniversalTime() >= dtdesde && x.FechaHoraApertura.Value.ToUniversalTime() <= dthasta).ToList();

            if (oCajas.Count != 0)
            {
                report_string += "<table>";
                report_string += GenerarCodigoGanancias(oCajas);
                report_string += GenerarCodigoDetalladoGanancias(oCajas);

                //if (detallado == "1")
                //{
                    
                //}
                report_string += "</table>";
            }
            else
            {
                report_string = "NO HAY DATOS<br/>";
            }
            return report_string;
        }

        public static string GenerarCodigoGanancias(List<MODELO.Caja> oCajas)
        {
            string report_string = "<tr><td colspan='3'>";

            decimal total = oCajas.Sum(x => x.TotalNeto);
            decimal totalDescuentos = oCajas.Sum(x => x.TotalDescuentos);
            int vehiculos = oCajas.Sum(x => x.Vehiculo.Count);
            decimal cajamax = oCajas.Max(x => x.TotalNeto);
            decimal cajamin = oCajas.Where(x => x.TotalNeto > 0).Min(x => x.TotalNeto);
            decimal cajaprom = Math.Round(oCajas.Where(x => x.TotalNeto > 0).Average(x => x.TotalNeto), 2);
            int vehiculosMax = oCajas.Max(x => x.Vehiculo.Count);
            int vehiculosMin = oCajas.Min(x => x.Vehiculo.Count);
            double vehiculosProm = Math.Round(oCajas.Average(x => x.Vehiculo.Count), 2);
            decimal pagosmensuales = oCajas.Sum(x => x.PagoMensual.Sum(y => y.Monto));
            decimal xhora = oCajas.Sum(x => x.Vehiculo.Where(y => y.Clase.Codigo != "9").Sum(z => z.Precio).Value);
            decimal xestadia = oCajas.Sum(x => x.Vehiculo.Where(y => y.Clase.Codigo == "9").Sum(z => z.Precio).Value);
            report_string += "<div class='panel panel-default' style='margin-bottom: 0px'><div class='panel-body'>";
            report_string += "<p class='text-center'><b><h4>TOTAL RECAUDADO: $ " + total + "</b></h4></p>";
            report_string += "<table><tr>";
            report_string += "<td style='padding-right: 20px;'>Caja Máxima: $ " + cajamax + "</td>";
            report_string += "<td style='padding-right: 20px;'>Caja Mínima: $ " + cajamin + "</td>";
            report_string += "<td style='padding-right: 20px;'>Caja Promedio: $ " + cajaprom + "</td>";
            report_string += "</tr></table>";
            report_string += "<br />";
            report_string += "<table>";
            report_string += "<tr><td style='padding-right: 10px;'>Pagos de mensuales: </td><td>$ " + pagosmensuales + "</td></tr>";
            report_string += "<tr><td style='padding-right: 10px;'>Recaudacion por Hora: </td><td>$ " + xhora + "</td></tr>";
            report_string += "<tr><td style='padding-right: 10px;'>Recaudacion por Estadias: </td><td>$ " + xestadia + "</td></tr>";
            report_string += "<tr><td style='padding-right: 10px;'>Total Descuentos Aplicados: </td><td>($ " + totalDescuentos + " )</td></tr>";
            report_string += "</table><br/>";
            report_string += "<b>TOTAL VEHÍCULOS: " + vehiculos + "</b><br/>";
            report_string += "Vehículos Máximo: " + vehiculosMax + "<br/>";
            report_string += "Vehículos Mínimo: " + vehiculosMin + "<br/>";
            report_string += "Vehículos Promedio: " + vehiculosProm + "<br/>";

            report_string += "</div></div></td></tr>";
            return report_string;
        }

        public static string GenerarCodigoDetalladoGanancias(List<MODELO.Caja> oCajas)
        {
            string report_string = "";

            TimeSpan horamanana = TimeSpan.ParseExact("07", "hh", CultureInfo.InvariantCulture);
            TimeSpan horatarde = TimeSpan.ParseExact("15", "hh", CultureInfo.InvariantCulture);
            TimeSpan horanoche = TimeSpan.ParseExact("22", "hh", CultureInfo.InvariantCulture);

            report_string += "<tr>";

            List<MODELO.Caja> oCajasManana = oCajas.Where(x => x.FechaHoraApertura.Value.TimeOfDay.Hours >= horamanana.Hours && x.FechaHoraApertura.Value.TimeOfDay.Hours < horatarde.Hours).ToList();
            report_string += "<td>";
            decimal recaudacionmanana = oCajasManana.Sum(x => x.TotalNeto);
            decimal cajamaxmanana = oCajasManana.Max(x => x.TotalNeto);
            decimal cajaminmanana = oCajasManana.Where(x => x.TotalNeto > 0).Min(x => x.TotalNeto);
            decimal cajaprommanana = Math.Round(oCajasManana.Where(x => x.TotalNeto > 0).Average(x => x.TotalNeto), 2);
            int vehiculosmanana = oCajasManana.Sum(x => x.Vehiculo.Count);
            int estadiasmanana = oCajasManana.Sum(x => x.Vehiculo.Where(y => y.Clase.Codigo == "9").Count());
            int xhoramanana = oCajasManana.Sum(x => x.Vehiculo.Where(y => y.Clase.Codigo != "9").Count());
            decimal mensualesmanana = oCajasManana.Sum(x => x.PagoMensual.Sum(y => y.Monto));
            report_string += "<div class='panel panel-default'><div class='panel-heading'><h5><b>TURNOS DE MAÑANA</b></h5></div><div class='panel-body'>";
            report_string += "<b>TOTAL RECAUDADO: $ " + recaudacionmanana + "</b><br/>";
            report_string += "Caja Máxima: $ " + cajamaxmanana + "<br/>";
            report_string += "Caja Mínima: $ " + cajaminmanana + "<br/>";
            report_string += "Caja Promedio: $ " + cajaprommanana + "<br/><br/>";
            report_string += "Pagos de mensuales: $ " + mensualesmanana + "<br/><br/>";
            report_string += "<b>TOTAL VEHÍCULOS: " + vehiculosmanana + "</b><br/>";
            report_string += "Vehículos por Hora: " + xhoramanana + "<br/>";
            report_string += "Vehículos por Estadia: " + estadiasmanana + "</div></div><br/><br/>";
            
            List<MODELO.Caja> oCajasTarde = oCajas.Where(x => x.FechaHoraApertura.Value.TimeOfDay.Hours >= horatarde.Hours && x.FechaHoraApertura.Value.TimeOfDay.Hours < horanoche.Hours).ToList();
            report_string += "</td><td>";
            decimal recaudaciontarde = oCajasTarde.Sum(x => x.TotalNeto);
            decimal cajamaxtarde = oCajasTarde.Max(x => x.TotalNeto);
            decimal cajamintarde = oCajasTarde.Where(x => x.TotalNeto > 0).Min(x => x.TotalNeto);
            decimal cajapromtarde = Math.Round(oCajasTarde.Where(x => x.TotalNeto > 0).Average(x => x.TotalNeto), 2);
            int vehiculostarde = oCajasTarde.Sum(x => x.Vehiculo.Count);
            int estadiastarde = oCajasTarde.Sum(x => x.Vehiculo.Where(y => y.Clase.Codigo == "9").Count());
            int xhoratarde = oCajasTarde.Sum(x => x.Vehiculo.Where(y => y.Clase.Codigo != "9").Count());
            decimal mensualestarde = oCajasTarde.Sum(x => x.PagoMensual.Sum(y => y.Monto));
            report_string += "<div class='panel panel-default'><div class='panel-heading'><h5><b>TURNOS DE TARDE</b></h5></div><div class='panel-body'>";
            report_string += "<b>TOTAL RECAUDADO: $ " + recaudaciontarde + "</b><br/>";
            report_string += "Caja Máxima: $ " + cajamaxtarde + "<br/>";
            report_string += "Caja Mínima: $ " + cajamintarde + "<br/>";
            report_string += "Caja Promedio: $ " + cajapromtarde + "<br/><br/>";
            report_string += "Pagos de mensuales: $ " + mensualestarde + "<br/><br/>";
            report_string += "<b>TOTAL VEHÍCULOS: " + vehiculostarde + "</b><br/>";
            report_string += "Vehículos por Hora: " + xhoratarde + "<br/>";
            report_string += "Vehículos por Estadia: " + estadiastarde + "</div></div><br/><br/>";
            
            List<MODELO.Caja> oCajasNoche = oCajas.Where(x => x.FechaHoraApertura.Value.TimeOfDay.Hours >= horanoche.Hours || x.FechaHoraApertura.Value.TimeOfDay.Hours < horamanana.Hours).ToList();
            report_string += "</td><td>";
            decimal recaudacionnoche = oCajasNoche.Sum(x => x.TotalNeto);
            decimal cajamaxnoche = oCajasNoche.Max(x => x.TotalNeto);
            decimal cajaminnoche = oCajasNoche.Where(x => x.TotalNeto > 0).Min(x => x.TotalNeto);
            decimal cajapromnoche = Math.Round(oCajasNoche.Where(x => x.TotalNeto > 0).Average(x => x.TotalNeto), 2);
            int vehiculosnoche = oCajasNoche.Sum(x => x.Vehiculo.Count);
            int estadiasnoche = oCajasNoche.Sum(x => x.Vehiculo.Where(y => y.Clase.Codigo == "9").Count());
            int xhoranoche = oCajasNoche.Sum(x => x.Vehiculo.Where(y => y.Clase.Codigo != "9").Count());
            decimal mensualesnoche = oCajasNoche.Sum(x => x.PagoMensual.Sum(y => y.Monto));
            report_string += "<div class='panel panel-default'><div class='panel-heading'><h5><b>TURNOS DE NOCHE</b></h5></div><div class='panel-body'>";
            report_string += "<b>TOTAL RECAUDADO: $ " + recaudacionnoche + "</b><br/>";
            report_string += "Caja Máxima: $ " + cajamaxnoche + "<br/>";
            report_string += "Caja Mínima: $ " + cajaminnoche + "<br/>";
            report_string += "Caja Promedio: $ " + cajapromnoche + "<br/><br/>";
            report_string += "Pagos de mensuales: $ " + mensualesnoche + "<br/><br/>";
            report_string += "<b>TOTAL VEHÍCULOS: " + vehiculosnoche + "</b><br/>";
            report_string += "Vehículos por Hora: " + xhoranoche + "<br/>";
            report_string += "Vehículos por Estadia: " + estadiasnoche + "</div></div><br/><br/>";

            report_string += "</td></tr>";

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


        public static string ReporteFacturacion(string tipoMensual, string tipoFactura)
        {
            string report_string = "";

            List<MODELO.Mensual> oMensuales = MODELO.Contexto.ObtenerInstancia().Mensuales.Where(x=> x.Activo == true).OrderBy(x=> x.NombreApellido).ToList();

            if (tipoMensual != "TODOS")
            {
                oMensuales = oMensuales.Where(x => x.TipoMensual == tipoMensual).ToList();
            }
            if (tipoFactura != "TODOS")
            {
                oMensuales = oMensuales.Where(x => x.TipoFactura == tipoFactura).ToList();
            }

            report_string = GenerarCodigoFacturacion(oMensuales);

            return report_string;
               
        }


        public static string GenerarCodigoFacturacion(List<MODELO.Mensual> oMensuales)
        {
            string report_string = "";

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("es-ES");
            string MES = DateTime.ParseExact("2/01/01", "M/dd/yy", culture).ToString("MMMM", culture).ToUpper();

            for (int i = 0; i < oMensuales.Count; i++)
            {

                report_string += "<div class='panel panel-default'><div class='panel-heading'><h5> Cod: " + oMensuales[i].Codigo.ToString() + "  -  <b>" + oMensuales[i].NombreApellido.ToString().ToUpper() + "</b></h5></div><div class='panel-body'>";
                report_string += "<table><tr>";
                report_string += "<td colspan='2' style='padding-right: 20px;'><b>Mensualidad: </b>" + oMensuales[i].TipoMensual + "<br/>";
                report_string += "</tr><tr>";
                report_string += "<td style='padding-right: 20px;'><b>Domicilio: </b>" + oMensuales[i].Domicilio.ToUpper() + "<br/></td>";
                report_string += "<td style='padding-right: 20px;'><b>Telefono: </b>" + oMensuales[i].Telefono + "<br/></td>";
                report_string += "</tr></table><br/>";
                report_string += "<b>FACTURA: " + oMensuales[i].TipoFactura + "</b><br/>";
                if (oMensuales[i].RazonSocial != "")
                {
                    report_string += "<b>Razon Social: </b>" + oMensuales[i].RazonSocial.ToUpper() + "<br/>";
                }
                else
                {
                    report_string += "<b>Razon Social: </b>" + oMensuales[i].NombreApellido.ToUpper() + "<br/>";
                }
                if (oMensuales[i].DomicilioFiscal != "")
                {
                    report_string += "<b>Domicilio Fiscal: </b>" + oMensuales[i].DomicilioFiscal.ToUpper() + "<br/>";
                }
                else
                {
                    report_string += "<b>Domicilio Fiscal: </b>" + oMensuales[i].Domicilio.ToUpper() + "<br/>";
                }

                report_string += "<b>CUIT/CUIL: </b>" + oMensuales[i].CUIL + "<br/><br/>";
                report_string += "<b>IMPORTE: $ " + oMensuales[i].PrecioSugerido.Value.ToString("0.00") + "</b><br/><br/>";

                if (oMensuales[i].TipoFactura == "A")
                {
                    report_string += "<b>Importe sin IVA: </b>$ " + (oMensuales[i].PrecioSugerido.Value * (decimal)0.79).ToString("0.00") + "<br/>";
                    report_string += "<b>IVA: </b>$ " + (oMensuales[i].PrecioSugerido.Value * (decimal)0.21).ToString("0.00") + "<br/><br/>";
                }
                report_string += "<table><tr>";
                report_string += "<td style='padding-right: 20px;'><b>Vehiculo: </b>" + oMensuales[i].Vehiculo.ToUpper() + "<br/></td>";
                report_string += "<td style='padding-right: 20px;'><b>Patente: </b>" + oMensuales[i].Patente.ToUpper() + "<br/></td>";
                report_string += "</tr><tr>";
                report_string += "<td colspan='2' style='padding-right: 20px;'><b>Observaciones: </b>" + oMensuales[i].Observaciones.ToUpper() + "<br/><br/>";
                report_string += "</tr></table>";
                report_string += "<p class='text-right' style='font-size: 12px;'><b>Fecha de Alta: </b>" + oMensuales[i].FechaAlta.ToString("dd/MM/yyyy") + "</p></div></div><br/>";
            }

            return report_string;
        }



    }
}
