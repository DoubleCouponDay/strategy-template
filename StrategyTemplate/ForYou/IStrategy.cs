using StrategyTemplate.ForYou.Indicators;

namespace StrategyTemplate.ForYou
{
    public interface IStrategy
    {
        /// <summary>
        /// Parameters are tools and information provided by moon machine.
        /// </summary>
        /// <param name="currentTicker"></param>
        /// <param name="taLibWrapper"></param>
        /// <param name="currentSecondaryExposure"></param>
        /// <returns></returns>
        StrategiesDecision GetStrategiesVerdict(GraphBar currentTicker,Iindicators taLibWrapper, double currentSecondaryExposure);
    }
}
