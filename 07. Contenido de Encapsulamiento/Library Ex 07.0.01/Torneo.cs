namespace Library_Ex_07._0._01
{
    public enum Deporte
    {
        Futbol,
        Bascket,
        Handball,
        Voley,
    }

    public class Torneo
    {
        private int totalGoles;
        private int totalPartidos;
        private Deporte deporte;

        public Torneo(int totalGoles, int totalPartidos, Deporte deporte)
        {
            this.totalGoles = totalGoles;
            this.totalPartidos = totalPartidos;
            this.deporte = deporte;
        }

        public Deporte DeporteDelTorneo
        {
            get
            {
                return deporte;
            }

        }

        public int TotalGoles
        {
            get
            {
                return totalGoles;
            }
            set
            {
                totalGoles = value;
            }
        }
        public float PromedioGoles
        {
            get
            {
                float prom = totalGoles / (float)totalPartidos;
                return prom;
            }
        }
        public int TotalPartidos
        {
            set
            {
                totalPartidos = value;
            }
        }
    }
}
