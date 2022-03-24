using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Lana_jewelry.Tests
{
    public abstract class TestAsserts{
      protected static void isTrue(bool? b, string? message=null) => Assert.IsTrue(b ?? false, message?? string.Empty);
      protected static void isFalse(bool? b, string? message = null) => Assert.IsFalse(b ?? true, message ?? string.Empty);
      protected static void isInconclusive(string? s=null) => Assert.Inconclusive(s ?? string.Empty);
      protected static void isNotNull([NotNull] object? o = null) => Assert.IsNotNull(o);
      protected static void areEqual(object? expected, object? actual, string? message = null) => Assert.AreEqual(expected, actual);
        protected static void areNotEqual(object? expected, object? actual, string? message = null) => Assert.AreNotEqual(expected, actual);
        protected static void isInstanceOfType(object o, Type expectedType) => Assert.IsInstanceOfType(o, expectedType);
    }
}
