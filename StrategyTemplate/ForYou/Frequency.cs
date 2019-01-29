using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou
{
    /// <summary>
    /// Each matches an accepted input for postgresql's EXTRACT FUNCTION's "field" parameter.
    /// </summary>
    public enum Frequency
    {
        day,
        hour,
        month,
        week
    }
}
