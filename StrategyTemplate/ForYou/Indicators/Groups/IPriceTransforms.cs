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
        ITaLibOutput<double[]> AveragePrice(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.realsourcebrokers.com/median-price/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<double[]> MedianPrice(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.fidelity.com/learning-center/trading-investing/technical-analysis/technical-indicator-guide/typical-price
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<double[]> TypicalPrice(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://incrediblecharts.com/indicators/weighted_close.php
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<double[]> WeightedClosePrice(Frequency unitType,int historiesLength);
    }
}
