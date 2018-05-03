using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou
{
    /// <summary>
    /// Used as a value type! word to the wise.
    /// </summary>
    public interface IGraphBar
    {
        double OpeningPrice {get;}
        double ClosingPrice {get;}
        double PriceHigh {get;}
        double PriceLow {get;}
        double Volume {get;}
        DateTime TimeStampUTC {get;}
    }
}
