using Lana_jewelry.Aids;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Party {
    [TestClass] public class CountryCurrencyTests : SealedClassTests<CountryCurrency, NamedEntity<CountryCurrencyData>> {
        protected override CountryCurrency createObj() => new(GetRandom.Value<CountryCurrencyData>());
        [TestMethod] public void CountryIdTest() => isReadOnly(obj.Data.CountryId);
        [TestMethod] public void CurrencyIdTest() => isReadOnly(obj.Data.CurrencyId);
        [TestMethod] public void CountryTest() => isInconclusive();
        [TestMethod] public void CurrencyTest() => isInconclusive();
    }
}
