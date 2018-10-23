using StrategyTemplate.ForYou.Indicators;

namespace StrategyTemplate.ForYou
{
    public interface IStrategy
    {
        /// <summary>
        /// These parameters are tools and information provided by moon machine.
        /// </summary>
        /// <param name="currentTicker"></param>
        /// <param name="taLibWrapper"></param>
        /// <param name="lastTransaction"></param>
        /// <param name="currentOrderBook"></param>
        /// <param name="currentHoardedSecurityAmount"></param>
        /// <param name="currentSpeculatedSecurityAmount"></param>
        /// <param name="feepercentage"></param>
        /// <returns></returns>
        Verdict GetStrategiesVerdict(
            GraphBar currentTicker,
            Iindicators taLibWrapper, 
            transaction lastTransaction, 
            OrderBook currentOrderBook, 
            decimal currentHoardedSecurityAmount, 
            decimal currentSpeculatedSecurityAmount,
            decimal feepercentage
        );
    }
}
