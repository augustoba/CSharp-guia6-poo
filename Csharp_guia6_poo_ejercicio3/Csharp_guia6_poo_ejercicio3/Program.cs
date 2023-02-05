using Csharp_guia6_poo_ejercicio3.Entity;
using Csharp_guia6_poo_ejercicio3.Service;

namespace Csharp_guia6_poo_ejercicio3
{
    /*3. Crear una clase llamada Operacion que tenga como atributos privados numero1 y
numero2. A continuación, se deben crear los siguientes métodos:
a) Método constructor con todos los atributos pasados por parámetro.
b) Metodo constructor sin los atributos pasados por parámetro.
c) Métodos get y set.
d) Método para crearOperacion(): que le pide al usuario los dos números y los guarda en
los atributos del objeto.
e) Método sumar(): calcular la suma de los números y devolver el resultado al main.
f) Método restar(): calcular la resta de los números y devolver el resultado al main
g) Método multiplicar(): primero valida que no se haga una multiplicación por cero, si
fuera a multiplicar por cero, el método devuelve 0 y se le informa al usuario el error. Si
no, se hace la multiplicación y se devuelve el resultado al main
h) Método dividir(): primero valida que no se haga una división por cero, si fuera a pasar
una división por cero, el método devuelve 0 y se le informa al usuario el error se le
informa al usuario. Si no, se hace la división y se devuelve el resultado al main.*/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Operacion operacion = new Operacion();
            OperacionService  operacionService = new OperacionService();

            operacion = operacionService.crearOperacion();

            Console.WriteLine("ingrese una opcion");
            Console.WriteLine("1- sumar");
            Console.WriteLine("2- restar");
            Console.WriteLine("3- multiplicar");
            Console.WriteLine("4- divid");
            Console.WriteLine("5- salir");
            
            
            int opc = int.Parse(Console.ReadLine());

            switch (opc) { 
            
                case 1:
                    Console.WriteLine("la suma es: ");
                     Console.WriteLine(operacionService.sumar(operacion));
                    break;

                case 2:
                    Console.WriteLine("la resta es: ");
                    Console.WriteLine(operacionService.restar(operacion));
                    break;

                case 3:
                    Console.WriteLine("la multiplicacion es: ");
                    Console.WriteLine(operacionService.multiplicar(operacion));
                    break;

                case 4:
                    Console.WriteLine("la division es: ");
                    Console.WriteLine(operacionService.dividir(operacion));
                    break;

                    case 5:
                    Console.WriteLine("cerrando programa");
                    break;

                    default: Console.WriteLine("ingreso una opcion incorrecta");

                    break;
            }
            
        }
    }
}