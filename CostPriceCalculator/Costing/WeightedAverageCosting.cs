using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostPriceCalculator
{
    public class WeightedAverageCosting : ICosting
    {
        public ShareInventory GetInventory(List<ShareInventory> inventory, out decimal inventoryCostPrice)
        {
            inventoryCostPrice = GetWeightedAverageCost(inventory);
            return inventory.First(); ;
        }

        private decimal GetWeightedAverageCost(List<ShareInventory> inventory)
        {
            return inventory.Sum(x => x.Price * x.SharesCount) / inventory.Sum(x => x.SharesCount);
        }
    }
}
