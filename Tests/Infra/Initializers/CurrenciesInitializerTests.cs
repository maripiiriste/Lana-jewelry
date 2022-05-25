using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Infra;
using Lana_jewelry.Infra.Initializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Infra.Initializers{
    [TestClass] public class CurrenciesInitializerTests
       : SealedBaseTests<CurrenciesInitializer, BaseInitializer<CurrencyData>> {
        protected override CurrenciesInitializer createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            return new CurrenciesInitializer(db);
        }
    }
}
