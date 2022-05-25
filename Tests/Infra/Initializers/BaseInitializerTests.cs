using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Infra;
using Lana_jewelry.Infra.Initializers;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Lana_jewelry.Tests.Infra.Initializers{
    [TestClass] public class BaseInitializerTests
       : AbstractClassTests<BaseInitializer<GiftCardData>, object> {
        private class testClass : BaseInitializer<GiftCardData> {
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s) { }
            protected override IEnumerable<GiftCardData> getEntities => throw new System.NotImplementedException();
        }
        protected override BaseInitializer<GiftCardData> createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            var set = db?.GiftCards;
            return new testClass(db,set);
        }
    }
}
