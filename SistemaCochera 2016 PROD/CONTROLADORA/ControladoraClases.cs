using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data;



namespace CONTROLADORA
{
    public class ControladoraClases
    {
        public static MODELO.Clase BuscarClase(string codigo)
        {
            MODELO.Clase oClase = MODELO.Contexto.ObtenerInstancia().Clases.Where(x=> x.Activo == true).FirstOrDefault(c => c.Codigo == codigo);
            try
            {
                MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oClase);
            }
            catch { }
            return oClase;
        }

        public static bool VerificarClase(string codigo)
        {
            List<MODELO.Clase> Lista = MODELO.Contexto.ObtenerInstancia().Clases.Where(x => x.Activo == true).Where(c => c.Codigo == codigo).ToList();

            if (Lista.Count > 0)
            {
                return true;
            }
            return false;
        }

        public static List<MODELO.Clase> ListarClases()
        {
            return MODELO.Contexto.ObtenerInstancia().Clases.Where(x => x.Activo == true).Where(x => x.Codigo != "9").OrderBy(c => c.Codigo).ToList();
        }

        public static void AgregarClase(MODELO.Clase oClase)
        {
            MODELO.Contexto.ObtenerInstancia().AddToClases(oClase);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().DetectChanges();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oClase);
            //  oVehiculo.NroTicket = oVehiculo.id;
        }
        public static void ModificarClase(MODELO.Clase oClase)
        {
            MODELO.Contexto.ObtenerInstancia().Clases.ApplyCurrentValues(oClase);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oClase);
        }
    }
}
