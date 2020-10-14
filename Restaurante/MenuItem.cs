using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_P3
{
    class MenuItem
    {
        public int Quantity { get; set; }
        public string Label { get; set; }
        public double Price { get; set; }

        public MenuItem(string label, double price)
        {          
            Label = label;
            Price = price;
        }
        public MenuItem(int quantity, string label, double price) : this (label,price)
        {
            Quantity = quantity;        
        }
        public MenuItem()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} x\t{1}\n{2}\t\t${3} ", Quantity, Price, Label, Quantity * Price);
        }
    }
}
