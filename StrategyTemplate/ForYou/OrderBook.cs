using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou
{
    public class OrderBook
    {
        public transaction[] BuyOrders {get; set; }
        public transaction[] SellOrders {get; set;}
    }
}
