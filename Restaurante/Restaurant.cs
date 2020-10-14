using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_P3
{
    class Restaurant : FoodMenu
    {
        public string Name { get; set; }
        List<MenuItem> Orders = new List<MenuItem>();
        Random RNG = new Random();

        public Restaurant()
        {

        }

        public void Order()
        {
            int addOrder;
            PrintFoodMenu();
            do
            {
                Console.WriteLine("\nElige un elemento");
                int element = int.Parse(Console.ReadLine());
                MenuItem orderItem = new MenuItem();
                switch (element)
                {
                    case 1:
                        orderItem = new MenuItem(menuItem1.Label, menuItem1.Price);
                        Orders.Add(orderItem);                      
                        break;

                    case 2:
                        orderItem = new MenuItem(menuItem2.Label, menuItem2.Price);
                        Orders.Add(orderItem);
                        break;

                    case 3:
                        orderItem = new MenuItem(menuItem3.Label, menuItem3.Price);
                        Orders.Add(orderItem);
                        break;

                    case 4:
                        orderItem = new MenuItem(menuItem4.Label, menuItem4.Price);
                        Orders.Add(orderItem);
                        break;

                    case 5:
                        orderItem = new MenuItem(menuItem5.Label, menuItem5.Price);
                        Orders.Add(orderItem);
                        break;

                    case 6:
                        orderItem = new MenuItem(menuItem6.Label, menuItem6.Price);
                        Orders.Add(orderItem);
                        break;

                }
                Console.WriteLine("Elige una cantidad");
                orderItem.Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Deseas agregar algo mas?\n1. Si\n2. No");
                addOrder = int.Parse(Console.ReadLine());
                Console.WriteLine("Pedido realizado!");
            } while (addOrder == 1);
        }

        public void makeJSON()
        {
            List<AllOrders> allOrders = new List<AllOrders>();
            for(int i = 0; i < Orders.Count; i++)
            {
                allOrders.Add(new AllOrders()
                {
                    OrderNum = i + 1,
                    Quantity = Orders[i].Quantity,
                    Label = Orders[i].Label,
                    Price = Orders[i].Price
                }) ;
            }
            
            Console.WriteLine("Creando archivo AllOrders.json...");
            string json = JsonConvert.SerializeObject(allOrders.ToArray());

            System.IO.File.WriteAllText(@"C:\json\AllOrders.json", json);
            Console.ReadKey();
        }

        public void Pay()
        {
            int num = 1;
            Console.WriteLine("Elige que orden pagar\n");
            foreach(MenuItem items in Orders)
            {
                Console.Write("|{0}|  ", num);
                Console.Write(items);
                Console.WriteLine("\n.....................................\n");
                num++;              
            }
            int orderN = int.Parse(Console.ReadLine());
            if (orderN > Orders.Count)
            {
                Console.WriteLine("Numero de orden no valido");
            }
            else
            {
                double total = (Orders[orderN - 1].Price * Orders[orderN - 1].Quantity) + 1.20;
                Console.WriteLine("\nTu total es: {0}", total);
                Console.Write("Ingresa cantidad a pagar: ");
                double payment = double.Parse(Console.ReadLine());
                Console.WriteLine("Pagando...");
                if (payment == total)
                {
                    Console.WriteLine("Pago Exacto");
                }
                else if (payment > total)
                {
                    Console.WriteLine("Reciba su cambio de: {0}", payment - total);
                }
                else
                {
                    Console.WriteLine("Le falta {0}", total - payment);
                }
            }
            Console.ReadKey();
        }

        public void GetTicket()
        {
            Console.WriteLine("Ingrese numero de orden");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\nGenerando Ticket...\n");          
            Console.WriteLine("Imprimiendo Ticket...\n");
            Console.WriteLine("   {0}", Name);
            Console.WriteLine("\n\t ESTADO DE CUENTA\n\t EXIJA SU FACTURA\n");
            Console.Write("\nCUENTA\t{0}", RNG.Next(1000, 10000));
            Console.Write(" MESA\t{0}", RNG.Next(1,25));
            Console.Write("\nMESERO\t{0}", RNG.Next(101, 299));
            Console.Write("  PERSONAS\t{0}\n\n", RNG.Next(1, 11));
            Console.WriteLine(Orders[num-1]);
            double total = Orders[num - 1].Price * Orders[num - 1].Quantity;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("SUBTOTAL\t${0}\nPROPINA\t\t$1.20\nTOTAL\t\t${1}\n", total, total + 1.20);
            Console.WriteLine("\n\tRAUL MELENDEZ\n00{0} {1}\t\t000{2} {3}",
                              RNG.Next(1, 10),
                              RNG.Next(101, 215),
                              RNG.Next(1, 10),
                              DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            Console.ReadKey();    
        }
    }
}
