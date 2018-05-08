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
        ITaLibOutput<IList<double>> Beta(Frequency unitType,int historiesLength, int timePeriod);

        /// <summary>
        /// http://www.stockcharts.com/school/doku.php?id=chart_school:technical_indicators:correlation_coeffici
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> PearsonsCorrelationCoefficient(Frequency unitType,int historiesLength, int timePeriod);

        /// <summary>
        /// https://www.fidelity.com/learning-center/trading-investing/technical-analysis/technical-indicator-guide/linear-regression
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> LinearRegression(Frequency unitType,int historiesLength, int timePeriod);

        /// <summary>
        /// https://www.tradingtechnologies.com/help/x-study/technical-indicator-definitions/linear-regression-angle-lra/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> LinearRegressionAngle(Frequency unitType,int historiesLength, int timePeriod);

        /// <summary>
        /// https://www.tradingtechnologies.com/help/x-study/technical-indicator-definitions/linear-regression-intercept-lri/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> LinearRegressionIntercept(Frequency unitType,int historiesLength, int timePeriod);

        /// <summary>
        /// https://www.forexrealm.com/technical-analysis/technical-indicators/linear-regression-slope.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> LinearRegressionSlope(Frequency unitType,int historiesLength, int timePeriod);

        /// <summary>
        /// https://www.fidelity.com/learning-center/trading-investing/technical-analysis/technical-indicator-guide/standard-deviation
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="NbDev"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> StandardDeviation(Frequency unitType,int historiesLength, int timePeriod, int NbDev);

        /// <summary>
        /// http://www.onlinetradingconcepts.com/TechnicalAnalysis/TimeSeriesForecast.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> TimeSeriesForecast(Frequency unitType,int historiesLength, int timePeriod);

        /// <summary>
        /// https://www.investopedia.com/terms/v/variance.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <param name="nbDev"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> Variance(Frequency unitType,int historiesLength, int timePeriod, int nbDev);
    }
}
