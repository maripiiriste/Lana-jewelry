using Lana_jewelry.Aids;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Party {
    [TestClass] public class CurrencyTests 
        : SealedClassTests<Currency, NamedEntity<CurrencyData>> {
        protected override Currency createObj() => new(GetRandom.Value<CurrencyData>());
        [TestMethod] public void CountryCurrenciesTest()
            => itemsTest<ICountryCurrenciesRepo, CountryCurrency, CountryCurrencyData>(
                d => d.CurrencyId = obj.Id, d => new CountryCurrency(d), () => obj.CountryCurrencies);
        [TestMethod] public void CountriesTest() => isInconclusive();
    }
}
