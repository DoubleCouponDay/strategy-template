using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacTec.TA.Library;

namespace StrategyTemplate.ForYou.Indicators.Groups
{
    public interface IMomentums
    {
        /// <summary>
        /// NOTE: The ADX function has an unstable period.
        /// http://stockcharts.com/school/doku.php?id=chart_school:technical_indicators:average_directional_index_adx
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> AverageDirectionalMovementIndex(Frequency unitType,int historiesLength,int timePeriod = 14);

        /// <summary>
        /// NOTE: The ADXR function has an unstable period.
        /// https://www.marketvolume.com/technicalanalysis/adxr.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> AverageDirectionalMovementIndexRating(Frequency unitType,int historiesLength,int timePeriod = 14);

        /// <summary>
        /// https://www.fidelity.com/learning-center/trading-investing/technical-analysis/technical-indicator-guide/apo
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="movingAverageType"></param>
        /// <param name="slowPeriod"></param>
        /// <param name="fastPeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> AbsolutePriceOscillator(Frequency unitType, int historiesLength, Core.MAType movingAverageType = Core.MAType.Sma, int slowPeriod = 26, int fastPeriod = 12);

        /// <summary>
        /// http://stockcharts.com/school/doku.php?id=chart_school:technical_indicators:aroon
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<(IList<double> aroonDown, IList<double> aroonUp)> Aroon(Frequency unitType,int historiesLength,int timePeriod = 14);

        /// <summary>
        /// https://www.investopedia.com/terms/a/aroonoscillator.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> AroonOscillator(Frequency unitType,int historiesLength,int timePeriod = 14);

