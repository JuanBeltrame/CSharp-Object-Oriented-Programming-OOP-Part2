using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._1._04_Library
{
    internal class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
            
        }

        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {CostoLlamada}");
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            return duracion * costo;
        }
    }
}
