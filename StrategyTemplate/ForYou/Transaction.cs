using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou
{
    public struct Transaction
    {
        public bool TransactionIsFilled {get; private set;}

        public int UserId
        {
            get; set;
        }
        public string CloudTransactionId
        {
            get; set;
        }

        public string MarketName
        {
            get; set;
        }

        public Verdict MarketAction
        {
            get; set;
        }

        public string SpeculatedSecuritiesName
        {
            get; set;
        }

        public string HoardedSecuritiesName
        {
            get; set;
        }

        public double GivenAmount
        {
            get; set;
        }

        public double ReceivedAmount
        {
            get; set;
        }

        public Transaction(
            int userId, 
            string cloudTransactionId, 
            string marketName, 
            Verdict marketAction, 
            string speculatedSecuritiesName,
            string hoardedSecuritiesName,
            double givenAmount,
            double receivedAmount,
            double currentExposure)
        {
            this.TransactionIsFilled = true;
            this.UserId = userId;
            this.CloudTransactionId = cloudTransactionId;
            this.MarketName = marketName;
            this.MarketAction = marketAction;
            this.SpeculatedSecuritiesName = speculatedSecuritiesName;
            this.HoardedSecuritiesName = hoardedSecuritiesName;
            this.GivenAmount = givenAmount;
            this.ReceivedAmount = receivedAmount;
        }
    }
}
