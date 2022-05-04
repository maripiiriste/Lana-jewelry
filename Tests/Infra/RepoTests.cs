using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Infra {
    [TestClass] public class RepoTests
        : AbstractClassTests<Repo<GiftCard, GiftCardData>, PagedRepo<GiftCard, GiftCardData>> {
        private class testClass : Repo<GiftCard, GiftCardData>{
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s){}
            protected internal override GiftCard toDomain(GiftCardData d)=> new (d);
        }
        protected override Repo<GiftCard, GiftCardData> createObj() => new testClass(null, null);
    }

    [TestClass] public class CrudRepoTests
        :AbstractClassTests<CrudRepo<GiftCard, GiftCardData>, BaseRepo<GiftCard, GiftCardData>> {
        private class testClass : CrudRepo<GiftCard, GiftCardData> {
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s) { }
            protected internal override GiftCard toDomain(GiftCardData d) => new(d);
        }
        protected override CrudRepo<GiftCard, GiftCardData> createObj() => new testClass(null, null);
    }
    [TestClass] public class FilteredRepoTests
        : AbstractClassTests<FilteredRepo<GiftCard, GiftCardData>, FilteredRepo<GiftCard, GiftCardData>> {
        private class testClass : FilteredRepo<GiftCard, GiftCardData> {
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s) { }
            protected internal override GiftCard toDomain(GiftCardData d) => new(d);
        }
        protected override FilteredRepo<GiftCard, GiftCardData> createObj() => new testClass(null, null);
    }
    [TestClass] public class OrderedRepoTests
        : AbstractClassTests<OrderedRepo<GiftCard, GiftCardData>, OrderedRepo<GiftCard, GiftCardData>> {
        private class testClass : OrderedRepo<GiftCard, GiftCardData> {
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s) { }
            protected internal override GiftCard toDomain(GiftCardData d) => new(d);
        }
        protected override OrderedRepo<GiftCard, GiftCardData> createObj() => new testClass(null, null);
    }
    [TestClass] public class PagedRepoTests
        : AbstractClassTests<PagedRepo<GiftCard, GiftCardData>, PagedRepo<GiftCard, GiftCardData>> {
        private class testClass : PagedRepo<GiftCard, GiftCardData> {
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s) { }
            protected internal override GiftCard toDomain(GiftCardData d) => new(d);
        }
        protected override PagedRepo<GiftCard, GiftCardData> createObj() => new testClass(null, null);
    }
    [TestClass] public class Lana_jewelryDbTests : SealedBaseTests<Lana_jewelryDb, DbContext> {
        protected override Lana_jewelryDb createObj() => null;
        protected override void isSealedTest() => isInconclusive();
    }
}
