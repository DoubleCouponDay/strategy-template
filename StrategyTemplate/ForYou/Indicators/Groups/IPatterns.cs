using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou.Indicators.Groups
{
    public interface IPatterns
    {
        /// <summary>
        /// http://thepatternsite.com/TwoCrows.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> TwoCrows(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/t/three_black_crows.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> ThreeBlackCrows(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://thepatternsite.com/ThreeLineStrikeBear.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> ThreeLineStrike(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/t/three-outside-updown.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> ThreeOutsideUpDown(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://thepatternsite.com/ThreeStarsSouth.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> ThreeStarsInTheSouth(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/t/three_white_soldiers.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> ThreeAdvancingWhiteSoldiers(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/b/bearish-abandoned-baby.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="penetration"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> AbandonedBaby(Frequency unitType,int historiesLength, int penetration = 0);

        /// <summary>
        /// https://www.investopedia.com/terms/a/advance-block.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> AdvanceBlock(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/b/bearishbelthold.asp
        /// https://www.investopedia.com/terms/b/bullishbelthold.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> BeltHold(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.instaforex.com/forex_indicators.php?ind=breakaway
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> Breakaway(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://forexop.com/candlesticks/marubozu/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> ClosingMarubozu(Frequency unitType,int historiesLength);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> ConcealingBabySwallow(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://www.patternsmart.com/cart/index.php?route=product/category&path=20_27
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> CounterAttack(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/d/darkcloud.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="penetration"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> DarkCloudCover(Frequency unitType,int historiesLength, int penetration = 0);

        /// <summary>
        /// http://www.ino.com/blog/2011/05/using-the-doji-indicator-to-determine-a-market-trend/#.WulMZSARXIU
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> Doji(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.forexstrategiesresources.com/candlestick-forex-strategies/19-doji-star-system/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> DojiStar(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/d/dragonfly-doji.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> DragonFlyDoji(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://fxprosystems.com/engulfing/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> EngulfingPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://www.stock-trading-infocentre.com/evening-doji-star.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="penetration"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> EveningDojiStar(Frequency unitType,int historiesLength, int penetration = 0);

        /// <summary>
        /// https://www.investopedia.com/terms/e/eveningstar.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="penetration"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> EveningStar(Frequency unitType,int historiesLength, int penetration = 0);

        /// <summary>
        /// https://www.investopedia.com/terms/u/updown-gap-sidebyside-white-lines.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> UpDownGapSideBySideWhiteLines(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/g/gravestone-doji.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> GraveStoneDoji(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/h/hammer.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> Hammer(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/h/hangingman.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> HangingMan(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.warriortrading.com/harami-candlestick-pattern-definition-day-trading-terminology/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> HaramiPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/h/haramicross.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> HaramiCrossPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://bullishbears.com/high-wave-candlesticks/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> HighWaveCandle(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/m/modified-hikkake-pattern.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> ModifiedHikkakePattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/b/bullishhomingpigeon.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> HomingPigeon(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://tlc.thinkorswim.com/center/reference/Patterns/candlestick-patterns-library/bearish-only/IdenticalThreeCrows.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> IdenticalThreeCrows(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/n/neck-pattern.asp-0
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> InNeckPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://www.onlinetradingconcepts.com/TechnicalAnalysis/Candlesticks/InvertedHammer.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> InvertedHamer(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.instaforex.com/forex_indicators.php?ind=kicking
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> Kicking(Frequency unitType,int historiesLength);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> KickingBullBearDeterminedByTheLongerMarubozu(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/l/ladder-bottom.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> LadderBottom(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/l/long-legged-doji.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> LongLeggedDoji(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.feedroll.com/candlestick-patterns/1138-long-line-candle-short-line-candle/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> LongLineCandle(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://en.wikipedia.org/wiki/Marubozu
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> Marubozu(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.instaforex.com/forex_indicators.php?ind=matching_low
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> MatchingLow(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/m/mat-hold-pattern.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="penetration"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> MatHold(Frequency unitType,int historiesLength, int penetration = 0);

        /// <summary>
        /// http://www.candlestickchart.com/indicators/1129.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="penetration"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> MorningDojiStar(Frequency unitType,int historiesLength, int penetration = 0);

        /// <summary>
        /// https://www.investopedia.com/terms/m/morningstar.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> MorningStar(Frequency unitType,int historiesLength, int penetration = 0);

        /// <summary>
        /// https://www.investopedia.com/terms/n/neck-pattern.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> OnNeckPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/piercing-pattern.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> PiercingPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/r/rickshaw-man.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> RickshawMan(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/r/rising-three-methods.asp
        /// https://www.investopedia.com/terms/f/falling-three-methods.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> RisingFallingThreeMethods(Frequency unitType,int historiesLength);
        
        /// <summary>
        /// http://www.candlestickforum.com/PPF/Parameters/16_1425_/candlestick.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> SeparatingLines(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/s/shootingstar.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> ShootingStar(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/s/short-line-candle.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> ShortLineCandle(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/s/spinning-top.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> SpinningTop(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/s/stalled-pattern.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> StalledPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/s/stick-sanwich.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> StickSandwich(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.feedroll.com/candlestick-patterns/1213-takuri-line/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> Takuri(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/u/upside-tasuki-gap.asp
        /// https://www.investopedia.com/terms/d/downside-tasuki-gap.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> TasukiGap(Frequency unitType,int historiesLength);

        /// <summary>
        ///https://www.investopedia.com/terms/t/thrusting-pattern.asp 
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> ThrustingPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/t/tri-star.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> TristarPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/u/unique-three-river.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> Unique3River(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/u/upside-gap-two-crows.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> UpsideGapTwoCrows(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/u/upsidedownside-gap-three-methods.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> UpsideDownsideGap3Methods(Frequency unitType,int historiesLength);
    }
}
