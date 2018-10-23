using StrategyTemplate.ForYou;
using StrategyTemplate.ForYou.Indicators;
using System.Collections.Generic;
using TicTacTec.TA.Library;
using StrategyTemplate.Documentation;
using System.Linq;
using System;

namespace StrategyTemplate.EntryPoint
{
    public class CSharpSampleStrategy : IStrategy
    {
        int conditionWindowHours = 48;

        public Verdict GetStrategiesVerdict(GraphBar currentTicker,
            Iindicators taLibWrapper,
            transaction lastTransaction,
            OrderBook currentOrderBook,
            decimal currentHoardedSecurityAmount,
            decimal currentSpeculatedSecurityAmount,
            decimal feepercentage)
        {
            //Get the indicators
            var macd = taLibWrapper.Momentums
                .MovingAverageConvergenceDivergence(
                    unitType: Frequency.HOURS, 
                    historiesLength: (int) QuantityLimits.HISTORY_LENGTH,
                    slowMaType: Core.MAType.Ema,
                    fastMaType: Core.MAType.Sma,
                    signalMaType: Core.MAType.Ema);

            var stoch = taLibWrapper.Momentums
                .Stochastic(
                    unitType: Frequency.HOURS,
                    historiesLength: conditionWindowHours);

            //filter macd results to the past two days
            IList<decimal> filteredMacd = NeutralizeDataBeyondTwoDays(macd.Series.macd, macd.NBElement);
            IList<decimal> filteredHistory = NeutralizeDataBeyondTwoDays(macd.Series.macdHistory, macd.NBElement);
            IList<decimal> filteredSignal = NeutralizeDataBeyondTwoDays(macd.Series.macdSignal, macd.NBElement);
            macd.Series = (macd: filteredMacd, macdSignal: filteredSignal, macdHistory: filteredHistory);

            //get extra data required
            int equilibriumLine = 50;

            //define the trade conditions
            bool macdCrossedAboveSignal = false;
            bool histogramCrossedAboveSignal = false;          
            bool stochasticKCrossedOverD = false;
            bool macdConditionsOccuredBeforeStochs = false;

            for(int i = 0;i < stoch.Series.slowD.Count;i++)
            {
                if(stoch.Series.slowK[i] > stoch.Series.slowD[i])
                {
                    stochasticKCrossedOverD = true;
                }
            }

            for(int i = 0;i < filteredSignal.Count;i++)
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
                decimal sellablAmount = DetermineSafeExposureAmount(currentOrderBook, MarketAction.BUY, currentHoardedSecurityAmount, currentSpeculatedSecurityAmount);
                return new Verdict(MarketAction.BUY, sellablAmount);
            }

            else if(currentHoardedSecurityAmount != 0)
            {
                decimal sellablAmount = DetermineSafeExposureAmount(currentOrderBook, MarketAction.SELL, currentHoardedSecurityAmount, currentSpeculatedSecurityAmount);
                return new Verdict(MarketAction.BUY, sellablAmount);
            }

            else
            {
                return new Verdict(MarketAction.HOLD, 0);
            }
        }

        IList<decimal> NeutralizeDataBeyondTwoDays(IList<decimal> data, int currentNBElement)
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

        decimal DetermineSafeExposureAmount(OrderBook orderBook, MarketAction action, decimal currentHoard, decimal currentSpeculables)
        {
            int fingersCrossedExposureDivider = 5;

            switch(action)
            {
                case MarketAction.BUY:
                    transaction firstBuy = orderBook.BuyOrders.FirstOrDefault();

                    try
                    {
                        decimal secondFirstGiven = orderBook.BuyOrders[1].GivenAmount;
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
                        decimal secondLastReceived = orderBook.BuyOrders[1].ReceivedAmount;
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
