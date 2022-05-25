using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain;
using Lana_jewelry.Infra;
using Lana_jewelry.Infra.Initializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Infra.Initializers{
    [TestClass] public class NecklacesInitializerTests
       : SealedBaseTests<NecklacesInitializer, BaseInitializer<NecklaceData>> {
        protected override NecklacesInitializer createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            return new NecklacesInitializer(db);
        }
    }
}
