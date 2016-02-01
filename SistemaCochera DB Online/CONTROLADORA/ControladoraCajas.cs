using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;


namespace CONTROLADORA
{
    public class ControladoraCajas
    {
        public static MODELO.Caja BuscarCajaAbierta()
        {
            MODELO.Caja oCaja = MODELO.Contexto.ObtenerInstancia().Cajas.FirstOrDefault(c => c.FechaHoraCierre == null);
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oCaja);
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oCaja.Descuento);
            return oCaja;
        }

        public static void CerrarCaja()
        {
            MODELO.Caja oCaja = MODELO.Contexto.ObtenerInstancia().Cajas.FirstOrDefault(c => c.FechaHoraCierre == null);
            oCaja.FechaHoraCierre = DateTime.Now;
            MODELO.Caja cajaNueva = new MODELO.Caja();

            ControladoraSistema.Sistema().NumeracionCajas++;
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().DetectChanges();
            cajaNueva.NroCaja = ControladoraSistema.Sistema().NumeracionCajas;
            

            cajaNueva.FechaHoraApertura = DateTime.Now;
            cajaNueva.Total = 0;

            MODELO.Contexto.ObtenerInstancia().AddToCajas(cajaNueva);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().DetectChanges();
        }

        public static List<MODELO.Caja> ListarCajas()
        {
            List<MODELO.Caja> lista = MODELO.Contexto.ObtenerInstancia().Cajas.OrderByDescending(c => c.Id).ToList();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, lista);
            return lista;
        }

        public static List<MODELO.Caja> ListarCajasFiltradas(string nroCaja, string estado, object AperturaDeste, object AperturaHasta, object CierreDesde, object CierreHasta)
        {
            List<MODELO.Caja> Filtrado = MODELO.Contexto.ObtenerInstancia().Cajas.ToList();

            if (nroCaja != "")
                Filtrado = Filtrado.Where(oCaj => oCaj.NroCaja.ToString()== nroCaja).ToList();
            if (estado != "Todos")
            {
                if (estado == "Abierta")
                Filtrado = Filtrado.Where(oCaj => oCaj.FechaHoraCierre == null).ToList();
                if (estado == "Cerrada")
                    Filtrado = Filtrado.Where(oCaj => oCaj.FechaHoraCierre != null).ToList();
            }

            if (AperturaDeste != null && AperturaHasta != null)
            {
                Filtrado = Filtrado.Where(oCaj => oCaj.FechaHoraApertura.Value.Date >= Convert.ToDateTime(AperturaDeste).Date).ToList();
                Filtrado = Filtrado.Where(oCaj => oCaj.FechaHoraApertura.Value.Date <= Convert.ToDateTime(AperturaHasta).Date).ToList();
            }

            if (CierreDesde != null && CierreHasta != null)
            {
                Filtrado = Filtrado.Where(oCaj => oCaj.FechaHoraCierre != null).Where(oCaj => oCaj.FechaHoraCierre.Value.Date >= Convert.ToDateTime(CierreDesde).Date).ToList();
                Filtrado = Filtrado.Where(oCaj => oCaj.FechaHoraCierre != null).Where(oCaj => oCaj.FechaHoraCierre.Value.Date <= Convert.ToDateTime(CierreHasta).Date).ToList();
            }

            return Filtrado;
        }

        public static List<MODELO.Caja> ListarCajasFiltradas(string nroCaja, string estado, string Apertura, string Cierre)
        {
            List<MODELO.Caja> Filtrado = MODELO.Contexto.ObtenerInstancia().Cajas.ToList();

            if (nroCaja != "")
                Filtrado = Filtrado.Where(oCaj => oCaj.NroCaja.Value.ToString().Contains(nroCaja)).ToList();

            if (estado != "Todos")
            {
                if (estado == "Abierta")
                    Filtrado = Filtrado.Where(oCaj => oCaj.FechaHoraCierre == null).ToList();
                if (estado == "Cerrada")
                    Filtrado = Filtrado.Where(oCaj => oCaj.FechaHoraCierre != null).ToList();
            }

            if (Apertura != "")
            {
                try
                {
                    Filtrado = Filtrado.Where(oCaj => oCaj.FechaHoraApertura.Value.Date == Convert.ToDateTime(Apertura)).ToList();
                }
                catch
                { }
            }

            if (Cierre != "")
            {
                try
                {
                    Filtrado = Filtrado.Where(oCaj => oCaj.FechaHoraCierre != null).Where(oCaj => oCaj.FechaHoraCierre.Value.Date >= Convert.ToDateTime(Cierre)).ToList();
                }
                catch
                { }
            }

            return Filtrado;
        }
        
    }
}
