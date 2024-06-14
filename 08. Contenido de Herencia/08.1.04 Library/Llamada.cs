using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._1._04_Library
{
    internal class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion
        {
            get { return duracion; }
        }
        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }
        public string NroOrigen
        {
            get { return nroOrigen; }
        }

        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Duracion: {duracion}");
            sb.AppendLine($"Nro Destino: {nroDestino}");
            sb.AppendLine($"Nro Origen: {nroOrigen}");

            return sb.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int) (llamada1.duracion - llamada2.duracion);
        }
    }
}
