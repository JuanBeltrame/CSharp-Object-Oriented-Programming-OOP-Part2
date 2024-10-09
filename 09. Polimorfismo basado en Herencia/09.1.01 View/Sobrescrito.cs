using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._1._01_View
{
    internal abstract class Sobrescrito
    {
        protected string miAtributo;

        protected Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "Este es mi metodo ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            // Option 1: return obj.GetType() == this.GetType();
            // Option 2: return obj is Sobrescrito;
            // Option 3:
            Sobrescrito aux = obj as Sobrescrito;
            if (aux is not null)
                return true;
            else
                return false;
            
            // Option 4: return obj.GetType() == typeof(Sobrescrito);
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
