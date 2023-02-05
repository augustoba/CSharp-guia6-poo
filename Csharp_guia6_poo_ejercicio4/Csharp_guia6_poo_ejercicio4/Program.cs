using Csharp_guia6_poo_ejercicio4.Entity;
using Csharp_guia6_poo_ejercicio4.Service;

namespace Csharp_guia6_poo_ejercicio4
{
    /*4. Crear una clase Rectángulo que modele rectángulos por medio de un atributo privado
base y un atributo privado altura. La clase incluirá un método para crear el rectángulo con
los datos del Rectángulo dados por el usuario. También incluirá un método para calcular la
superficie del rectángulo y un método para calcular el perímetro del rectángulo. Por último,
tendremos un método que dibujará el rectángulo mediante asteriscos usando la base y la
altura. Se deberán además definir los métodos getters, setters y constructores
correspondientes.
Superficie = base * altura / Perímetro = (base + altura) * 2.*/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Rectangulo  rectangulo= new Rectangulo();
            RectanguloService rectanguloService = new RectanguloService();
            rectangulo = rectanguloService.CrearRectangulo();
           
            Console.WriteLine(rectangulo);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("la superficie del rectangulo es: " + rectanguloService.calcularSuperficie(rectangulo));
            Console.WriteLine("------------------------------------");
            Console.WriteLine("el perimetro del rectangulo es: " + rectanguloService.calcularPerimetro(rectangulo));
        }
    }
}