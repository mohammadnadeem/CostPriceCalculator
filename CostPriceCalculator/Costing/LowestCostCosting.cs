﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostPriceCalculator
{
    public class LowestCostCosting : ICosting
    {
        public ShareInventory GetInventory(List<ShareInventory> inventory, out decimal inventoryCostPrice)
        {
            inventory.Sort((x,y) => x.Price.CompareTo((y.Price)));
            inventoryCostPrice = inventory.Last().Price;
            return inventory.Last();
        }
    }
}
