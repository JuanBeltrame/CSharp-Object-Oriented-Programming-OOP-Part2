using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._1._01_Library
{
    public class Automovil : VehiculoTerrestre
    {
        public int cantidadPasajeros;
        public int cantidadMarchas;
        public Automovil(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, Colores color, int cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
