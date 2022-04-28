using Lana_jewelry.Aids;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Infra.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Party {
    [TestClass] public class CountryCurrencyTests : SealedClassTests<CountryCurrency, NamedEntity<CountryCurrencyData>> {
        protected override CountryCurrency createObj() => new(GetRandom.Value<CountryCurrencyData>());
        [TestMethod] public void CountryIdTest() => isReadOnly(obj.Data.CountryId);
        [TestMethod] public void CurrencyIdTest() => isReadOnly(obj.Data.CurrencyId);
        [TestMethod] public void CountryTest() => itemTest<ICountriesRepo, Country, CountryData>(obj.CountryId, d => new Country(d), () => obj.Country);
        [TestMethod] public void CurrencyTest() => itemTest<ICurrenciesRepo, Currency, CurrencyData>(obj.CurrencyId, d => new Currency(d), () => obj.Currency);
    }
}
