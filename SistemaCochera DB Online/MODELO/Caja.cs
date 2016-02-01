using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MODELO
{
    public partial class Caja
    {
        public string CantidadVehiculos
        {
            get
            {
                return this.Vehiculo.Count.ToString();
            }
        }

        public decimal TotalDescuentos
        {
            get
            {
                return this.Descuento.Sum(d => d.Monto);
            }
        }

        public decimal TotalNeto
        {
            get
            {
                
                return (this.Total - this.Descuento.Sum(d => d.Monto));
            }
        }


    }
}
