using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou
{
    public struct Verdict
    {
        public MarketAction action {get; private set; }
        public decimal ammounttocommit {get; private set;}

        public Verdict(MarketAction verdict, decimal percentageToCommit)
        {
            this.action = verdict;
            this.ammounttocommit = percentageToCommit;
        }
    }
}
