using StrategyTemplate.ForYou;
using StrategyTemplate.ForYou.Indicators;
using System.Collections.Generic;
using TicTacTec.TA.Library;
using StrategyTemplate.Documentation;

namespace StrategyTemplate.EntryPoint
{
    public class SampleStrategy : IStrategy
    {
        public StrategiesDecision GetStrategiesVerdict(GraphBar currentTicker,
            Iindicators taLibWrapper,
            double currentSecondaryExposure)
        {
            bool macdVerdict = false;
            bool onBalanceVerdict = false;
            bool RsiVerdict = false;

            //ITaLibOutput<(IList<double> macd, IList<double> macdSignal, IList<double> macdHistory)> macd = taLibWrapper.Momentums
            //    .MovingAverageConvergenceDivergence(Frequency.DAY, 
            //    Core.MAType.Ema,
            //    historiesLength: (int)QuantityLimits.HISTORY_LENGTH, 
            //    fastPeriod: 12,
            //    slowPeriod: 26,
            //    signalPeriod: 20,
            //    );

            ITaLibOutput<IList<double>> onBalance = taLibWrapper.Volumes
                .OnBalanceVolume(Frequency.DAY, 
                historiesLength: 1);

            ITaLibOutput<IList<double>> rsi = taLibWrapper.Momentums
                .RelativeStrengthIndex(Frequency.DAY, 
                    historiesLength: (int)QuantityLimits.HISTORY_LENGTH, 
                    timePeriod: 100);

            //ITaLibOutput<(IList<double> upperBand, IList<double> middleBand, IList<double> lowerBand)> bollBands = taLibWrapper.OverlapStudies
            //    .BollingerBands(Frequency.DAY, 
            //        Core.MAType.Ema, 
            //        historiesLength: 1, 
            //        timePeriod: 100, 
            //        nbDevUp: 20,
            //        nbDevDown: 20);

            //var emaList = new List<double> (ema100.Series);
            //var stochRsiList = new List<double> (stochRsi.Series.fastK);
            //var upperBandList = new List<double> (bollBands.Series.upperBand);
            //var lowerBandList = new List<double> (bollBands.Series.lowerBand);

            if(true)
            {
                return new StrategiesDecision(Verdict.BUY, 25);
            }

            else if(true)
            {
                return new StrategiesDecision(Verdict.SELL, currentSecondaryExposure);
            }

            else
            {
                return new StrategiesDecision(Verdict.HOLD, 0);
            }
        }
    }
}