        /// <summary>
        /// http://tradeforextrading.com/index.php/balance-power-indicator
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> BalanceOfPower(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/c/commoditychannelindex.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> CommodityChannelIndex(Frequency unitType,int historiesLength,int timePeriod = 14);

        /// <summary>
        /// NOTE: The CMO function has an unstable period.
        /// https://www.investopedia.com/terms/c/chandemomentumoscillator.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> ChandeMomentumOscillator(Frequency unitType,int historiesLength,int timePeriod = 14);

        /// <summary>
        /// NOTE: The DX function has an unstable period.
        /// https://www.investopedia.com/terms/d/dmi.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>>DirectionalMovementIndex(Frequency unitType,int historiesLength,int timePeriod = 14);

        /// <summary>
        /// https://www.investopedia.com/terms/m/macd.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="fastMaType"></param>
        /// <param name="slowMaType"></param>
        /// <param name="signalMaType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="fastPeriod"></param>
        /// <param name="slowPeriod"></param>
        /// <param name="signalPeriod"></param>
        /// <returns></returns>
        ITaLibOutput<(IList<double> macd, IList<double> macdSignal, IList<double> macdHistory)>MovingAverageConvergenceDivergence(Frequency unitType, int historiesLength, Core.MAType fastMaType = Core.MAType.Sma, Core.MAType slowMaType = Core.MAType.Sma, Core.MAType signalMaType = Core.MAType.Sma, int fastPeriod = 12, int slowPeriod = 26,int signalPeriod = 9);

        /// <summary>
        /// NOTE: The MFI function has an unstable period.
        /// https://www.investopedia.com/terms/m/mfi.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>>MoneyFlowIndex(Frequency unitType,int historiesLength,int timePeriod = 14);

        /// <summary>
        /// NOTE: The MINUS_DI function has an unstable period.
        /// https://www.investopedia.com/terms/n/negativedirectionalindicator.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>>MinusDirectionalIndicator(Frequency unitType,int historiesLength,int timePeriod = 14);

        /// <summary>
        /// NOTE: The MINUS_DM function has an unstable period.
        /// https://www.investopedia.com/terms/n/negativedirectionalindicator.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>>MinusDirectionalMovement(Frequency unitType,int historiesLength,int timePeriod = 14);

        /// <summary>
        /// https://www.investopedia.com/terms/m/momentum.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>>Momentum(Frequency unitType,int historiesLength,int timePeriod = 10);

        /// <summary>
        /// NOTE: The PLUS_DI function has an unstable period.
        /// https://www.investopedia.com/terms/p/positivedirectionalindicator.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>>PlusDirectionalIndicator(Frequency unitType,int historiesLength,int timePeriod = 14);

        /// <summary>
        /// NOTE: The PLUS_DM function has an unstable period.
        /// https://www.investopedia.com/terms/p/positivedirectionalindicator.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>>PlusDirectionalMovement(Frequency unitType,int historiesLength,int timePeriod = 14);

        /// <summary>
        /// https://www.investopedia.com/terms/p/ppo.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="MovingAverageType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="fastPeriod"></param>
        /// <param name="slowPeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>>PercentagePriceOscillator(Frequency unitType, int historiesLength, Core.MAType MovingAverageType = Core.MAType.Sma, int fastPeriod = 12,int slowPeriod = 26);

        /// <summary>
        /// https://www.investopedia.com/terms/p/pricerateofchange.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>>RateOfChange(Frequency unitType,int historiesLength,int timePeriod = 10);

        /// <summary>
        /// https://www.investopedia.com/terms/p/pricerateofchange.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>>RateOfChangePercentage(Frequency unitType,int historiesLength,int timePeriod = 10);

        /// <summary>
        /// https://www.investopedia.com/terms/p/pricerateofchange.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>>RateOfChangeRatio(Frequency unitType,int historiesLength,int timePeriod = 10);

        /// <summary>
        /// NOTE: The RSI function has an unstable period.
        /// https://www.investopedia.com/terms/r/rsi.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>>RelativeStrengthIndex(Frequency unitType,int historiesLength,int timePeriod = 14);

        /// <summary>
        /// https://www.investopedia.com/terms/s/stochasticoscillator.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="slowKMaType"></param>
        /// <param name="slowDMaType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="fastKPeriod"></param>
        /// <param name="slowKPeriod"></param>
        /// <param name="slowDPeriod"></param>
        /// <returns></returns>
        ITaLibOutput<(IList<double> slowK, IList<double> slowD)>Stochastic(Frequency unitType, int historiesLength, Core.MAType slowKMaType = Core.MAType.Sma, Core.MAType slowDMaType = Core.MAType.Sma, int fastKPeriod = 5, int slowKPeriod = 3, int slowDPeriod = 3);

        /// <summary>
        /// https://www.fidelity.com/learning-center/trading-investing/technical-analysis/technical-indicator-guide/fast-stochastic
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="fastDMaType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="fastKPeriod"></param>
        /// <param name="fastDPeriod"></param>
        /// <returns></returns>
        ITaLibOutput<(IList<double> fastK, IList<double> fastD)> StochasticFast(Frequency unitType, int historiesLength,  Core.MAType fastDMaType = Core.MAType.Sma, int fastKPeriod = 5, int fastDPeriod = 3);
        
        /// <summary>
        /// NOTE: The STOCHRSI function has an unstable period.
        /// https://www.investopedia.com/terms/s/stochrsi.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="fastDMaType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <param name="fastKPeriod"></param>
        /// <param name="fastDPeriod"></param>
        /// <returns></returns>
        ITaLibOutput<(IList<double> fastK, IList<double> fastD)> StochasticRelativeStrengthIndex(Frequency unitType, int historiesLength, Core.MAType fastDMaType = Core.MAType.Sma, int timePeriod = 14, int fastKPeriod = 5, int fastDPeriod = 0);

        /// <summary>
        /// http://stockcharts.com/school/doku.php?id=chart_school:technical_indicators:trix
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> TripleSmoothExponentialMovingAverage(Frequency unitType,int historiesLength,int timePeriod = 30);
        
        /// <summary>
        /// https://www.stockalyze.com/hlp/indicators/topics/momentum_indicators/ultosc.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod1"></param>
        /// <param name="timePeriod2"></param>
        /// <param name="timePeriod3"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> UltimateOscillator(Frequency unitType,int historiesLength,int timePeriod1 = 7, int timePeriod2 = 14, int timePeriod3 = 28);

        /// <summary>
        /// https://www.investopedia.com/terms/w/williamsr.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<IList<double>> WilliamsR(Frequency unitType,int historiesLength,int timePeriod = 14);
    }
}
