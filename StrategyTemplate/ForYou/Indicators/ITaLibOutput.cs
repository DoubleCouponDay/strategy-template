using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacTec.TA.Library;

namespace StrategyTemplate.ForYou.Indicators
{
    public interface ITaLibOutput <TOutputSeries>
    {
        TOutputSeries Series {get;}
        Core.RetCode Outcome {get;} 
        int BeginningIndex {get;}
    }
}
