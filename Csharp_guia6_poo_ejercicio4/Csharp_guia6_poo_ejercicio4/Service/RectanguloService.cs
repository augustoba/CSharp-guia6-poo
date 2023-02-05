using Csharp_guia6_poo_ejercicio4.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_guia6_poo_ejercicio4.Service
{
    internal class RectanguloService
    {

        public Rectangulo CrearRectangulo()
        {
            Rectangulo rectangulo = new Rectangulo();

            Console.WriteLine("ingrese la altura del rectangulo");
            rectangulo.setAlturaRec(double.Parse(Console.ReadLine()));

            Console.WriteLine("ingrese la base");
            rectangulo.setBaseRec(double.Parse(Console.ReadLine()));

            return rectangulo;
        }

        public double calcularPerimetro(Rectangulo rectangulo)
        {
            return (rectangulo.getBaseRec() * rectangulo.getAlturaRec()*2);
        }

        public double calcularSuperficie(Rectangulo rectangulo)
        {
            return rectangulo.getBaseRec()* rectangulo.getAlturaRec();
        }
    }
}
