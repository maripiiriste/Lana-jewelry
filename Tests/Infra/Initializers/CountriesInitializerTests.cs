using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Infra;
using Lana_jewelry.Infra.Initializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Infra.Initializers{
    [TestClass] public class CountriesInitializerTests
       : SealedBaseTests<CountriesInitializer, BaseInitializer<CountryData>> {
        protected override CountriesInitializer createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            return new CountriesInitializer(db);
        }
    }
}
