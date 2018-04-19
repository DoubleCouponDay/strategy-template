using System;
using System.Collections.Generic;
using System.Reflection;

namespace StrategyTemplate.Documentation
{
    /// <summary>
    /// Shows all members, types, namepspaces that are available for use in a moon machine strategy.
    /// For educational purposes only.
    /// </summary>
    public static class Whitelist
    {
        public static HashSet<MemberInfo> Members = new HashSet<MemberInfo> {
            typeof(ValueType).GetMethod("ToString"),
            typeof(Type).GetProperty("FullName"),
            typeof(ValueType).GetMethod("Equals"),
            typeof(ValueType).GetMethod("GetHashCode"),
        };

        public static HashSet<Type> Types = new HashSet<Type> {
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
            typeof(decimal),
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
        };

        public static HashSet<string> Namespaces = new HashSet<string> {
            typeof(System.Collections.IEnumerator).Namespace,
            typeof(System.Collections.Generic.IEnumerable<>).Namespace,
            typeof(System.Collections.Concurrent.ConcurrentDictionary<,>).Namespace,
            typeof(System.Linq.Enumerable).Namespace,
            typeof(System.Text.StringBuilder).Namespace,
            typeof(System.Text.RegularExpressions.Regex).Namespace,
            typeof(System.Globalization.Calendar).Namespace,
            typeof(StrategyTemplate.ForYou.Verdict).Namespace,
            //typeof(TicTacTec.TA.Library.Core).Namespace //waiting for internet access
        };
    }
}
