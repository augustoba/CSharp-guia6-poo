using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_guia6_poo_ejercicio4.Entity
{
    internal class Rectangulo
    {

        private double baseRec;
        private double alturaRec;


        public Rectangulo()
        {
            
        }

        public Rectangulo(double baseRec)
        {
            this.baseRec = baseRec;
        }


      public double getBaseRec()
        {

            return this.baseRec;
        }

        public void setBaseRec(double baseRec)
        {

            this.baseRec=baseRec;
        }



        public double getAlturaRec()
        {

            return this.alturaRec;
        }

        public void setAlturaRec(double alturaRec)
        {

            this.alturaRec = alturaRec;
        }

        public override string ToString()
        {
           return "Base :" + this.baseRec + ". Altura: " + this.alturaRec  ;
        }
    }

        
    
}
