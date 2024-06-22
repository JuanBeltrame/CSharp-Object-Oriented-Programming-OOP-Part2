using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._1._01_View
{
    internal class SobreSobrescrito : Sobrescrito
    {

        public SobreSobrescrito() : base()
        {

        }
        public override string MiPropiedad
        {
            get
            {
                return miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }

    }
}
