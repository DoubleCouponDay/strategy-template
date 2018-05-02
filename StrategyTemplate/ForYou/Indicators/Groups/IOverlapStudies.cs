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
        ITaLibOutput<(IList<double> upperBand, IList<double> middleBand, IList<double> lowerBand)> BollingerBands(Frequency unitType, Core.MAType movingAverageType, int historiesLength, int timePeriod, int nbDevUp, int nbDevDown);

        /// <summary>
        /// https://www.investopedia.com/articles/trading/10/double-exponential-moving-average.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> DoubleExponentialMovingAverage(Frequency unitType, int historiesLength, int timePeriod);

        /// <summary>
        /// NOTE: The EMA function has an unstable period.
        /// https://www.investopedia.com/terms/e/ema.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> ExponentialMovingAverage(Frequency unitType, int historiesLength, int timePeriod);

        /// <summary>
        /// NOTE: The HT_TRENDLINE function has an unstable period.
        /// https://www.stockalyze.com/hlp/indicators/topics/overlap_studies/ht_trendline.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> HilbertTransformInstantaneousTrendline(Frequency unitType, int historiesLength);

        /// <summary>
        /// NOTE: The KAMA function has an unstable period.
        /// http://stockcharts.com/school/doku.php?id=chart_school:technical_indicators:kaufman_s_adaptive_moving_average
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> KaufmanAdaptiveMovingAverage(Frequency unitType, int historiesLength, int timePeriod);

        /// <summary>
        /// https://www.investopedia.com/terms/m/movingaverage.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="movingAverageType"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> MovingAverage(Frequency unitType, Core.MAType movingAverageType, int historiesLength,  int timePeriod);

        /// <summary>
        /// NOTE: The MAMA function has an unstable period.
        /// https://www.stockalyze.com/hlp/indicators/topics/overlap_studies/mama.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="fastLimit"></param>
        /// <param name="slowLimit"></param>
        /// <returns></returns>
        ITaLibOutput<(IList<double> mama, IList<double> fama)> MesaAdaptiveMovingAverage(Frequency unitType, int historiesLength, int fastLimit, int slowLimit);

        /// <summary>
        /// https://www.danielstrading.com/education/technical-analysis-learning-center/variable-moving-average
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="movingAverageType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="minPeriod"></param>
        /// <param name="maxPeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> MovingAverageWithVariablePeriod(Frequency unitType, Core.MAType movingAverageType, int historiesLength, int minPeriod, int maxPeriod);

        /// <summary>
        /// https://www.stockalyze.com/hlp/indicators/topics/overlap_studies/midpoint.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> MidPointOverPeriod(Frequency unitType, int historiesLength, int timePeriod);

        /// <summary>
        /// https://www.stockalyze.com/hlp/indicators/topics/overlap_studies/midprice.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> MidPointPriceOverPeriod(Frequency unitType, int historiesLength, int timePeriod);

        /// <summary>
        /// http://stockcharts.com/school/doku.php?id=chart_school:technical_indicators:parabolic_sar
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="acceleration"></param>
        /// <param name="maximum"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> ParabolicSar(Frequency unitType, int historiesLength, int acceleration, int maximum);

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
        ITaLibOutput<IList<double>> ParabolicSarExtended(Frequency unitType, int historiesLength, int startvalue, int offsetonreverse, int accelerationinitlong, int accelerationlong, int accelerationmaxlong, int accelerationinitshort, int accelerationshort, int accelerationmaxshort);

        /// <summary>
        /// https://www.investopedia.com/terms/s/sma.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> SimpleMovingAverage(Frequency unitType, int historiesLength, int timePeriod);

        /// <summary>
        /// NOTE: The T3 function has an unstable period.
        /// https://www.tradingtechnologies.com/help/x-study/technical-indicator-definitions/t3-t3/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <param name="vFactor"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> TripleExponentialMovingAverageT3(Frequency unitType, int historiesLength, int timePeriod, int vFactor);

        /// <summary>
        /// https://www.investopedia.com/terms/t/triple-exponential-moving-average.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> TripleExponentialMovingAverage(Frequency unitType, int historiesLength, int timePeriod);

        /// <summary>
        /// http://www.onlinetradingconcepts.com/TechnicalAnalysis/MATriangular.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> TriangularMovingAverage(Frequency unitType, int historiesLength, int timePeriod);

        /// <summary>
        /// https://www.investopedia.com/articles/technical/060401.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> WeightedMovingAverage(Frequency unitType, int historiesLength, int timePeriod);
    }
}
