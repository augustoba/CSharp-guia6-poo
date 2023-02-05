using Csharp_guia6_poo_ejercicio5.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_guia6_poo_ejercicio5.Service
{
    internal class CuentaService
    {

        public Cuenta CrearCuenta()
        {
            Cuenta cuenta= new Cuenta();
            Random  random= new Random();

            cuenta.setNumeroCuenta(random.Next(1,1000));

            Console.WriteLine("ingrese el numero de dni");
            
            cuenta.setDni(int.Parse(Console.ReadLine()));

            Console.WriteLine("ingrese el saldo actual");
            cuenta.setSaldoActual(double.Parse(Console.ReadLine()));
            return cuenta;
        }


        public void CargarDinero(Cuenta cuenta)
        {


            Console.WriteLine("ingrese el saldo a cargar");
            double carga = double.Parse(Console.ReadLine());
            if (carga > 0)
            {
                try { 
                cuenta.setSaldoActual(cuenta.getSaldoActual()+carga);
                Console.WriteLine("carga exitosa");
                Console.WriteLine("su saldo actual es de: $" + cuenta.getSaldoActual());

             }
                catch(FormatException )
                {
                    Console.WriteLine("datos mal ingresados:");
                  //  Console.WriteLine( e.Message);

                }
            }
            else
            {
                throw new Exception( "no se puede cargar numeros negativos");
                

            }

        }

    }
}
