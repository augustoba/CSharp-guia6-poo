using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_guia6_poo_ejercicio2.Entity
{
    internal class Circunsferencia
    {
        private int Radio;

        public Circunsferencia()
        {
            
        }
        public Circunsferencia(int radio)
        {
            Radio = radio;
        }

        public int getRadio()
        {
            return this.Radio;
        }

        public void setRadio(int radio)
        {
            this.Radio = radio;
        }

        public override string ToString()
        {
            return "el radio es: " + this.Radio;
        }
    }
}
