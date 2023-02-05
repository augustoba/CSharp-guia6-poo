using Csharp_guia6_poo_ejercicio3.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_guia6_poo_ejercicio3.Service
{
    internal class OperacionService
    {
        public Operacion crearOperacion()
        {
            Operacion operacion = new Operacion();
            
            Console.WriteLine("ingrese el primer numero");
            operacion.setNumero1(int.Parse(Console.ReadLine()));

            Console.WriteLine("ingrese el segundo numero");
            operacion.setNumero2(int.Parse(Console.ReadLine()));

            return operacion;
        }


        public int sumar(Operacion operacion)
        {
            int suma = operacion.getNumero1()+operacion.getNumero2();
            return suma;
        }

        public int restar(Operacion operacion)
        {
            int resta = operacion.getNumero1() - operacion.getNumero2();
            return resta;
        }

        public int multiplicar(Operacion operacion)
        {            
            if (operacion.getNumero1() > 0 || operacion.getNumero2() > 0)
            {
                int multiplicacion = operacion.getNumero1() * operacion.getNumero2();
                return multiplicacion;

            }
            else
            {
                Console.WriteLine("no se puede multiplicar * 0");
                return 0;
            }
            
        }

        public double dividir(Operacion operacion)
        {
            if (operacion.getNumero1() > 0 || operacion.getNumero2() > 0)
            {
                double division = operacion.getNumero1() / operacion.getNumero2();
            return division;
            }
            else
            {
                Console.WriteLine("no se puede divir * 0");
                return 0;
            }

        }
}
}
