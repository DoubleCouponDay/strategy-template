import clr
clr.AddReferenceToFileAndPath("C:\\Program Files\\dotnet\\sdk\\6.0.400\\Microsoft\\Microsoft.NET.Build.Extensions\\net461\\lib\\System.Runtime.dll")
clr.AddReferenceToFileAndPath("..\\StrategyTemplate\\bin\\debug\\net6.0\\StrategyTemplate.dll")

from StrategyTemplate import IStrategy

class Example(IStrategy):
    def __init__(self):
        self.test1 = []
