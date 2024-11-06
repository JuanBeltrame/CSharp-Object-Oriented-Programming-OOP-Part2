using System.Numerics;

namespace _07._1._01_Library
{

    public class Cliente
    {
        private int numero;
        private string nombre;

        public Cliente(int numero)
        {
            this.numero = numero;
        }
<<<<<<< Updated upstream:07. Encapsulamiento/07.1.01 Library/Cliente.cs
        public Cliente(string nombre, int numero) : this(numero)
=======

        public Cliente(int numero, string nombre) : this(numero)
>>>>>>> Stashed changes:07. Contenido de Encapsulamiento/07.1.01 Library/Cliente.cs
        {
            this.nombre = nombre;
        }

<<<<<<< Updated upstream:07. Encapsulamiento/07.1.01 Library/Cliente.cs
        public int Numero
        {
            get
            {
                return numero;
            }
        }
=======
>>>>>>> Stashed changes:07. Contenido de Encapsulamiento/07.1.01 Library/Cliente.cs
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

<<<<<<< Updated upstream:07. Encapsulamiento/07.1.01 Library/Cliente.cs
        public static bool operator ==(Cliente c1, Cliente c2)
=======
        public int Numero
>>>>>>> Stashed changes:07. Contenido de Encapsulamiento/07.1.01 Library/Cliente.cs
        {
            return c1.numero == c2.numero;
        }
<<<<<<< Updated upstream:07. Encapsulamiento/07.1.01 Library/Cliente.cs
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
=======

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

>>>>>>> Stashed changes:07. Contenido de Encapsulamiento/07.1.01 Library/Cliente.cs
    }
}