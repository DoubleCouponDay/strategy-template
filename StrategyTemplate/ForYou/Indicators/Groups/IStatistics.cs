using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou.Indicators.Groups
{
    public interface IStatistics
    {
        /// <summary>
        /// https://www.investopedia.com/terms/b/beta.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> Beta(Frequency unitType,int historiesLength, int timePeriod = 5);

        /// <summary>
        /// http://www.stockcharts.com/school/doku.php?id=chart_school:technical_indicators:correlation_coeffici
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> PearsonsCorrelationCoefficient(Frequency unitType,int historiesLength, int timePeriod = 30);

        /// <summary>
        /// https://www.fidelity.com/learning-center/trading-investing/technical-analysis/technical-indicator-guide/linear-regression
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> LinearRegression(Frequency unitType,int historiesLength, int timePeriod = 14);

        /// <summary>
        /// https://www.tradingtechnologies.com/help/x-study/technical-indicator-definitions/linear-regression-angle-lra/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> LinearRegressionAngle(Frequency unitType,int historiesLength, int timePeriod = 14);

        /// <summary>
        /// https://www.tradingtechnologies.com/help/x-study/technical-indicator-definitions/linear-regression-intercept-lri/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> LinearRegressionIntercept(Frequency unitType,int historiesLength, int timePeriod = 14);

        /// <summary>
        /// https://www.forexrealm.com/technical-analysis/technical-indicators/linear-regression-slope.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> LinearRegressionSlope(Frequency unitType,int historiesLength, int timePeriod = 14);

        /// <summary>
        /// https://www.fidelity.com/learning-center/trading-investing/technical-analysis/technical-indicator-guide/standard-deviation
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="NbDev"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> StandardDeviation(Frequency unitType,int historiesLength, int timePeriod = 5, int NbDev = 1);

        /// <summary>
        /// http://www.onlinetradingconcepts.com/TechnicalAnalysis/TimeSeriesForecast.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> TimeSeriesForecast(Frequency unitType,int historiesLength, int timePeriod = 14);

        /// <summary>
        /// https://www.investopedia.com/terms/v/variance.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <param name="nbDev"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> Variance(Frequency unitType,int historiesLength, int timePeriod = 5, int nbDev = 1);
    }
}
