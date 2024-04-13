using Clase9_de_13_de_abril.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_de_13_de_abril.ClaseHija
{
    internal class Nintendo : ClsConsola
    {
        public bool esPortable { get; set; }

        public string MostarDetallesNintendo()
        {
            string detallePadre = MostrarDetalles();
            return detallePadre + "Es portable:" + esPortable;
        }
    }




}