using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostPriceCalculator
{
    public class OrderInvoice
    {
        public decimal CostPriceOfSoldShares { get; set; }
        public decimal ProfitLoss { get; set; }
        public decimal RemainingShares { get; set; }
        public decimal CostPriceOfRemainingShares { get; set; }
    }
}
