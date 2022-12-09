using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Libro
    {
        public static void GetAll(){

            ML.Result result = BL.Libro.GetAll();
            if (result.Correct)
            {
                
                Console.WriteLine("Los Libros son: ");

                //foreach (result.Objecs in ) {
                   
                    ML.Libro libro = new ML.Libro();

                    Console.WriteLine("Nombre: " + libro.Nombre);

                    Console.WriteLine("IdAutor: " + libro.Autor.IdAutor);

                    Console.WriteLine("Numero de Paginas: " + libro.NumeroPaginas);
                    Console.WriteLine("Fecha de Publicacion: " + libro.FechaPublicacion);

                    
                    Console.WriteLine("IdEditorial: " + libro.Editorial.IdEditorial);

                    Console.WriteLine("Edicion: " + libro.Edicion);

                    Console.WriteLine("IdGenero: " + libro.Genero.IdGenero);

               // }

                Console.ReadLine();
                
            }
        }
        
    }
}
