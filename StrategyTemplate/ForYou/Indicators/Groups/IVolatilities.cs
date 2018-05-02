using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou.Indicators.Groups
{
    public interface IVolatilities
    {
        /// <summary>
        /// NOTE: The ATR function has an unstable period.
        /// https://www.investopedia.com/terms/a/atr.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> AverageTrueRange(Frequency unitType,int historiesLength, int timePeriod);

        /// <summary>
        /// NOTE: The NATR function has an unstable period.
        /// https://www.stockalyze.com/hlp/indicators/topics/volatility_indicators/natr.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> NormalizedAverageTrueRange(Frequency unitType,int historiesLength, int timePeriod);

        /// <summary>
        /// http://spreadsheetml.com/technicalindicators/truerange.shtml
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> TrueRange(Frequency unitType,int historiesLength);
    }
}
