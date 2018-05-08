using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostPriceCalculator
{
    public class Order
    {
        public DateTime SellDate { get; set; }
        public int NumberOfShares { get; set; }
        public decimal Price { get; set; }
    }
}
