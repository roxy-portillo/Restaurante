using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_P3
{
    class Menu
    {
        public void PrintMenu()
        {
            Console.WriteLine("1. Libros\n2. Restaurante\n");
            Console.WriteLine("Elige una opción");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    BooksMenu booksMenu = new BooksMenu();
                    int optionBM;
                    do
                    {
                        Console.Clear();
                        booksMenu.Print();
                        optionBM = int.Parse(Console.ReadLine());

                        switch (optionBM)
                        {
                            case 1:
                                Console.Clear();
                                Books newBook = new Books();
                                Console.WriteLine("Ingrese el titulo:");
                                newBook.Title = Console.ReadLine();
                                Console.WriteLine("Ingrese el autor:");
                                newBook.Author = Console.ReadLine();
                                Console.WriteLine("Ingrese el numero de paginas:");
                                newBook.Pages = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese la calificacion:");
                                newBook.Rating = int.Parse(Console.ReadLine());
                                booksMenu.AddBook(newBook);
                                break;

                            case 2:
                                booksMenu.PrintCollection();
                                break;

                            case 3:
                                booksMenu.SearchBook();
                                break;

                            case 4:
                                Console.Clear();
                                PrintMenu();
                                break;

                            default: break;
                        }

                    } while (optionBM != 4);
                    break;

                case "2":
                    RestaurantMenu restaurantMenu = new RestaurantMenu();
                    Restaurant restaurant = new Restaurant
                    {
                        Name = "RESTAURANTE SABOR MEXICANO"
                    };
                    int optionR;
                    do
                    {
                        Console.Clear();
                        restaurantMenu.Print();
                        optionR = int.Parse(Console.ReadLine());
                        switch (optionR)
                        {
                            case 1:
                                Console.Clear();
                                restaurant.Order();
                                break;

                            case 2:
                                Console.Clear();
                                restaurant.Pay();
                                break;

                            case 3:
                                Console.Clear();
                                restaurant.GetTicket();
                                break;

                            case 4:
                                Console.Clear();
                                restaurant.makeJSON();
                                break;

                            case 5:
                                Console.Clear();
                                PrintMenu();
                                break;
                        }
                    } while (optionR != 5);
                    break;

                default:
                    Console.WriteLine("Ingrese una opción valida");
                    Console.ReadKey();
                    Console.Clear();
                    PrintMenu();
                    break;
            }
        }
    }
}
