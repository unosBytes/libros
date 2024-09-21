using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libros
{
    class Biblioteca
    {
        private List<Libro> libros = new List<Libro>();

        public void mostrarLibros()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros en la biblioteca.");
            }
            else
            {
                Console.WriteLine("Lista de libros en la biblioteca:");
                foreach (var libro in libros)
                {
                    Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, ISBN: {libro.ISBN}, Año: {libro.AnioPublicacion}");
                }
            }
        }

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
            Console.WriteLine("Libro agregado con éxito.");
        }

        public void EliminarLibro(string isbn)
        {
            var libro = libros.Find(l => l.ISBN == isbn);
            if (libro != null)
            {
                libros.Remove(libro);
                Console.WriteLine("Libro eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }

        public void BuscarLibro(string titulo)
        {
            var libro = libros.Find(l => l.Titulo.Contains(titulo));
            if (libro != null)
            {
                Console.WriteLine($"Libro encontrado: {libro.Titulo}, Autor: {libro.Autor}");
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }

        
        }
    }
}
