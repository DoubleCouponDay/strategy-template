namespace StrategyTemplate.ForYou
{
    public interface IStrategy
    {
        string Exchange {get;}
        string MarketPair {get;}
        Verdict GetStrategiesVerdict(GraphBar currentTicker);
    }
}
