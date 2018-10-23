using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacTec.TA.Library;

namespace StrategyTemplate.ForYou.Indicators.Groups
{
    public interface ICycles
    {
        /// <summary>
        /// NOTE: The HT_DCPERIOD function has an unstable period.
        /// https://en.wikipedia.org/wiki/Hilbert_transform
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> HilbertTransformDominantCyclePeriod(Frequency unitType, int historiesLength);

        /// <summary>
        /// NOTE: The HT_DCPHASE function has an unstable period.
        /// https://en.wikipedia.org/wiki/Hilbert_transform
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<decimal>> HilbertTransformDominantCyclePhase(Frequency unitType, int historiesLength);

        /// <summary>
        /// NOTE: The HT_PHASOR function has an unstable period.
        /// https://en.wikipedia.org/wiki/Hilbert_transform
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<(IList<decimal> InPhase, IList<decimal> Quadrature)> HilbertTransformPhasorComponents(Frequency unitType, int historiesLength);

        /// <summary>
        /// NOTE: The HT_SINE function has an unstable period.
        /// https://en.wikipedia.org/wiki/Hilbert_transform
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<(IList<decimal> Sine, IList<decimal> LeadSine)> HilbertTransformSineWave(Frequency unitType, int historiesLength);

        /// <summary>
        /// NOTE: The HT_TRENDMODE function has an unstable period.
        /// https://en.wikipedia.org/wiki/Hilbert_transform
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<IList<int>> HilbertTransformTrendVersusCycleMode(Frequency unitType, int historiesLength);
    }
}
