using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Example_09._0._01
{
    // Clase creada dentro de otra clase, solo para que sea mas facil de visualizar. 
    public abstract class Animal
    {
        public abstract string EmitirSonido();

        public abstract string Cazar();
        
        public override int GetHashCode()
        {
            return 1;
        }
    }
    public class Perro : Animal
    {
        public override string EmitirSonido()
        {
            return "woof!!!";
        }

        public override string Cazar()
        {
            return "Estoy cazando porque soy un perro";
        }
    }
    public class Cachorro : Perro
    {
    }
    public class Carpincho : Animal
    {
        public override string EmitirSonido()
        {
            return "Viva la revolucion carpincha!";
        }

        public override string Cazar()
        {
            return "Estoy cazando porque soy un Carpincho";
        }
    }
}
