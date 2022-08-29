using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.Indicators.Groups
{
    public interface IVolumes
    {
        /// <summary>
        /// http://stockcharts.com/school/doku.php?id=chart_school:technical_indicators:accumulation_distribution_line
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<double[]> ChaikinADLine(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://stockcharts.com/school/doku.php?id=chart_school:technical_indicators:chaikin_oscillator
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="fastPeriod"></param>
        /// <param name="slowPeriod"></param>
        /// <returns></returns>
        ITaLibOutput<double[]> ChaikinADOscillator(Frequency unitType,int historiesLength,int fastPeriod = 3, int slowPeriod = 10);

        /// <summary>
        /// http://www.stockcharts.com/school/doku.php?id=chart_school:technical_indicators:on_balance_volume_obv
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<double[]> OnBalanceVolume(Frequency unitType,int historiesLength);
    }
}
