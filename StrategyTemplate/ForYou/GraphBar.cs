using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou
{
    public struct GraphBar
    {
        public decimal OpeningPrice {get; private set;}
        public decimal ClosingPrice {get; private set;}
        public decimal PriceHigh {get; private set;}
        public decimal PriceLow {get; private set;}
        public decimal Volume {get; private set;}
        public DateTime TimeStampUTC {get; private set;}

        public GraphBar(decimal open, decimal close, decimal high, decimal low, decimal volume, DateTime timeStamp)
        {
            OpeningPrice = open;
            ClosingPrice = close;
            PriceHigh = high;
            PriceLow = low;
            Volume = volume;
            TimeStampUTC = timeStamp;
        }
    }
}
