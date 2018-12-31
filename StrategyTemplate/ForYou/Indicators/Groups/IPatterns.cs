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
        ITaLibOutput<int[]> TwoCrows(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/t/three_black_crows.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> ThreeBlackCrows(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://thepatternsite.com/ThreeLineStrikeBear.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> ThreeLineStrike(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/t/three-outside-updown.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> ThreeOutsideUpDown(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://thepatternsite.com/ThreeStarsSouth.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> ThreeStarsInTheSouth(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/t/three_white_soldiers.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> ThreeAdvancingWhiteSoldiers(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/b/bearish-abandoned-baby.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="penetration"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> AbandonedBaby(Frequency unitType,int historiesLength, int penetration = 0);

        /// <summary>
        /// https://www.investopedia.com/terms/a/advance-block.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> AdvanceBlock(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/b/bearishbelthold.asp
        /// https://www.investopedia.com/terms/b/bullishbelthold.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> BeltHold(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.instaforex.com/forex_indicators.php?ind=breakaway
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> Breakaway(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://forexop.com/candlesticks/marubozu/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> ClosingMarubozu(Frequency unitType,int historiesLength);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> ConcealingBabySwallow(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://www.patternsmart.com/cart/index.php?route=product/category&path=20_27
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> CounterAttack(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/d/darkcloud.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="penetration"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> DarkCloudCover(Frequency unitType,int historiesLength, int penetration = 0);

        /// <summary>
        /// http://www.ino.com/blog/2011/05/using-the-doji-indicator-to-determine-a-market-trend/#.WulMZSARXIU
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> Doji(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.forexstrategiesresources.com/candlestick-forex-strategies/19-doji-star-system/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> DojiStar(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/d/dragonfly-doji.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> DragonFlyDoji(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://fxprosystems.com/engulfing/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> EngulfingPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://www.stock-trading-infocentre.com/evening-doji-star.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="penetration"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> EveningDojiStar(Frequency unitType,int historiesLength, int penetration = 0);

        /// <summary>
        /// https://www.investopedia.com/terms/e/eveningstar.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="penetration"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> EveningStar(Frequency unitType,int historiesLength, int penetration = 0);

        /// <summary>
        /// https://www.investopedia.com/terms/u/updown-gap-sidebyside-white-lines.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> UpDownGapSideBySideWhiteLines(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/g/gravestone-doji.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> GraveStoneDoji(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/h/hammer.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> Hammer(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/h/hangingman.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> HangingMan(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.warriortrading.com/harami-candlestick-pattern-definition-day-trading-terminology/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> HaramiPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/h/haramicross.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> HaramiCrossPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://bullishbears.com/high-wave-candlesticks/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> HighWaveCandle(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/m/modified-hikkake-pattern.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> ModifiedHikkakePattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/b/bullishhomingpigeon.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> HomingPigeon(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://tlc.thinkorswim.com/center/reference/Patterns/candlestick-patterns-library/bearish-only/IdenticalThreeCrows.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> IdenticalThreeCrows(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/n/neck-pattern.asp-0
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> InNeckPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// http://www.onlinetradingconcepts.com/TechnicalAnalysis/Candlesticks/InvertedHammer.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> InvertedHamer(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.instaforex.com/forex_indicators.php?ind=kicking
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> Kicking(Frequency unitType,int historiesLength);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> KickingBullBearDeterminedByTheLongerMarubozu(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/l/ladder-bottom.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> LadderBottom(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/l/long-legged-doji.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> LongLeggedDoji(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.feedroll.com/candlestick-patterns/1138-long-line-candle-short-line-candle/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> LongLineCandle(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://en.wikipedia.org/wiki/Marubozu
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> Marubozu(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.instaforex.com/forex_indicators.php?ind=matching_low
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> MatchingLow(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/m/mat-hold-pattern.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="penetration"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> MatHold(Frequency unitType,int historiesLength, int penetration = 0);

        /// <summary>
        /// http://www.candlestickchart.com/indicators/1129.html
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <param name="penetration"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> MorningDojiStar(Frequency unitType,int historiesLength, int penetration = 0);

        /// <summary>
        /// https://www.investopedia.com/terms/m/morningstar.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> MorningStar(Frequency unitType,int historiesLength, int penetration = 0);

        /// <summary>
        /// https://www.investopedia.com/terms/n/neck-pattern.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> OnNeckPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/piercing-pattern.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> PiercingPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/r/rickshaw-man.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> RickshawMan(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/r/rising-three-methods.asp
        /// https://www.investopedia.com/terms/f/falling-three-methods.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> RisingFallingThreeMethods(Frequency unitType,int historiesLength);
        
        /// <summary>
        /// http://www.candlestickforum.com/PPF/Parameters/16_1425_/candlestick.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> SeparatingLines(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/s/shootingstar.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> ShootingStar(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/s/short-line-candle.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> ShortLineCandle(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/s/spinning-top.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> SpinningTop(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/s/stalled-pattern.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> StalledPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/s/stick-sanwich.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> StickSandwich(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.feedroll.com/candlestick-patterns/1213-takuri-line/
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> Takuri(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/u/upside-tasuki-gap.asp
        /// https://www.investopedia.com/terms/d/downside-tasuki-gap.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> TasukiGap(Frequency unitType,int historiesLength);

        /// <summary>
        ///https://www.investopedia.com/terms/t/thrusting-pattern.asp 
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> ThrustingPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/t/tri-star.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> TristarPattern(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/u/unique-three-river.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> Unique3River(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/u/upside-gap-two-crows.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> UpsideGapTwoCrows(Frequency unitType,int historiesLength);

        /// <summary>
        /// https://www.investopedia.com/terms/u/upsidedownside-gap-three-methods.asp
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> UpsideDownsideGap3Methods(Frequency unitType,int historiesLength);
    }
}
