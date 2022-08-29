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
            Iindicators taLibWrapper,
            transaction lastTransaction,
            OrderBook currentOrderBook,
            double currentHoardedSecurityAmount,
            double currentSpeculatedSecurityAmount,
            double feepercentage)
        {
            //Get the indicators
            var macd = taLibWrapper.Momentums
                .MovingAverageConvergenceDivergence(
                    unitType: Frequency.hour, 
                    historiesLength: (int) QuantityLimits.HISTORY_LENGTH,
                    slowMaType: Core.MAType.Ema,
                    fastMaType: Core.MAType.Sma,
                    signalMaType: Core.MAType.Ema);

            var stoch = taLibWrapper.Momentums
                .Stochastic(
                    unitType: Frequency.hour,
                    historiesLength: conditionWindowHours);

            //filter macd results to the past two days
            double[] filteredMacd = NeutralizeDataBeyondTwoDays(macd.Series.macd, macd.NBElement);
            double[] filteredHistory = NeutralizeDataBeyondTwoDays(macd.Series.macdHistory, macd.NBElement);
            double[] filteredSignal = NeutralizeDataBeyondTwoDays(macd.Series.macdSignal, macd.NBElement);
            macd.Series = (macd: filteredMacd, macdSignal: filteredSignal, macdHistory: filteredHistory);

            //get extra data required
            int equilibriumLine = 50;

            //define the trade conditions
            bool macdCrossedAboveSignal = false;
            bool histogramCrossedAboveSignal = false;          
            bool stochasticKCrossedOverD = false;
            bool macdConditionsOccuredBeforeStochs = false;

            for(int i = 0;i < stoch.Series.slowD.Count();i++)
            {
                if(stoch.Series.slowK[i] > stoch.Series.slowD[i])
                {
                    stochasticKCrossedOverD = true;
                }
            }

            for(int i = 0;i < filteredSignal.Count(); i++)
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
                }
            }               

            //make the call
            if(stochasticKCrossedOverD &&
                macdCrossedAboveSignal &&
                histogramCrossedAboveSignal &&
                macdConditionsOccuredBeforeStochs)

            {
                double sellablAmount = DetermineSafeExposureAmount(currentOrderBook, MarketAction.BUY, currentHoardedSecurityAmount, currentSpeculatedSecurityAmount);
                return new Verdict(MarketAction.BUY, sellablAmount);
            }

            else if(currentHoardedSecurityAmount != 0)
            {
                double sellablAmount = DetermineSafeExposureAmount(currentOrderBook, MarketAction.SELL, currentHoardedSecurityAmount, currentSpeculatedSecurityAmount);
                return new Verdict(MarketAction.BUY, sellablAmount);
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

                if(startNeutralizing)
                {
                    data[i] = 0;
                }
            }
            return data;
        }

        double DetermineSafeExposureAmount(OrderBook orderBook, MarketAction action, double currentHoard, double currentSpeculables)
        {
            int fingersCrossedExposureDivider = 5;

            switch(action)
            {
                case MarketAction.BUY:
                    transaction firstBuy = orderBook.BuyOrders.FirstOrDefault();

                    try
                    {
                        double secondFirstGiven = orderBook.BuyOrders[1].GivenAmount;
                        return Math.Abs(secondFirstGiven - firstBuy.GivenAmount);
                    }

                    catch(Exception)
                    {
                        return firstBuy.GivenAmount;
                    }

                case MarketAction.SELL:
                    transaction lastSell = orderBook.SellOrders.LastOrDefault();

                    try
                    {
                        double secondLastReceived = orderBook.BuyOrders[1].ReceivedAmount;
                        return Math.Abs(secondLastReceived - lastSell.ReceivedAmount);
                    }

                    catch(Exception)
                    {
                        return lastSell.ReceivedAmount;
                    }

                default:
                    return 0; //required by compiler
            }
        }
    }
}
