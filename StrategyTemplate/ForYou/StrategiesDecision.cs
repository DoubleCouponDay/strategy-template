using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou
{
    public struct StrategiesDecision
    {
        public Verdict Verdict {get; private set; }
        public double PercentageToCommit {get; private set;}

        public StrategiesDecision(Verdict verdict, double percentageToCommit)
        {
            this.Verdict = verdict;
            this.PercentageToCommit = percentageToCommit;
        }
    }
}
