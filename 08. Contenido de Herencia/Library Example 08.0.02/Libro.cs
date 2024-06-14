namespace Library_Example_08._0._02
{
    public class Libro : Publicacion
    {
        private string autor;
        private float precio;

        public Libro(string titulo, string autor, DateTime fechaDePublicacion) 
            : base(titulo, fechaDePublicacion)
        {
            this.autor = autor;
        }

        public string Autor { get => autor; set => autor = value; }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public new string MostrarDatos()
        {
            return $"{base.MostrarDatos()} Autor: {this.autor}";
        }
    }
}
