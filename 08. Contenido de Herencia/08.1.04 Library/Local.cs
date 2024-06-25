using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._1._04_Library
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(string origen, float duracion, string destino, float costo) 
            :this (new Llamada(duracion, destino, origen), costo)
        {
           
        }

        public Local(Llamada llamada, float costo)
            :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        
        public new string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine("Tipo de Llamada: Local");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo por minuto: {costo}");
            sb.AppendLine($"Costo de la llamada: {CostoLlamada}");
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            return duracion * costo;
        }
    }
}
