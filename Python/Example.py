import clr
clr.AddReferenceToFileAndPath("C:\\Program Files\\dotnet\\sdk\\6.0.400\\Microsoft\\Microsoft.NET.Build.Extensions\\net461\\lib\\System.Runtime.dll")
clr.AddReferenceToFileAndPath("C:\\Users\sjsui\\.nuget\\packages\\talib.netcore\\0.4.4\\lib\\netstandard2.1\\TALib.NETCore.dll")
clr.AddReferenceToFileAndPath("..\\StrategyTemplate\\bin\\debug\\net6.0\\StrategyTemplate.dll")

from StrategyTemplate import IStrategy, Frequency, MarketAction, Verdict
from StrategyTemplate.Documentation import QuantityLimits
from TALib import Core
from System import Math

class Example(IStrategy):
    def __init__(self):
        self.conditionWindowHours = 48

    def DetermineSafeExposureAmount(self, orderBook, action):
        if(action == MarketAction.BUY):
            firstBuy = orderBook.BuyOrders[0]

            if(orderBook.BuyOrder.Length >= 2):
                secondFirstGiven = orderBook.BuyOrderes[1].GivenAmount
                return Math.Abs(secondFirstGiven - firstBuy.GivenAmount)

            else:
                return firstBuy.GivenAmount

        elif(action == MarketAction.SELL):
            lastSell = orderBook.SellOrders[0]

            if(orderBook.SellOrders.Length >= 2):
                secondLastReceived = orderBook.BuyOrders[1].ReceivedAmount
                return Math.abs(secondLastReceived - lastSell.ReceivedAmount)

            else:
                return lastSell.ReceivedAmount

        else:
            return 0.0

    def NeutralizeDataBeyondTwoDays(self, data, currentNBElement):
        startNeutralizing = False
        i = currentNBElement

        while i >= 0:
            if(data[i] == 0):
                startNeutralizing = True

            elif(startNeutralizing):
                data[i] = 0.0

        return data   

    def GetStrategiesVerdict(self, currentTicker, indicators, lastTransaction, orderBook, hoardedSecurityAmount, speculatedSecurityAmount, feePercentage):
        macd = indicators.Momentums.MovingAverageConvergenceDivergence(Frequency.hour, QuantityLimits.HISTORY_LENGTH, Core.MAType.Ema, Core.MAType.Sma, Core.MAType.Ema)
        stoch = indicators.Momentums.Stochastic(Frequency.hour, self.conditionWindowHours)
        
        filteredMacd = self.NeutralizeDataBeyondTwoDays(macd.Series.macd, macd.NBElement)
        filteredHistory = self.NeutralizeDataBeyondTwoDays(macd.Series.macdHistory, macd.NBElement)
        filteredSignal = self.NeutralizeDataBeyondTwoDays(macd.Series.macdHistory, macd.NBElement)
        
        macdCrossedAboveSignal = False
        histogramCrossedAboveSignal = False
        stochasticKCrossedOverD = False
        macdConditionsOccuredBeforeStochs = False

        for i in range(0, stoch.Series.slowD.Length):
            if(stoch.Series.slowK[i] > stoch.Series.slowD[i]):
                stochasticKCrossedOverD = True
                break

        for i in range(0, filteredSignal.Length):
            if(filteredMacd[i] > filteredSignal[i]):
                macdCrossedAboveSignal = True

            if(filteredHistory[i] > filteredSignal[i]):
                histogramCrossedAboveSignal = True

            if(macdCrossedAboveSignal and histogramCrossedAboveSignal and stochasticKCrossedOverD == False):
                macdConditionsOccuredBeforeStochs = True
                break

        if(stochasticKCrossedOverD and macdCrossedAboveSignal and histogramCrossedAboveSignal and macdConditionsOccuredBeforeStochs):
            buyableAmount = self.DetermineSafeExposureAmount(orderBook, MarketAction.BUY)
            return Verdict(MarketAction.BUY, buyableAmount)

        elif(hoardedSecurityAmount != 0):
            sellableAmount = self.DetermineSafeExposureAmount(orderBook, MarketAction.SELL)

        else:
            return Verdict(MarketAction.Hold, 0)