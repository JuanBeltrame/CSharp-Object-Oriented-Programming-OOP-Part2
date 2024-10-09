using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_08._0._01
{
    public class Estudiante : Persona
    {
        public int legajo;
        public List<string> materias;

        public Estudiante(Persona persona, int legajo) : base(persona.Apellido, persona.Nombre, persona.Dni)
        {
            this.legajo = legajo;
            this.materias = new List<string>();
        }
        public Estudiante(int legajo, long dni, string nombre, string apellido)
        : this(new Persona(nombre, apellido, dni), legajo)
        {

        }

        public string Estudiar()
        {
            return "Estoy estudiando...";
        }

        public string MostarAlumno()
        {
            return $"{base.MostrarPersona()} Legajo: {this.legajo}";

        }
    }
}
