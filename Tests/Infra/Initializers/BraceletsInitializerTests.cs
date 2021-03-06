using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain;
using Lana_jewelry.Infra;
using Lana_jewelry.Infra.Initializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Infra.Initializers{
    [TestClass] public class BraceletsInitializerTests
       : SealedBaseTests<BraceletsInitializer, BaseInitializer<BraceletData>> {
        protected override BraceletsInitializer createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            return new BraceletsInitializer(db);
        }
    }
}
