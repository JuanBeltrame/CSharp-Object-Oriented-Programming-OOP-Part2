using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_08._0._02
{
    public class Publicacion
    {
        private string titulo;
        private DateTime fechaDePublicacion;
        private string editorial;
        private string paisDePublicacion;

        public Publicacion(string titulo, DateTime fechaDePublicacion)
        {
            this.titulo = titulo;
            this.fechaDePublicacion = fechaDePublicacion;
        }

        protected string Titulo { get => titulo; set => titulo = value; }
        protected DateTime FechaDePublicacion { get => fechaDePublicacion; set => fechaDePublicacion = value; }
        protected string Editorial
        {
            get
            {
                return editorial;
            }
            set
            {
                editorial = value;
            }
        }
        protected string PaisDePublicacion
        {
            get
            {
                return paisDePublicacion;
            }

            set
            {
                paisDePublicacion = value;
            }
        }


        public string MostrarDatos()
        {
            return $"{this.GetType().Name} Título: {this.Titulo}, Fecha de publicación: {this.FechaDePublicacion}";


        }

        
    }
}
