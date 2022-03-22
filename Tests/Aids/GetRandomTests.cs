using Lana_jewelry.Aids;
using Lana_jewelry.Data.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lana_jewelry.Tests.Aids
{
    [TestClass] public class GetRandomTests : IsTypeTested {
        private void test<T>(T min, T max) where T : IComparable<T> {
            var x = GetRandom.Value(min, max);
            var y = GetRandom.Value(min, max);
            isInstanceOfType(x, typeof(T));
            isInstanceOfType(y, typeof(T));
            isTrue(x >= (min.CompareTo(max) < 0 ? min : max));
            isTrue(y >= (min.CompareTo(max) < 0 ? min : max));
            isTrue(x <= (min.CompareTo(max) < 0 ? max : min));
            isTrue(y <= (min.CompareTo(max) < 0 ? max : min));
            areNotEqual(x, y);
        }
        [DataRow(-1000, 1000)]
        [DataRow(-1000, 0)]
        [DataRow(0, 1000)]
        [DataRow(int.MaxValue - 100, int.MaxValue)]
        [DataRow(int.MinValue, int.MinValue + 100)]
        [DataRow(1000, -1000)]
        [TestMethod] public void Int32Test(int min, int max) =>test(min, max);
        [DataRow(-1000L, 1000L)]
        [DataRow(-1000L, 0L)]
        [DataRow(0L, 1000L)]
        [DataRow(long.MaxValue - 1000L, long.MaxValue)]
        [DataRow(long.MinValue, long.MinValue + 1000L)]
        [DataRow(1000L, -1000L)]
        [TestMethod] public void Int64Test(long min, long max) => test(min, max);
        [DataRow(-1000.0, 1000.0)]
        [DataRow(-1000.0, 0.0)]
        [DataRow(0.0, 1000.0)]
        [DataRow(double.MaxValue - 1.0E+308, double.MaxValue)]
        [DataRow(double.MinValue, double.MinValue + 1.0E+308)]
        [DataRow(1000.0, -1000)]
        [TestMethod] public void DoubleTest(double min, double max) => test(min, max);
        [DataRow(char.MinValue, char.MaxValue)]
        [DataRow('a', 'z')]
        [DataRow('1', 'p')]
        [DataRow('A', 'z')]
        [TestMethod] public void CharTest(char min, char max)=> test(min, max);
        [TestMethod] public void BoolTest(){
          var x = GetRandom.Bool();
          var y = GetRandom.Bool();
          var i = 0;
          while(x==y){
                y = GetRandom.Bool();
                if (i == 5) areNotEqual(x, y);
                i++;
            }
        }
        [DynamicData(nameof(DateTimeValues), DynamicDataSourceType.Property)]
        [TestMethod] public void DateTimeTest(DateTime min, DateTime max) => test(min, max);
        private static IEnumerable<object[]> DateTimeValues => new Lists<object[]>()
        {
            new object []{DateTime.Now.AddYears(-100), DateTime.Now.AddYears(100) },
            new object []{DateTime.Now.AddYears(100), DateTime.Now.AddYears(-100)},
            new object []{DateTime.MaxValue.AddYears(-100), DateTime.MaxValue},
            new object []{DateTime.MinValue, DateTime.MinValue.AddYears(100)}
        };
        [TestMethod] public void StringTest(){
            var x = GetRandom.Value<string>();
            var y = GetRandom.Value<string>();
            isInstanceOfType(x, typeof(string));
            isInstanceOfType(y, typeof(string));
            areNotEqual(x, y);
        }
        [TestMethod] public void ValueTest(){
            var x = GetRandom.Value<TransportData>()as TransportData;
            var y = GetRandom.Value<TransportData>()as TransportData;
            areNotEqual(x.Id, y.Id, nameof(x.Id));
            areNotEqual(x.CostumerAddress, y.CostumerAddress, nameof(x.CostumerAddress));
            areNotEqual(x.Price, y.Price, nameof(x.Price));
            areNotEqual(x.Duration, y.Duration, nameof(x.Price));
    }
    }
}
