using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MODELO
{
    public partial class Vehiculo
    {
        public decimal CalculaTarifa
        {
            get
            {
                decimal total = 0;

                if ((this.FechaHoraSalida).HasValue == true)
                     
                {
                    TimeSpan tiempo = this.FechaHoraSalida.Value - this.FechaHoraEntrada;

                    if (tiempo.Minutes < this.Clase.MinutosTolerancia.Value)
                    {
                        return total;
                    }

                    decimal tiempoEnPlaya = Convert.ToDecimal(CalculaTiempo(tiempo));
                    decimal tiempoParaCambio = Convert.ToDecimal(this.Clase.TiempoCambioEstadia);


                    if (tiempoParaCambio == 0)
                    {
                        total = total + this.Clase.PrecioHora * tiempoEnPlaya;
                    }
                    else
                    {
                        while (tiempoEnPlaya > 0)
                        {
                            if (tiempoEnPlaya < tiempoParaCambio)
                            {
                                total = total + this.Clase.PrecioHora * tiempoEnPlaya;

                                tiempoEnPlaya = tiempoEnPlaya - tiempoParaCambio;
                            }

                            if (tiempoEnPlaya >= tiempoParaCambio && tiempoEnPlaya < 12)
                            {
                                total = total + this.Clase.PrecioMediaEstadia;   // ACA HAY QUE PONER EL PRECIO DE MEDIA ESTADIA

                                tiempoEnPlaya = tiempoEnPlaya - 12;
                            }

                            if (tiempoEnPlaya >= 12)
                            {
                                total = total + this.Clase.PrecioEstadia; // ACA HAY QUE PONER EL PRECIO DE ESTADIA COMPLETA

                                tiempoEnPlaya = tiempoEnPlaya - 24;
                            }
                        }
                    }
                }
                return total;
            }
        }

        public decimal CalculaTarifaExtra
        {
            get
            {
                //TimeSpan tiempo = this.FechaHoraSalida.Value - this.FechaHoraEntrada;

                //decimal div = Convert.ToDecimal(this.Precio) / 80;

                //if (Convert.ToDecimal(this.Precio) % 70 == 1) // CHATA
                //{
                //}


                decimal total = 0; //this.Clase.PrecioHora * Convert.ToDecimal(CalculaTiempo(tiempo));

                return total;
            }
        }


        public string MuestraClase
        {
            get
            {
                return "C"+this.Clase.Codigo;
            }
        }

        public string MuestraCaja
        {
            get
            {
                if (this.Caja != null)
                    return this.Caja.Id.ToString();
                else
                    return null;
            }
        }

        public string DuplicadoPatente
        {
            get
            {
                return this._DuplicadoNro+"-"+this._Patente;
            }
        }

        //public string IdentificadorVehiculo
        //{
        //    get
        //    {
        //        return total;
        //    }


        //}

        public static double CalculaTiempo(TimeSpan tiempo)
        {
            double parte_decimal = 0, resultado = 0;
            int parte_entera;

            if (tiempo.TotalHours < 0.50) // Primera media hora
            {
                resultado = 0.50;
                return resultado;
            }

            parte_entera = (int)tiempo.TotalHours;

            parte_decimal = tiempo.TotalHours - parte_entera;

            if (parte_decimal == 0)
            {
                resultado = parte_entera;
                return resultado;
            }

            if (parte_decimal <= 0.25)
            {
                resultado = parte_entera + 0.25;
                return resultado;
            }

            if (parte_decimal > 0.25 && parte_decimal <= 0.50)
            {
                resultado = parte_entera + 0.50;
                return resultado;
            }

            if (parte_decimal > 0.50 && parte_decimal <= 0.75)
            {
                resultado = parte_entera + 0.75;
                return resultado;
            }

            if (parte_decimal > 0.75)
            {
                resultado = parte_entera + 1;
                return resultado;
            }

            return resultado;
        }

        public string ImprimeFechaE()
        {
            string dia = FechaHoraEntrada.Day.ToString();
            string mes = FechaHoraEntrada.Month.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            return dia + "/" + mes;
        }

        public string ImprimeFechaS()
        {
            if (FechaHoraSalida != null)
            {

                string dia = FechaHoraSalida.Value.Day.ToString();
                string mes = FechaHoraSalida.Value.Month.ToString();
                if (dia.Length == 1)
                {
                    dia = "0" + dia;
                }
                if (mes.Length == 1)
                {
                    mes = "0" + mes;
                }
                return dia + "/" + mes;
            }
            else
            {
                return "--/--";
            }
        }

        public string ImprimeHoraE()
        {
            string hora = FechaHoraEntrada.Hour.ToString();
            string minuto = FechaHoraEntrada.Minute.ToString();
            if (hora.Length == 1)
            {
                hora = "0" + hora;
            }
            if (minuto.Length == 1)
            {
                minuto = "0" + minuto;
            }
            return hora + ":" + minuto;
        }

        public string ImprimeHoraS()
        {
            if (FechaHoraSalida != null)
            {
                string hora = FechaHoraSalida.Value.Hour.ToString();
                string minuto = FechaHoraSalida.Value.Minute.ToString();
                if (hora.Length == 1)
                {
                    hora = "0" + hora;
                }
                if (minuto.Length == 1)
                {
                    minuto = "0" + minuto;
                }
                return hora + ":" + minuto;
            }

            else
            {
                return "--:--";
            }
        }

    }
}
