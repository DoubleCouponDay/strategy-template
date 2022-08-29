#include "pch.h"

#include "CPlusPlus.h"

using namespace StrategyTemplate;

ref class Example : IStrategy {
public:
	virtual StrategyTemplate::Verdict GetStrategiesVerdict(
		StrategyTemplate::GraphBar currentTicker, 
		StrategyTemplate::Indicators::Iindicators^ taLibWrapper, 
		StrategyTemplate::transaction^ lastTransaction, 
		StrategyTemplate::OrderBook^ currentOrderBook, 
		double currentHoardedSecurityAmount, 
		double currentSpeculatedSecurityAmount, 
		double feepercentage)
	{
		return StrategyTemplate::Verdict();
	}
};
