using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou.Indicators.Groups
{
    public interface IPriceTransforms
    {
        /// <summary>
        /// https://www.investopedia.com/terms/a/averageprice.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> AveragePrice(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.realsourcebrokers.com/median-price/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> MedianPrice(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.fidelity.com/learning-center/trading-investing/technical-analysis/technical-indicator-guide/typical-price
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> TypicalPrice(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://incrediblecharts.com/indicators/weighted_close.php
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> WeightedClosePrice(Frequency unitType,int historiesLength);
    }
}
