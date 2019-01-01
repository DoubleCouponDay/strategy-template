using StrategyTemplate.ForYou;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou
{
    /// <summary>
    /// The point of this class is to give the user a trimmed down record within their strategy.
    /// </summary>
    public class transaction
    {
        public string CloudTransactionId { get; set; }

        public MarketAction MarketAction { get; set; }

        public double amountcommited { get; set; }

        public string HoardedCurrency { get; set; }

        public string PriceCurrency { get; set; }

        public double ReceivedAmount { get; set; }

        public double GivenAmount { get; set; }

        public double CurrentExposure { get; set; }

        public DateTime Date { get; set; }
    }
}
