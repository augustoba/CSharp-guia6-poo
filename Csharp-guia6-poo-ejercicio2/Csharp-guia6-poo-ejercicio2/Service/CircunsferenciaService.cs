using Csharp_guia6_poo_ejercicio2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_guia6_poo_ejercicio2.Service
{
    internal class CircunsferenciaService
    {
        
        public Circunsferencia CrearCircunsferencia()
        {
            Circunsferencia circuns = new Circunsferencia();
            Console.WriteLine("ingrese el radio");
            circuns.setRadio(int.Parse(Console.ReadLine()));    
            return circuns;
}

        public double calcularArea(Circunsferencia circunsferencia)
        {
            double Area = 3.14 *(circunsferencia.getRadio() * circunsferencia.getRadio());
            return Area;
        }

        public double calcularPerimetro(Circunsferencia circunsferencia)
        {
            double perimetro = 2*3.14*circunsferencia.getRadio();

            return perimetro;
        }
    }
}

