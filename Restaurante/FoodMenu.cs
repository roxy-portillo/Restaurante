using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_P3
{
    class FoodMenu : MenuItem
    {
        public MenuItem menuItem1 = new MenuItem("Tacos al Pastor", 4.99);
        public MenuItem menuItem2 = new MenuItem("Tacos Mixtos", 4.99);
        public MenuItem menuItem3 = new MenuItem("Burrito al Pastor", 4.99);
        public MenuItem menuItem4 = new MenuItem("Burrito Mixto", 4.99);
        public MenuItem menuItem5 = new MenuItem("Soda", 0.75);
        public MenuItem menuItem6 = new MenuItem("Fresco", 0.75);

        public void PrintFoodMenu()
        {
            Console.WriteLine("Menu\n---------------");       
            Console.WriteLine("1. {0}\t${1}", menuItem1.Label, menuItem1.Price);
            Console.WriteLine("2. {0}\t\t${1}", menuItem2.Label, menuItem2.Price);
            Console.WriteLine("3. {0}\t${1}", menuItem3.Label, menuItem3.Price);
            Console.WriteLine("4. {0}\t${1}", menuItem4.Label, menuItem4.Price);
            Console.WriteLine("5. {0}\t\t\t${1}", menuItem5.Label, menuItem5.Price);
            Console.WriteLine("6. {0}\t\t\t${1}", menuItem6.Label, menuItem6.Price);
        }
    }
}
