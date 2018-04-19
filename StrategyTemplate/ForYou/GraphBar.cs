using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou
{
    public struct GraphBar
    {
        public Decimal OpeningPrice {get; private set;}
        public Decimal ClosingPrice {get; private set;}
        public Decimal BarTypesPriceHigh {get; private set;}
        public Decimal BarTypesPriceLow {get; private set;}

        public DateTime TimeStampUTC {get; private set;}

        public GraphBar(Decimal open, Decimal close, Decimal high, Decimal low, DateTime timeStamp)
        {
            OpeningPrice = open;
            ClosingPrice = close;
            BarTypesPriceHigh = high;
            BarTypesPriceLow = low;
            TimeStampUTC = timeStamp;
        }
    }
}
