using Lana_jewelry.Aids;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Tests.Domain.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lana_jewelry.Tests.Domain.Party {
    [TestClass] public class CountryTests : SealedClassTests<Country, NamedEntity<CountryData>> {

        protected override Country createObj() => new(GetRandom.Value<CountryData>());
        [TestMethod] public void CountryCurrenciesTest()
            => itemsTest<ICountryCurrenciesRepo, CountryCurrency, CountryCurrencyData>(
                d=>d.CountryId=obj.Id, d=> new CountryCurrency(d), ()=>obj.CountryCurrencies.Value);

        [TestMethod] public void CostumersCountryTest()
           => itemsTest<ICostumersCountryRepo, CostumerCountry, CostumerCountryData>(
             d => d.CountryId = obj.Id, d => new CostumerCountry(d), () => obj.CostumersCountry.Value);

        [TestMethod] public void CurrenciesTest() => relatedItemsTest<ICurrenciesRepo, CountryCurrency, Currency, CurrencyData>
            (CountryCurrenciesTest, () => obj.CountryCurrencies.Value, () => obj.Currencies.Value,
              x => x.CurrencyId, d => new Currency(d), c => c?.Data, x => x?.Currency?.Data);

        [TestMethod] public void CostumersTest() => relatedItemsTest<ICostumersRepo, CostumerCountry, Costumer, CostumerData>
            (CostumerCountryTest, () => obj.CostumersCountry.Value, () => obj.Costumers.Value,
              x => x.CostumerId, d => new Costumer(d), c => c?.Data, x => x?.Costumer?.Data);

        [TestMethod] public void CompareToTest() {
            var dX = GetRandom.Value<CountryData>() as CountryData;
            var dY= GetRandom.Value<CountryData>() as CountryData;
            isNotNull(dX);
            isNotNull(dY);
            var expected = dX.Name?.CompareTo(dY.Name);
            areEqual(expected, new Country(dX).CompareTo(new Country(dY)));
        }
    }
}
