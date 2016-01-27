using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data;

namespace CONTROLADORA
{
    public class ControladoraMensuales
    {
        public static void AgregarMensual(MODELO.Mensual oMensual)
        {
            MODELO.Contexto.ObtenerInstancia().AddToMensuales(oMensual);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().DetectChanges();
        }

        public static void ModificarMensual(MODELO.Mensual oMensual)
        {
            MODELO.Contexto.ObtenerInstancia().Mensuales.ApplyCurrentValues(oMensual);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
        }

        public static List<MODELO.Mensual> ListarMensuales()
        {
            List<MODELO.Mensual> lista = MODELO.Contexto.ObtenerInstancia().Mensuales.Where(x => x.Activo == true).ToList();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, lista);
            return lista;
        }

        public static void DesactivarMensual(int oMensualId)
        {
            MODELO.Mensual oMensual = MODELO.Contexto.ObtenerInstancia().Mensuales.FirstOrDefault(x => x.id == oMensualId);
            oMensual.Activo = false;
            MODELO.Contexto.ObtenerInstancia().Mensuales.ApplyCurrentValues(oMensual);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
        }



        public static List<MODELO.PagoMensual> ListarPagosMensuales(MODELO.Mensual oMensual)
        {
            List<MODELO.PagoMensual> lista = MODELO.Contexto.ObtenerInstancia().PagoMensuales.Where(x => x.Mensual.id == oMensual.id).OrderByDescending(m => m.id).ToList();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, lista);
            return lista;
        }


        public static MODELO.Mensual BuscarMensual(int codigo)
        {
       
            MODELO.Mensual oMensual = MODELO.Contexto.ObtenerInstancia().Mensuales.Where(x => x.Activo == true).FirstOrDefault(c => c.Codigo == codigo);
            try
            {
                MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oMensual);
            }
            catch { }
            return oMensual;
        }

        public static void AgregarPagoMensual(MODELO.Mensual oMensual, int mes, decimal monto)
        {
            MODELO.PagoMensual oPagoMensual = new MODELO.PagoMensual();
            oPagoMensual.Monto = monto;
            oPagoMensual.Fecha = DateTime.Today;
            oPagoMensual.MesSaldado = mes;
            oPagoMensual.Mensual = oMensual;

            MODELO.Caja oCaja = CONTROLADORA.ControladoraCajas.BuscarCajaAbierta();
            oPagoMensual.Caja = oCaja;

            MODELO.Contexto.ObtenerInstancia().AddToPagoMensuales(oPagoMensual);

            oCaja.Total = oCaja.Total + oPagoMensual.Monto;

            MODELO.Contexto.ObtenerInstancia().Cajas.ApplyCurrentValues(oCaja);

            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().DetectChanges();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oPagoMensual);
        }

        public static void AgregarPagoMensualTransferencia(MODELO.Mensual oMensual, int mes, decimal monto, DateTime fecha)
        {
            MODELO.PagoMensual oPagoMensual = new MODELO.PagoMensual();
            oPagoMensual.Monto = monto;
            oPagoMensual.Fecha = fecha;
            oPagoMensual.MesSaldado = mes;
            oPagoMensual.Mensual = oMensual;

            //VER: CAJA DEBERIA SER NULL
            oPagoMensual.Caja.Id = 0;

            MODELO.Contexto.ObtenerInstancia().AddToPagoMensuales(oPagoMensual);

            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().DetectChanges();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oPagoMensual);
        }

        public static int ProximoCodigo()
        {
            MODELO.Mensual oMensual = MODELO.Contexto.ObtenerInstancia().Mensuales.OrderByDescending(m => m.id).FirstOrDefault();
            try
            {
                MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oMensual);
            }
            catch { }

            int proxCod = oMensual.Codigo + 1 ;

            return proxCod;
        }

        public static List<MODELO.Mensual> ListarMensualesFiltrados(string nombreyapellido, string patente, string razonsocial, string tipo)
        {
            List<MODELO.Mensual> Filtrado = MODELO.Contexto.ObtenerInstancia().Mensuales.Where(x => x.Activo == true).ToList();

            if (nombreyapellido != "")
                Filtrado = Filtrado.Where(v => v.NombreApellido.IndexOf(nombreyapellido, System.StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            if (patente != "")
                Filtrado = Filtrado.Where(oVeh => oVeh.Patente.IndexOf(patente, System.StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            if (razonsocial != "")
                Filtrado = Filtrado.Where(oVeh => oVeh.RazonSocial.IndexOf(razonsocial, System.StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            if (tipo != "TODOS")
                Filtrado = Filtrado.Where(oVeh => oVeh.TipoMensual == tipo).ToList();

            return Filtrado;
        }

    }
}
