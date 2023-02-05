using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_guia6_poo_ejercicio1.entitiy
{
    internal class Libro
    {
        private int Isbn;
        private string Titulo;
        private string Autor;
        private int NumPag;

        public Libro()
        {
        }

        public Libro(int isbn, string titulo, string autor, int numPag)
        {
            Isbn = isbn;
            Titulo = titulo;
            Autor = autor;
            NumPag = numPag;
        }

        public int getIsbn() 
        { 
           return this.Isbn;
           }

        public void setIsbn(int Isbn)
        {
            this.Isbn=Isbn;
        }



        public string getTitulo()
        {
            return this.Titulo;
        }
        public void setTitulo(string Titulo)
        {
            this.Titulo = Titulo;
        }

        public void setAutor(string Autor)
        {
            this.Autor = Autor;
        }

        public string getAutor()
        {
            return this.Autor;
        }


        public void setNumPag(int NumPag)
        {
            this.NumPag = NumPag;
        }

        public int getNumPag()
        {
            return this.NumPag;
        }

        public override string ToString()
        {
            return "Isbn: " + this.Isbn + ". Titulo: " + this.Titulo + ". Autor: " + this.Autor + ". Numero de paginas: " + this.NumPag;
        }


    }
}
