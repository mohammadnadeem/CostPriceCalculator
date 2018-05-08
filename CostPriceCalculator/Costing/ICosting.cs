using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostPriceCalculator
{
    public interface ICosting
    {
        ShareInventory GetInventory(List<ShareInventory> inventory, out decimal inventoryCostPrice);
    }
}
