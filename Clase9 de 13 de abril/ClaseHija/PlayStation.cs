using Clase9_de_13_de_abril.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_de_13_de_abril.ClaseHija
{
    internal class PlayStation:ClsConsola
    {
     public string ModeloControlador{  get; set; }
        public string MostrarDetallesPlay()
        {
            return MostrarDetalles() + "Controlador:" + ModeloControlador;
        }

    }
}
