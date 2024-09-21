using System;

namespace libros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca(); // Instanciamos la biblioteca
            int opcion;

            do
            {
                // Mostramos el menú
                Console.WriteLine("----- Sistema de Gestión de Libros -----");
                Console.WriteLine("1. Agregar libro");
                Console.WriteLine("2. Eliminar libro");
                Console.WriteLine("3. Buscar libro");
                Console.WriteLine("4. Mostrar todos los libros");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1: // Agregar libro
                        Console.Write("Ingrese el título del libro: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Ingrese el autor del libro: ");
                        string autor = Console.ReadLine();
                        Console.Write("Ingrese el ISBN del libro: ");
                        string isbn = Console.ReadLine();
                        Console.Write("Ingrese el año de publicación: ");
                        int anio = Convert.ToInt32(Console.ReadLine());

                        // Crear y agregar el libro
                        Libro libro = new Libro { Titulo = titulo, Autor = autor, ISBN = isbn, AnioPublicacion = anio };
                        biblioteca.AgregarLibro(libro);
                        break;

                    case 2: // Eliminar libro
                        Console.Write("Ingrese el ISBN del libro a eliminar: ");
                        string isbnEliminar = Console.ReadLine();
                        biblioteca.EliminarLibro(isbnEliminar);
                        break;

                    case 3: // Buscar libro
                        Console.Write("Ingrese el título del libro a buscar: ");
                        string tituloBuscar = Console.ReadLine();
                        biblioteca.BuscarLibro(tituloBuscar);
                        break;

                    case 4: // Mostrar todos los libros
                        biblioteca.mostrarLibros();
                        break;

                    case 5: // Salir
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                // Pausamos para que el usuario pueda leer el resultado antes de volver al menú
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear(); // Limpiamos la consola para mejor visualización

            } while (opcion != 5); // El bucle se ejecuta hasta que el usuario elige salir
        }
    }
}