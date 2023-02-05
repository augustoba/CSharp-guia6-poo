using Csharp_guia6_poo_ejercicio2.Entity;
using Csharp_guia6_poo_ejercicio2.Service;

namespace Csharp_guia6_poo_ejercicio2
{
    /*2. Declarar una clase llamada Circunferencia que tenga como atributo privado el radio de
tipo real. A continuación, se deben crear los siguientes métodos:
a) Método constructor que inicialice el radio pasado como parámetro.
b) Métodos get y set para el atributo radio de la clase Circunferencia.
c) Método para crearCircunferencia(): que le pide el radio y lo guarda en el atributo del
objeto.
d) Método area(): para calcular el área de la circunferencia (���� = � ∗ ������).
e) Método perimetro(): para calcular el perímetro (��������� = � ∗ � ∗ �����).  */

    internal class Program
    {
        private static void Main(string[] args)
        {
           
           Circunsferencia circunsferencia= new Circunsferencia();
           CircunsferenciaService circunServ= new CircunsferenciaService();

            circunsferencia = circunServ.CrearCircunsferencia();

            Console.WriteLine("el area es: " + circunServ.calcularArea(circunsferencia));
            Console.WriteLine("el area perimetro es: " + circunServ.calcularPerimetro(circunsferencia));
            

        }
    }
}