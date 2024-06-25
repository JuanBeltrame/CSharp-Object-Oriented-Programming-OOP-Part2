using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._1._04_Library
{
    public class Provincial : Llamada
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
            sb.AppendLine("Tipo de Llamada: Provincial");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja Horaria: {franjaHoraria}");
            sb.AppendLine($"Costo de la llamada: {CostoLlamada}");
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            float costo = 0;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    costo =  duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    costo = duracion * 0.66f;
                    break;
            }
            return costo;
        }
    }
}
