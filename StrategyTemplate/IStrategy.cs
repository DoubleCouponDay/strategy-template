using StrategyTemplate.Indicators;

namespace StrategyTemplate
{
    public interface IStrategy
    {
        /// <summary>
        /// Implement a strategy which Engine U can invoke.
        /// </summary>
        /// <param name="currentTicker"></param>
        /// <param name="indicators"></param>
        /// <param name="lastTransaction"></param>
        /// <param name="orderBook"></param>
        /// <param name="hoardedSecurityAmount"></param>
        /// <param name="speculatedSecurityAmount"></param>
        /// <param name="feePercentage"></param>
        /// <returns></returns>
        Verdict GetStrategiesVerdict(
            GraphBar currentTicker,
            Iindicators indicators,
            Transaction lastTransaction,
            OrderBook orderBook,
            double hoardedSecurityAmount,
            double speculatedSecurityAmount,
            double feePercentage
        );
    }
}
