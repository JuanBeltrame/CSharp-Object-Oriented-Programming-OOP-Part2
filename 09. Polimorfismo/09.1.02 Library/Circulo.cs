using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._1._02_Library
{
    public sealed class Circulo : Figura 
    {
        public override double CalcularPerimetro()
        {
            throw new NotImplementedException();
        }

        public override double CalcularSuperficie()
        {
            throw new NotImplementedException();
        }

        public override string Dibujar()
        {
            return "Dibujando Circulo...";
        }
    }
}
