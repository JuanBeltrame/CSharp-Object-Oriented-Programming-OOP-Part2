using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _08._1._04_Library
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            razonSocial = nombreEmpresa;
        }

        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> llamadas
        {
            get { return listaDeLlamadas; }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;

            if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
            {
                foreach (Llamada llamada in listaDeLlamadas)
                {
                    if (llamada is Local llamadaLocal)
                    {
                        ganancia += llamadaLocal.CostoLlamada;
                    }
                }
            }

            if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
            {
                foreach (Llamada llamada in listaDeLlamadas)
                {
                    if (llamada is Provincial)
                    {
                        Provincial llamadaProvincial = (Provincial)llamada;
                        ganancia += llamadaProvincial.CostoLlamada;
                    }
                }
            }

            return ganancia;
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine($"Razon social: {razonSocial}");
            stringBuilder.AppendLine($"Lista de llamadas: ");

            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local llamadaLocal)
                {
                    stringBuilder.AppendLine(llamadaLocal.Mostrar());
                }
                else if(llamada is Provincial llamadaProvincial)
                {
                    stringBuilder.AppendLine(llamadaProvincial.Mostrar());
                }
            }

            return stringBuilder.ToString();
        }

    }
}
