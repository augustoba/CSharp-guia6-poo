using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_guia6_poo_ejercicio3.Entity
{
    internal class Operacion
    {
        private int numero1;
        private int numero2;


        public Operacion()
        {
            
        }

        public Operacion(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public int getNumero1()
        {
            return this.numero1;
        }
        public int getNumero2()
        {
            return this.numero2;
        }

        public void setNumero1(int numero1) {
            this.numero1=numero1;
        }
        public void setNumero2(int numero2)
        {
            this.numero2=numero2;
        }

        public override string ToString()
        {
            return "Numero 1: " + this.numero1 + ". Numero 2" + this.numero2;
        }
    }
}
