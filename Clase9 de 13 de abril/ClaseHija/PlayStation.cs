using Clase9_de_13_de_abril.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_de_13_de_abril.ClaseHija
{
    
      internal class Playstation : ClsConsola
    {
        public string ModeloControlador { get; set; }

        public String MostrarDetallePlay()
        {
    
            return MostrarDetalles() + "Controlador:" + ModeloControlador;
        }
      }
}
