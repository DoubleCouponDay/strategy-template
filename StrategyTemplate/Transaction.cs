using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate
{
    /// <summary>
    /// Provides a record of a Strategies' action.
    /// </summary>
    public class Transaction
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
