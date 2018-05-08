using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostPriceCalculator
{
    public class FIFOCosting : ICosting
    {
        public ShareInventory GetInventory(List<ShareInventory> inventory, out decimal inventoryCostPrice)
        {
            inventory.Sort((x,y) => x.PurchaseDate.CompareTo((y.PurchaseDate)));
            inventoryCostPrice = inventory.First().Price;
            return inventory.First();
        }
    }
}
