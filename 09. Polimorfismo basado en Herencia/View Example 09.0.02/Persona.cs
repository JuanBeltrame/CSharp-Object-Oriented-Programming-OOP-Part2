
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View_Example_09._0._01;

namespace View_Example_09._0._02
{
    internal class Persona
    {
        private string nombre;
        private char genero;
        private string dni;
        private Animal mascota;

        public Persona(string nombre, char genero, string dni)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.dni = dni;
            this.mascota = new Carpincho();
        }

        public static bool operator ==(Persona persona, Persona otraPersona)
        {
            if (persona is null || otraPersona is null)
            {
                return false;
            }

            return persona.GetType() == otraPersona.GetType()
                && persona.dni == otraPersona.dni
                && persona.genero == otraPersona.genero;
        }

        public static bool operator !=(Persona persona, Persona otraPersona)
        {
            return !(persona == otraPersona);
        }

        public override bool Equals(object? obj)
        {
            Persona otraPersona = obj as Persona;

            return otraPersona is not null && this == otraPersona;
        }

        public override int GetHashCode()
        {
            return (dni, genero, mascota).GetHashCode();
        }


    }
}
