﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1._01_Library
{
    internal class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2,
        }

        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get
            {
                return ++numeroActual;
            }
        }
        public bool Atender(Cliente cli)
        {
            if (cli is not null)
            {
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }
    }
}
