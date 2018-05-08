using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostPriceCalculator.Exceptions
{
    public class InventoryException : Exception
    {
        public InventoryException(string message) : base(message)
        {
        }
    }
}
