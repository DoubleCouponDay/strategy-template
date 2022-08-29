using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TALib;

namespace StrategyTemplate.Indicators.Groups
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
        ITaLibOutput<double[]> HilbertTransformDominantCyclePeriod(Frequency unitType, int historiesLength);

        /// <summary>
        /// NOTE: The HT_DCPHASE function has an unstable period.
        /// https://en.wikipedia.org/wiki/Hilbert_transform
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<double[]> HilbertTransformDominantCyclePhase(Frequency unitType, int historiesLength);

        /// <summary>
        /// NOTE: The HT_PHASOR function has an unstable period.
        /// https://en.wikipedia.org/wiki/Hilbert_transform
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<(double[] InPhase, double[] Quadrature)> HilbertTransformPhasorComponents(Frequency unitType, int historiesLength);

        /// <summary>
        /// NOTE: The HT_SINE function has an unstable period.
        /// https://en.wikipedia.org/wiki/Hilbert_transform
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<(double[] Sine, double[] LeadSine)> HilbertTransformSineWave(Frequency unitType, int historiesLength);

        /// <summary>
        /// NOTE: The HT_TRENDMODE function has an unstable period.
        /// https://en.wikipedia.org/wiki/Hilbert_transform
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="historiesLength"></param>
        /// <returns></returns>
        ITaLibOutput<int[]> HilbertTransformTrendVersusCycleMode(Frequency unitType, int historiesLength);
    }
}
