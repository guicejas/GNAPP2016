using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONTROLADORA
{
    public class ControladoraFormulas
    {
        public static decimal Truncar2decimales(decimal numero)
        {
            decimal parte_decimal = 0, pasar_a_decimal = 0, resultado = 0;
            int parte_entera, separar_2_primeros_decimales;

            parte_entera = (int)numero;
            if (parte_entera != 0)
            {
                parte_decimal = numero % parte_entera;
                separar_2_primeros_decimales = (int)(parte_decimal * 100);
            }
            else
            {
                separar_2_primeros_decimales = (int)(numero * 100);
            }

            pasar_a_decimal = (decimal)separar_2_primeros_decimales / 100;
            resultado = (decimal)parte_entera + pasar_a_decimal;

            return (resultado);
        }

        public static double CalculaTiempo(TimeSpan tiempo)
        {
            double parte_decimal = 0, resultado = 0;
            int parte_entera;

            parte_entera = (int)tiempo.TotalHours;

            parte_decimal = tiempo.TotalHours - parte_entera;

            //pasar_a_decimal = parte_decimal / 100;

            if (parte_decimal >= 0.50)
            {
                resultado = parte_entera + 1;
            }
            if (parte_decimal == 0)
            {
                resultado = parte_entera;
            }
            if (parte_decimal < 0.50)
            {
                resultado = parte_entera + 0.5;
            }

            return resultado;
        }


    }
}
