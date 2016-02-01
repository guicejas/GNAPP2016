using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CONTROLADORA
{
    public class ControladoraSistema
    {
        public static MODELO.Sistema Sistema()
        {
            MODELO.Sistema oSistema = MODELO.Contexto.ObtenerInstancia().Sistemas.FirstOrDefault();
            return oSistema;
        }

        public static MODELO.Sistema TraerSistema()
        {
            MODELO.Sistema oSistema = MODELO.Contexto.ObtenerInstancia().Sistemas.FirstOrDefault();
            return oSistema;
        }

        public static void ModificarSistema(MODELO.Sistema oSistema)
        {
            MODELO.Contexto.ObtenerInstancia().Sistemas.ApplyCurrentValues(oSistema);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().DetectChanges();
        }
    }
}
