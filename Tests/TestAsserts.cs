using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace Lana_jewelry.Tests
{
    public abstract class TestAsserts{
      protected static void isTrue(bool? b, string? message=null) => Assert.IsTrue(b ?? false, message?? string.Empty);
      protected static void isFalse(bool? b, string? message = null) => Assert.IsFalse(b ?? true, message ?? string.Empty);
      protected static void isInconclusive(string? s=null) => Assert.Inconclusive(s ?? string.Empty);
      protected static void isNotNull([NotNull] object? o = null, string? message=null) => Assert.IsNotNull(o, message);
      protected static void isNull(object? o = null, string? message = null) => Assert.IsNull(o, message);
      protected static void areEqual(object? expected, object? actual, string? message = null) => Assert.AreEqual(expected, actual, message);
      protected static void areNotEqual(object? expected, object? actual, string? message = null) => Assert.AreNotEqual(expected, actual, message);
      protected static void isInstanceOfType(object o, Type expectedType) => Assert.IsInstanceOfType(o, expectedType);
        protected virtual void areEqualProperties(object? a, object? b, params string[] exclude) {
            isNotNull(a);
            isNotNull(b);
            var tA = a?.GetType();
            var tB = b?.GetType();
            foreach (var piA in tA?.GetProperties() ?? Array.Empty<PropertyInfo>()) {
                if (exclude?.Contains(piA.Name) ?? false) continue;
                var vA=piA.GetValue(a, null);  
                var piB = tB?.GetProperty(piA.Name);
                var vB = piB?.GetValue(b,null) ;
                areEqual(vA, vB, $"For property {piA.Name}.");
            }
        }
    }

}
