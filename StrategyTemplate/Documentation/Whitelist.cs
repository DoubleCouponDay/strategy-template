using System;
using System.Collections.Generic;
using System.Reflection;
using TicTacTec.TA.Library;

namespace StrategyTemplate.Documentation
{
    /// <summary>
    /// Shows all members, types, namepspaces that are available for use in a moon machine strategy.
    /// For educational purposes only.
    /// </summary>
    public class Whitelist //fixed bug where static types cannot be used as parameters
    {
        public static HashSet<MemberInfo> Members = new HashSet<MemberInfo> {
            typeof(ValueType).GetMethod("ToString"),
            typeof(Type).GetProperty("FullName"),
            typeof(ValueType).GetMethod("Equals"),
            typeof(ValueType).GetMethod("GetHashCode"),
        };

        public static HashSet<Type> Types = new HashSet<Type> {
            typeof(IList<>),
            typeof(int),
            typeof(short),
            typeof(long),
            typeof(uint),
            typeof(ushort),
            typeof(ulong),
            typeof(double),
            typeof(float),
            typeof(bool),
            typeof(char),
            typeof(byte),
            typeof(sbyte),
            typeof(double),
            typeof(string),
            typeof(object),
            typeof(Type),
            typeof(ValueType),
            typeof(StringSplitOptions),
            typeof(DateTimeKind),
            typeof(MidpointRounding),
            typeof(EventArgs),
            typeof(StringComparer),
            typeof(MulticastDelegate),
            typeof(IDisposable),
            typeof(StringComparison),
            typeof(Math),
            typeof(Enum),
            typeof(DateTime),
            typeof(TimeSpan),
            typeof(Array),
            typeof(Nullable<>),
            typeof(IEquatable<>),
            typeof(IComparable),
            typeof(IComparable<>),
            typeof(BitConverter), 
            typeof(Random),
            typeof(Convert), 
            typeof(IEnumerable<>),
            typeof(IEnumerator<>),
            typeof(QuantityLimits),            
        };

        public static HashSet<Assembly> standardlibraryassemblies = new HashSet<Assembly> {
            typeof(System.Collections.IEnumerator).Assembly,
            typeof(System.Collections.Generic.IEnumerable<>).Assembly,
            typeof(System.Collections.Concurrent.ConcurrentDictionary<,>).Assembly,
            typeof(System.Linq.Enumerable).Assembly,
            typeof(System.Text.StringBuilder).Assembly,
            typeof(System.Text.RegularExpressions.Regex).Assembly,
            typeof(System.Globalization.Calendar).Assembly,
        };

        public static HashSet<Assembly> thirdpartyassemblies = new HashSet<Assembly>
        {
            typeof(StrategyTemplate.ForYou.MarketAction).Assembly,
            typeof(TicTacTec.TA.Library.Core).Assembly,
        };
    }
}
