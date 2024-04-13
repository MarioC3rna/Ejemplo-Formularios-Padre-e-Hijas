using Clase9_de_13_de_abril.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_de_13_de_abril.ClaseHija
{
    
    internal class SegaDreamCast : ClsConsola
    {
        public string Color { get; set; }

        public String MostrarDetalleSega()
        {
            return MostrarDetalles() + "Color:" + Color;
        }

    }
}
