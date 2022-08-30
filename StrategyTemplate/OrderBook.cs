using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate
{
    public class OrderBook
    {
        public Transaction[] BuyOrders { get; set; }
        public Transaction[] SellOrders { get; set; }
    }
}
