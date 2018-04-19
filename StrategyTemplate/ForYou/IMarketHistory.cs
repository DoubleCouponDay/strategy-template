using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou
{
    public interface IMarketHistory
    {
        IEnumerable<GraphBar> TakePageOfHistory(Frequency barType, int pageSize, int pageNumber);
        int TotalDayBars();
        int TotalHourBars();
    }
}
