using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacTec.TA.Library;

namespace StrategyTemplate.ForYou.Indicators
{
    public interface ICycles : Iindicator
    {
        /// <summary>
        /// https://en.wikipedia.org/wiki/Hilbert_transform
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="typeToUse"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<(double[] test1, double[] test2)> HilbertTransformDominantCyclePeriod(Frequency unitType, int historiesLength, int timePeriod);

        /// <summary>
        /// https://en.wikipedia.org/wiki/Hilbert_transform
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="typeToUse"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<(double[] test1, double[] test2)> HilbertTransformDominantCyclePhase(Frequency unitType, int historiesLength, int timePeriod);

        /// <summary>
        /// https://en.wikipedia.org/wiki/Hilbert_transform
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="typeToUse"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <param name="outQuadrature"></param>
        /// <returns></returns>
        ITaLibOutput<(double[] test1, double[] test2)> HilbertTransformPhasorComponents(Frequency unitType, int historiesLength, int timePeriod, out double[] outQuadrature);

        /// <summary>
        /// https://en.wikipedia.org/wiki/Hilbert_transform
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="typeToUse"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <param name="outleadSine"></param>
        /// <returns></returns>
        ITaLibOutput<(double[] test1, double[] test2)> HilbertTransformSineWave(Frequency unitType, int historiesLength, int timePeriod, out double[] outleadSine);

        /// <summary>
        /// https://en.wikipedia.org/wiki/Hilbert_transform
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="typeToUse"></param>
        /// <param name="historiesLength"></param>
        /// <param name="timePeriod"></param>
        /// <returns></returns>
        ITaLibOutput<(double[] test1, double[] test2)> HilbertTransformTrendVersusCycleMode(Frequency unitType, int historiesLength, int timePeriod);
    }
}
