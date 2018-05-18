using StrategyTemplate.ForYou;
using StrategyTemplate.ForYou.Indicators;
using System.Collections.Generic;
using TicTacTec.TA.Library;
using StrategyTemplate.Documentation;
using System.Linq;
using System;

namespace StrategyTemplate.EntryPoint
{
    class SampleStrategy : IStrategy
    {
        int conditionWindowHours = 48;

        public StrategiesDecision GetStrategiesVerdict(GraphBar currentTicker,
            Iindicators taLibWrapper,
            Transaction lastTransaction,
            OrderBook currentOrderBook,
            double currentHoardedSecurityAmount,
            double currentSpeculatedSecurityAmount)
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
            IList<double> filteredMacd = NeutralizeDataBeyondTwoDays(macd.Series.macd, macd.NBElement);
            IList<double> filteredHistory = NeutralizeDataBeyondTwoDays(macd.Series.macdHistory, macd.NBElement);
            IList<double> filteredSignal = NeutralizeDataBeyondTwoDays(macd.Series.macdSignal, macd.NBElement);
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
                double sellablAmount = DetermineSafeExposureAmount(currentOrderBook, Verdict.BUY, currentHoardedSecurityAmount, currentSpeculatedSecurityAmount);
                return new StrategiesDecision(Verdict.BUY, sellablAmount);
            }

            else if(currentHoardedSecurityAmount != 0)
            {
                double sellablAmount = DetermineSafeExposureAmount(currentOrderBook, Verdict.SELL, currentHoardedSecurityAmount, currentSpeculatedSecurityAmount);
                return new StrategiesDecision(Verdict.BUY, sellablAmount);
            }

            else
            {
                return new StrategiesDecision(Verdict.HOLD, 0);
            }
        }

        IList<double> NeutralizeDataBeyondTwoDays(IList<double> data, int currentNBElement)
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

        double DetermineSafeExposureAmount(OrderBook orderBook, Verdict action, double currentHoard, double currentSpeculables)
        {
            int fingersCrossedExposureDivider = 5;

            switch(action)
            {
                case Verdict.BUY:
                    Transaction firstBuy = orderBook.BuyOrders.FirstOrDefault();

                    if(firstBuy.TransactionIsFilled)
                    {
                        try
                        {
                            double secondFirstGiven = orderBook.BuyOrders[1].GivenAmount;
                            return Math.Abs(secondFirstGiven - firstBuy.GivenAmount);
                        }

                        catch(Exception)
                        {
                            return firstBuy.GivenAmount;
                        }
                    }

                    else
                    {
                        return currentHoard / fingersCrossedExposureDivider;
                    }
                    break;

                case Verdict.SELL:
                    Transaction lastSell = orderBook.SellOrders.LastOrDefault();

                    if(lastSell.TransactionIsFilled)
                    {
                        try
                        {
                            double secondLastReceived = orderBook.BuyOrders[1].ReceivedAmount;
                            return Math.Abs(secondLastReceived - lastSell.ReceivedAmount);
                        }

                        catch(Exception)
                        {
                            return lastSell.ReceivedAmount;
                        }
                    }

                    else
                    {
                        return currentHoard / fingersCrossedExposureDivider;
                    }

                default:
                    return 0; //required by compiler
            }
        }
    }
}
