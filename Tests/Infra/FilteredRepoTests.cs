using Lana_jewelry.Aids;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Infra {
    [TestClass] public class FilteredRepoTests
        : AbstractClassTests<FilteredRepo<GiftCard, GiftCardData>, FilteredRepo<GiftCard, GiftCardData>> {
        private class testClass : FilteredRepo<GiftCard, GiftCardData> {
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s) { }
            protected internal override GiftCard toDomain(GiftCardData d) => new(d);
        }
        protected override FilteredRepo<GiftCard, GiftCardData> createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            var set = db?.GiftCards;
            return new testClass(db, set);
        }
        [TestMethod] public void CurrentFilterTest() => isProperty<string>();
        [DataRow(true)]
        [DataRow(false)]
        [TestMethod] public void CreateSqlTest(bool hasCurrentFilter) {
            obj.CurrentFilter = hasCurrentFilter ? GetRandom.String(): null;
            var q1 = obj.createSql();
            var q2 = obj.addFilter(q1);
            areEqual(q1,q2);
            var s = q1.Expression.ToString();
            isTrue(s.EndsWith(".Select(s => s)"));
        }
    }
}
