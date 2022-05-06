using Lana_jewelry.Aids;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Infra {
    [TestClass] public class OrderedRepoTests
        : AbstractClassTests<OrderedRepo<GiftCard, GiftCardData>, OrderedRepo<GiftCard, GiftCardData>> {
        private class testClass : OrderedRepo<GiftCard, GiftCardData> {
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s) { }
            protected internal override GiftCard toDomain(GiftCardData d) => new(d);
        }
        protected override OrderedRepo<GiftCard, GiftCardData> createObj() => new testClass(null, null);
        [TestMethod] public void CurrentOrderTest() => isProperty<string?>();
        [TestMethod] public void DescendingStringTest() => areEqual("_desc", testClass.DescendingString);

        [DataRow(null, true)]
        [DataRow(null, false)]
        [DataRow(nameof(GiftCard.Id), true)]
        [DataRow(nameof(GiftCard.Id), false)]
        [DataRow(nameof(GiftCard.Price), true)]
        [DataRow(nameof(GiftCard.Price), false)]
        [TestMethod] public void CreateSqlTest(string s, bool isDescending) {
            obj.CurrentOrder = (s is null) ? s : isDescending ? s + testClass.DescendingString : s;
            var q = obj.createSql();
            var actual = q.Expression.ToString();
            if (s is null) isTrue(actual.EndsWith(".Select(s => s)"));
            else if (isDescending) isTrue(actual.EndsWith(
                $".Select(s => s).OrderByDescending(x => Convert(x.{s}, Object))"));
            else isTrue(actual.EndsWith(
                $".Select(s => s).OrderBy(x => Convert(x.{s}, Object))"));

        }
      
        [DataRow(true, true)]
        [DataRow(false, true)]
        [DataRow(true, false)]
        [DataRow(false, false)]
        [TestMethod] public void SortOrderTest(bool isDescending, bool isSame) {
            var s = GetRandom.String();
            var c = isSame ? s : GetRandom.String();
            obj.CurrentOrder= isDescending ? c + testClass.DescendingString : c;
            var actual = obj.SortOrder(s);
            var sDes = s + testClass.DescendingString;
            var expected = isSame ? (isDescending ? s : sDes) : sDes;
            areEqual(expected, actual);
        }
    }
}
