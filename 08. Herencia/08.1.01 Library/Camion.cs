using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._1._01_Library
{
    public enum Colores
    {
        Rojo, Blanco, Azul, Gris, Negro
    }
    public class Camion : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int pesoCarga;

        public Camion(short cantidadMarchas, short cantidadRuedas, short cantidadPuertas, Colores color, int pesoCarga)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;

        }
    }
}
