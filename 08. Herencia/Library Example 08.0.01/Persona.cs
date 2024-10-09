using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_08._0._01
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected long dni;
        private long edad;

        

        public Persona(string nombre, string apellido, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public long Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }


        public string MostrarPersona()
        {
            return $"Nombre: {nombre} --- Apellido {apellido} --- DNI {dni}";
        }
    }
}

