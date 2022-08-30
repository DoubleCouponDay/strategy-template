using StrategyTemplate.Indicators;
using TALib;
using StrategyTemplate.Documentation;

namespace StrategyTemplate.EntryPoint
{
    public class CSharpSampleStrategy : IStrategy
    {
        int conditionWindowHours = 48;

        public Verdict GetStrategiesVerdict(
            GraphBar currentTicker,
            Iindicators indicators,
            Transaction lastTransaction,
            OrderBook orderBook,
            double hoardedSecurityAmount,
            double speculatedSecurityAmount,
            double feePercentage)
        {
            //Get the indicators
            var macd = indicators.Momentums
                .MovingAverageConvergenceDivergence(
                    unitType: Frequency.hour, 
                    historiesLength: (int) QuantityLimits.HISTORY_LENGTH,
                    slowMaType: Core.MAType.Ema,
                    fastMaType: Core.MAType.Sma,
                    signalMaType: Core.MAType.Ema);

            var stoch = indicators.Momentums
                .Stochastic(
                    unitType: Frequency.hour,
                    historiesLength: conditionWindowHours);

            //filter macd results to the past two days
            double[] filteredMacd = NeutralizeDataBeyondTwoDays(macd.Series.macd, macd.NBElement);
            double[] filteredHistory = NeutralizeDataBeyondTwoDays(macd.Series.macdHistory, macd.NBElement);
            double[] filteredSignal = NeutralizeDataBeyondTwoDays(macd.Series.macdSignal, macd.NBElement);
            macd.Series = (macd: filteredMacd, macdSignal: filteredSignal, macdHistory: filteredHistory);

            //define the trade conditions
            bool macdCrossedAboveSignal = false;
            bool histogramCrossedAboveSignal = false;          
            bool stochasticKCrossedOverD = false;
            bool macdConditionsOccuredBeforeStochs = false;

            for(int i = 0;i < stoch.Series.slowD.Length; i++)
            {
                if(stoch.Series.slowK[i] > stoch.Series.slowD[i])
                {
                    stochasticKCrossedOverD = true;
                }
            }

            for(int i = 0;i < filteredSignal.Length; i++)
            {
                if(filteredMacd[i] > filteredSignal[i])
                {
                    macdCrossedAboveSignal = true;   
                }

                if(filteredHistory[i] > filteredSignal[i])
                {
                    histogramCrossedAboveSignal = true;
                }

                if(macdCrossedAboveSignal &&
                    histogramCrossedAboveSignal &&
                    stochasticKCrossedOverD == false)
                {
                    macdConditionsOccuredBeforeStochs = true;
                    break;
                }
            }               

            //make the call
            if(stochasticKCrossedOverD &&
                macdCrossedAboveSignal &&
                histogramCrossedAboveSignal &&
                macdConditionsOccuredBeforeStochs)

            {
                double buyableAmount = DetermineSafeExposureAmount(orderBook, MarketAction.BUY);
                return new Verdict(MarketAction.BUY, buyableAmount);
            }

            else if(hoardedSecurityAmount != 0)
            {
                double sellableAmount = DetermineSafeExposureAmount(orderBook, MarketAction.SELL);
                return new Verdict(MarketAction.SELL, sellableAmount);
            }

            else
            {
                return new Verdict(MarketAction.HOLD, 0);
            }
        }

        double[] NeutralizeDataBeyondTwoDays(double[] data, int currentNBElement)
        {
            bool startNeutralizing = false;

            for(int i = currentNBElement; i >= 0;i++)
            {
                //neutralize data so that only the last two days remain
                if(data[i] == 0)
                {
                    startNeutralizing = true;
                }

                else if(startNeutralizing)
                {
                    data[i] = 0;
                }
            }
            return data;
        }

        double DetermineSafeExposureAmount(OrderBook orderBook, MarketAction action)
        {
            switch(action)
            {
                case MarketAction.BUY:
                    Transaction firstBuy = orderBook.BuyOrders[0];
                    
                    if(orderBook.BuyOrders.Length >= 2)
                    {
                        double secondFirstGiven = orderBook.BuyOrders[1].GivenAmount;
                        return Math.Abs(secondFirstGiven - firstBuy.GivenAmount);
                    }

                    else
                    {
                        return firstBuy.GivenAmount;
                    }

                case MarketAction.SELL:
                    Transaction lastSell = orderBook.SellOrders[0];

                    if(orderBook.SellOrders.Length >= 2)
                    {
                        double secondLastReceived = orderBook.BuyOrders[1].ReceivedAmount;
                        return Math.Abs(secondLastReceived - lastSell.ReceivedAmount);
                    }

                    else
                    {
                        return lastSell.ReceivedAmount;
                    }

                default:
                    return 0;
            }
        }
    }
}
