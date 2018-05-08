using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostPriceCalculator.Costing;
using CostPriceCalculator.Exceptions;

namespace CostPriceCalculator
{
    public class InventoryService
    {
        private List<ShareInventory> inventory;
        private ICosting costingService;
        
        public InventoryService()
        {
            inventory = new List<ShareInventory>();
            LoadInventory();
        }

        /// <summary>
        /// Load Inventory Data
        /// </summary>
        private void LoadInventory()
        {
            /* load inventory with sample data, 
             * in an actual scenario this method can be used to load data from a db 
             * or for that matter any other source
             * /
            Object 1:  a) 1 / 1 / 2005,  b)  100,  c) 10
            Object 2:  a) 2 / 2 / 2005,  b)  40,  c) 12
            Object 3:  a) 3 / 3 / 2005,  b)  50,  c) 11
            */
            
            inventory.Add(new ShareInventory() { PurchaseDate = Convert.ToDateTime("1/1/2005"), SharesCount = 100, Price = 10m });
            inventory.Add(new ShareInventory() { PurchaseDate = Convert.ToDateTime("2/3/2005"), SharesCount = 40, Price = 12m });
            inventory.Add(new ShareInventory() { PurchaseDate = Convert.ToDateTime("3/3/2005"), SharesCount = 50, Price = 11m });

            //inventory.Add(new ShareInventory() { PurchaseDate = Convert.ToDateTime("1/1/2005"), SharesCount = 2, Price = .50m });
            //inventory.Add(new ShareInventory() { PurchaseDate = Convert.ToDateTime("1/1/2005"), SharesCount = 2, Price = .70m });
        }

        /// <summary>
        /// Get total number of available shares
        /// </summary>
        /// <returns>total number of avaialable shares</returns>
        private int GetSharesCount()
        {
            return inventory.Sum(x => x.SharesCount);
        }

        /// <summary>
        /// Get Cost Price of the remaining shares
        /// </summary>
        /// <returns>Returns Cost Price of the remaining shares</returns>
        private decimal GetCostPrice()
        {
            if (GetSharesCount() > 0)            
                return inventory.Sum(x => x.Price * x.SharesCount) / GetSharesCount();
            return 0;
        }        

        /// <summary>
        /// Processes the order and updates the inventory.
        /// </summary>
        /// <param name="order">order object to be fulfilled.</param>
        /// <param name="costingMethod">Costing Method</param>
        /// <returns>OrderInvoice object containing details of invoice of order</returns>
        public OrderInvoice FulfillOrder(Order order, CostingMethod costingMethod)
        {
            int sharesToBeSold = order.NumberOfShares;
            decimal totalCostPrice = 0m;
            decimal inventoryCostPrice;
            OrderInvoice orderInvoice = new OrderInvoice();

            // throw error if there is not enough inventory to fulfill order
            if (GetSharesCount() < order.NumberOfShares)
                throw new InventoryException(String.Format("Cannot process order for {0} shares, only {1} shares left in Inventory!", 
                    order.NumberOfShares, GetSharesCount()));

            // Get costing class object based on the costing method selected, default is FIFO
            costingService = CostingFactory.GetCostingService(costingMethod);

            #region ProcessOrder
            var inventoryItem = costingService.GetInventory(inventory, out inventoryCostPrice);
            while (costingService.GetInventory(inventory, out inventoryCostPrice).SharesCount < sharesToBeSold)
            {
                totalCostPrice += inventoryItem.SharesCount * inventoryCostPrice;
                sharesToBeSold -= inventoryItem.SharesCount;
                inventory.RemoveAt(0);
            }

            inventoryItem = costingService.GetInventory(inventory, out inventoryCostPrice);
            inventoryItem.SharesCount -= sharesToBeSold;
            totalCostPrice += sharesToBeSold * inventoryCostPrice;

            if (inventoryItem.SharesCount == 0)
                inventory.RemoveAt(0);

            #endregion

            #region Create OrderInvoice
            orderInvoice.CostPriceOfSoldShares = totalCostPrice / order.NumberOfShares;
            orderInvoice.ProfitLoss = (order.Price * order.NumberOfShares) - totalCostPrice;
            orderInvoice.RemainingShares = GetSharesCount();
            orderInvoice.CostPriceOfRemainingShares = GetCostPrice();
            #endregion

            return orderInvoice;
        }
    }
}
