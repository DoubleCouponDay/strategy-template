using StrategyTemplate.ForYou;

namespace StrategyTemplate.EntryPoint
{
    public class SampleStrategy : IStrategy
    {
        public string Exchange => throw new System.NotImplementedException();
        public string MarketPair => throw new System.NotImplementedException();

        public Verdict GetStrategiesVerdict(IGraphBar currentTicker)
        {
            throw new System.NotImplementedException();
        }
    }
}
