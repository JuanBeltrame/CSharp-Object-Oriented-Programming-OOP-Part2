using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._1._01_View
{
    internal class Sobrescrito
    {
        public override string ToString()
        {
            return "Este es mi metodo ToString sobreescrito!";
        }

        public override bool Equals(object? obj)
        {
            return this.GetType() == typeof(Sobrescrito);
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
