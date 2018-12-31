using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyTemplate.ForYou.Indicators.Groups;

namespace StrategyTemplate.ForYou.Indicators
{
    public interface Iindicators
    {
        IList<GraphBar> CurrentHistory {get;}

        ICycles Cycles {get;}
        IMomentums Momentums {get;}
        IOverlapStudies OverlapStudies {get;}
        IPatterns Patterns {get;}
        IPriceTransforms PriceTransforms {get;}
        IVolatilities Volatilities {get;}
        IVolumes Volumes {get;}
        IStatistics Statistics { get;}

        /// <summary>
        /// Set whether the indicator should use database history or custom history. updates the CurrentHistory property
        /// </summary>
        /// <param name="historyIsCustom"></param>
        /// <param name="history"></param>
        void ToggleManualHistoryToggle(bool historyIsCustom, IList<GraphBar> history = null);

        /// <summary>
        /// Combine startingIndex with historiesLength to customize your indicators range.
        /// </summary>
        /// <param name="startingindex"></param>
        /// <param name="endindex"></param>
        void SetManualRange(int startingindex = 0);
    }
}
