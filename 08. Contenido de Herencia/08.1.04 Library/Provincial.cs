using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._1._04_Library
{
    internal class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }

        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            franjaHoraria = miFranja;
        }

        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }


        public new string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja Horaria: {franjaHoraria}");
            sb.AppendLine($"Costo de la llamada: {CostoLlamada}");
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            return duracion * costo;
        }
    }
}
