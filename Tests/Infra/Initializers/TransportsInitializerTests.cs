using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Infra;
using Lana_jewelry.Infra.Initializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Infra.Initializers{
    [TestClass] public class TransportsInitializerTests
       : SealedBaseTests<TransportInitializer, BaseInitializer<TransportData>> {
        protected override TransportInitializer createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            return new TransportInitializer(db);
        }
    }
}
