import clr
clr.AddReference("StrategyTemplate")

from StrategyTemplate import IStrategy

class Example(IStrategy):
    def __init__(self):
        self.test1 = []
