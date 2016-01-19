using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MODELO
{
    public partial class Clase
    {
        public string CodigoDescripcion
        {
            get
            {
                return this.Codigo + "- " + this.Descripcion;
            }
        }


    }
}
