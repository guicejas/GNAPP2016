using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MODELO
{
    public partial class PagoMensual
    {
        public string ImprimeFecha()
        {
            string dia = Fecha.Day.ToString();
            string mes = Fecha.Month.ToString();
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

        public string ImprimeHora()
        {
            string hora = Fecha.Hour.ToString();
            string minuto = Fecha.Minute.ToString();
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

        public int NroCaja
        {
            get
            {
                return (int)this.Caja.NroCaja;
            }
        }

        public string NombreYApellido
        {
            get
            {
                return this.Mensual.NombreApellido;
            }
        }
    }
}
