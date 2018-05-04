using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.Documentation
{
    public enum QuantityLimits
    {
        /// <summary>
        /// User scripts cannot use an indicator with automatic history who's length is greater than this.
        /// </summary>
        HISTORY_LENGTH = 300,

        /// <summary>
        /// User scripts cannot Execute for longer than this.
        /// </summary>
        EXECUTION_SECONDS = 2,

        /// <summary>
        /// User script file cannot be larger than this.
        /// </summary>
        SCRIPT_MEGA_BYTES = 5
    }
}
