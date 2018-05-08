using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostPriceCalculator
{
    public class LIFOCosting : ICosting
    {
        public ShareInventory GetInventory(List<ShareInventory> inventory, out decimal inventoryCostPrice)
        {
            inventory.Sort((x,y) => x.PurchaseDate.CompareTo((y.PurchaseDate)));
            inventoryCostPrice = inventory.Last().Price;
            return inventory.Last();
        }
    }
}
