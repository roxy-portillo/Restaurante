using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_P3
{
    class BooksMenu : BookSet
    {
        public void Print()
        {
            Console.WriteLine("Colección de Libros\n........................");
            Console.WriteLine("1. Añadir libro\n2. Ver colección\n3. Buscar libro\n4. Salir\n");
            Console.WriteLine("Elige una opción");
        }
    }
}
