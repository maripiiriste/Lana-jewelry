using Lana_jewelry.Aids;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lana_jewelry.Tests.Domain.Party {
    [TestClass] public class CountryTests : SealedClassTests<Country, NamedEntity<CountryData>> {

        protected override Country createObj() => new(GetRandom.Value<CountryData>());
        [TestMethod] public void CountryCurrenciesTest()
            => itemsTest<ICountryCurrenciesRepo, CountryCurrency, CountryCurrencyData>(
                d=>d.CountryId=obj.Id, d=> new CountryCurrency(d), ()=>obj.CountryCurrencies);

        [TestMethod] public void CurrenciesTest() => relatedItemsTest(CountryCurrenciesTest);

        [TestMethod] public void CompareToTest() {
            var dX = GetRandom.Value<CountryData>() as CountryData;
            var dY= GetRandom.Value<CountryData>() as CountryData;
            isNotNull(dX);
            isNotNull(dY);
            var expected = dX?.Name?.CompareTo(dY.Name);
            areEqual(expected, new Country(dX).CompareTo(new Country(dY)));
        }

        protected void relatedItemsTest(Action relatedTest) {
            relatedTest();
            CountryCurrenciesTest();
            var list = obj.CountryCurrencies;
            var r = GetRepo.Instance<ICurrenciesRepo>();
            foreach(var element in list) {
                var x = GetRandom.Value<CurrencyData>();
                x.Id = element.CurrencyId;
                r.Add(new Currency(x));
            }
            var currencies= obj.Currencies;
            areEqual(list.Count, currencies.Count);
            foreach(var element in list) {
                areEqual(obj.Id, element.CountryId);
                var a = currencies.Find(x => x?.Id == element.CurrencyId);
                arePropertiesEqual(a?.Data, element?.Currency?.Data);
            }
        }
    }
}
