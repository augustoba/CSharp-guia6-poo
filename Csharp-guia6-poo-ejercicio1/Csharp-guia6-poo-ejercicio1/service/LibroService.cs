using Csharp_guia6_poo_ejercicio1.entitiy;


namespace Csharp_guia6_poo_ejercicio1.service
{
    internal class LibroService
    {

        Libro libro = new Libro();


        public Libro crearLibro()
        {

            Console.WriteLine("ingrese el isbn del libro");
            libro.setIsbn(int.Parse(Console.ReadLine()));
            
            Console.WriteLine("ingrese el titulo libro");
            libro.setTitulo(Console.ReadLine());
            
            Console.WriteLine("ingrese el nombre del autor libro");
            libro.setAutor(Console.ReadLine());

            Console.WriteLine("ingrese el numero de paginas del libro");
            libro.setNumPag(int.Parse(Console.ReadLine()));


            return libro;
        }
    }
}
