using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data;

namespace CONTROLADORA
{
   public class ControladoraDescuentos
    {
        public static void AgregarDescuento(decimal monto)
        {
            MODELO.Descuento oDescuento = new MODELO.Descuento();
            oDescuento.Monto = monto;
            
            MODELO.Caja oCaja = CONTROLADORA.ControladoraCajas.BuscarCajaAbierta();
            oCaja.Descuento.Add(oDescuento);

            MODELO.Contexto.ObtenerInstancia().AddToDescuentos(oDescuento);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().DetectChanges();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oDescuento);
        }
    }
}
