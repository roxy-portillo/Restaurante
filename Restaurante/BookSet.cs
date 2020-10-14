using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_P3
{
    class BookSet : Books
    {
        public object[] BookCollection = new object[25];
        int position = 0;
        public BookSet()
        {
        }

        public void AddBook(Books book)
        {
            if (!BookCollection.Contains(book) && BookCollection.Length <= 25)
            {
                BookCollection[position] = book;
                position++;
            }
            Console.WriteLine("\nLibro añadido!");
            Console.ReadKey();
        }

        public void SearchBook()
        {
            Console.Clear();
            Console.WriteLine("Buscar libro\n");
            Console.Write("Titulo: ");
            string title = Console.ReadLine();
            Console.WriteLine("\nBuscando libro...\n");
            Books foundBook = new Books();
            foreach (Books b in BookCollection)
            {
                if (b != null)
                {
                    if (b.Title.Equals(title))
                    {
                        foundBook = b;
                        break;
                    }
                    else
                    {
                        foundBook = null;
                    }
                }
            }

            if (foundBook != null)
            {
                Console.WriteLine(foundBook);
            }
            else
            {
                Console.WriteLine("No encontrado\n");
            }

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
        public void PrintCollection()
        {
            Console.Clear();
            foreach (Books b in BookCollection)
            {
                if (b != null)
                {
                    Console.WriteLine(b);
                }
            }
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}


