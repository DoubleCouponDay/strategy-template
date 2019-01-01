using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou
{
    public struct GraphBar
    {
        public double OpeningPrice {get; private set;}
        public double ClosingPrice {get; private set;}
        public double PriceHigh {get; private set;}
        public double PriceLow {get; private set;}
        public double Volume {get; private set;}
        public DateTime TimeStampUTC {get; private set;}

        public GraphBar(double open, double close, double high, double low, double volume, DateTime timeStamp)
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
