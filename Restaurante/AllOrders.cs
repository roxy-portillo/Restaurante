using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_P3
{
    class AllOrders : MenuItem
    {
        public int OrderNum { get; set; }

        public AllOrders()
        {

        }

        public override string ToString()
        {
            return string.Format("{0}. {1} {2} {3}", OrderNum, Label, Quantity, Price);
        }
    }
}
