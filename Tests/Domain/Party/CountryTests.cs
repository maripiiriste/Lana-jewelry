using Lana_jewelry.Aids;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Party {
    [TestClass] public class CountryTests : SealedClassTests<Country, NamedEntity<CountryData>> {

        protected override Country createObj() => new(GetRandom.Value<CountryData>());
        [TestMethod] public void CountryCurrenciesTest()
            => itemsTest<ICountryCurrenciesRepo, CountryCurrency, CountryCurrencyData>(
                d=>d.CountryId=obj.Id, d=> new CountryCurrency(d), ()=>obj.CountryCurrencies);

        [TestMethod] public void CurrenciesTest() => isInconclusive();
    }
}
