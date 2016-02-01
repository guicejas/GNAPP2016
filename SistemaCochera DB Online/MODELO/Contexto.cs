using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MODELO
{
    public class Contexto
    {
        private static CocheraModeloContainer Instancia = null;

        private Contexto()
        { }

        public static CocheraModeloContainer ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new CocheraModeloContainer();
            }

            return Instancia;
        }
    }
}
