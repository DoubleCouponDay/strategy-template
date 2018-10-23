using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacTec.TA.Library;

namespace StrategyTemplate.ForYou.Indicators.Groups
{
    public interface IOverlapStudies
    {
        /// <summary>
        /// https://www.investopedia.com/terms/b/bollingerbands.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="movingAverageType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <param name="nbDevUp"></param>
        /// <param name="nbDevDown"></param>
        /// <returns></returns>
        ITaLibOutput<(IList<decimal> upperBand, IList<decimal> middleBand, IList<decimal> lowerBand)> BollingerBands(Frequency unitType,  int historiesLength, Core.MAType movingAverageType = Core.MAType.Sma, int timePeriod = 5, int nbDevUp = 2, int nbDevDown = 2);

        /// <summary>
        /// https://www.investopedia.com/articles/trading/10/decimal-exponential-moving-average.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> decimalExponentialMovingAverage(Frequency unitType, int historiesLength, int timePeriod = 30);

        /// <summary>
        /// NOTE: The EMA function has an unstable period.
        /// https://www.investopedia.com/terms/e/ema.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> ExponentialMovingAverage(Frequency unitType, int historiesLength, int timePeriod = 30);

        /// <summary>
        /// NOTE: The HT_TRENDLINE function has an unstable period.
        /// https://www.stockalyze.com/hlp/indicators/topics/overlap_studies/ht_trendline.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> HilbertTransformInstantaneousTrendline(Frequency unitType, int historiesLength);

        /// <summary>
        /// NOTE: The KAMA function has an unstable period.
        /// http://stockcharts.com/school/doku.php?id=chart_school:technical_indicators:kaufman_s_adaptive_moving_average
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> KaufmanAdaptiveMovingAverage(Frequency unitType, int historiesLength, int timePeriod = 30);

        /// <summary>
        /// https://www.investopedia.com/terms/m/movingaverage.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="movingAverageType"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> MovingAverage(Frequency unitType, int historiesLength, Core.MAType movingAverageType = Core.MAType.Sma, int timePeriod = 30);

        /// <summary>
        /// NOTE: The MAMA function has an unstable period.
        /// https://www.stockalyze.com/hlp/indicators/topics/overlap_studies/mama.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="fastLimit"></param>
        /// <param name="slowLimit"></param>
        /// <returns></returns>
        ITaLibOutput<(IList<decimal> mama, IList<decimal> fama)> MesaAdaptiveMovingAverage(Frequency unitType, int historiesLength, int fastLimit = 0, int slowLimit = 0);

        /// <summary>
        /// NOTE: periodsPerPrices length must be the same as historiesLength / custom histories length
        /// https://www.danielstrading.com/education/technical-analysis-learning-center/variable-moving-average
        /// https://stackoverflow.com/questions/48135059/ta-lib-what-is-the-idea-of-periods-in-mavp-moving-average-with-variable-peri
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="movingAverageType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="minPeriod"></param>
        /// <param name="maxPeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> MovingAverageWithVariablePeriod(Frequency unitType, decimal[] periodsPerPrices, int historiesLength, Core.MAType movingAverageType = Core.MAType.Sma, int minPeriod = 2, int maxPeriod = 30);

        /// <summary>
        /// https://www.stockalyze.com/hlp/indicators/topics/overlap_studies/midpoint.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> MidPointOverPeriod(Frequency unitType, int historiesLength, int timePeriod = 14);

        /// <summary>
        /// https://www.stockalyze.com/hlp/indicators/topics/overlap_studies/midprice.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> MidPointPriceOverPeriod(Frequency unitType, int historiesLength, int timePeriod = 14);

        /// <summary>
        /// http://stockcharts.com/school/doku.php?id=chart_school:technical_indicators:parabolic_sar
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="acceleration"></param>
        /// <param name="maximum"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> ParabolicSar(Frequency unitType, int historiesLength, int acceleration = 0, int maximum = 0);

        /// <summary>
        /// https://www.stockalyze.com/hlp/indicators/topics/overlap_studies/sarext.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="startvalue"></param>
        /// <param name="offsetonreverse"></param>
        /// <param name="accelerationinitlong"></param>
        /// <param name="accelerationlong"></param>
        /// <param name="accelerationmaxlong"></param>
        /// <param name="accelerationinitshort"></param>
        /// <param name="accelerationshort"></param>
        /// <param name="accelerationmaxshort"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> ParabolicSarExtended(Frequency unitType, int historiesLength, int startvalue = 0, int offsetonreverse = 0, int accelerationinitlong = 0, int accelerationlong = 0, int accelerationmaxlong = 0, int accelerationinitshort = 0, int accelerationshort = 0, int accelerationmaxshort = 0);

        /// <summary>
        /// https://www.investopedia.com/terms/s/sma.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> SimpleMovingAverage(Frequency unitType, int historiesLength, int timePeriod = 30);

        /// <summary>
        /// NOTE: The T3 function has an unstable period.
        /// https://www.tradingtechnologies.com/help/x-study/technical-indicator-definitions/t3-t3/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <param name="vFactor"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> TripleExponentialMovingAverageT3(Frequency unitType, int historiesLength, int timePeriod = 5, int vFactor = 0);

        /// <summary>
        /// https://www.investopedia.com/terms/t/triple-exponential-moving-average.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> TripleExponentialMovingAverage(Frequency unitType,int historiesLength,int timePeriod = 30);

        /// <summary>
        /// http://www.onlinetradingconcepts.com/TechnicalAnalysis/MATriangular.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> TriangularMovingAverage(Frequency unitType, int historiesLength, int timePeriod = 30);

        /// <summary>
        /// https://www.investopedia.com/articles/technical/060401.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> WeightedMovingAverage(Frequency unitType, int historiesLength, int timePeriod = 30);
    }
}
