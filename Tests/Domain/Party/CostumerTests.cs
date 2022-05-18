using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Tests.Domain.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Party {
    [TestClass] public class CostumerTests : SealedClassTests<Costumer, UniqueEntity<CostumerData>> {
        [TestMethod] public void FirstNameTest() => isInconclusive();
        [TestMethod] public void LastNameTest() => isInconclusive();
        [TestMethod] public void DoBTest() => isInconclusive();
        [TestMethod] public void EmailTest() => isInconclusive();
        [TestMethod] public void ToStringTest() => isInconclusive();
        //[TestMethod] public void CostumersTest() => relatedItemsTest<ICostumersRepo, CostumerCountry, Costumer, CostumerData>
        //  (CostumerCountryTest, () => obj.CostumersCountry, () => obj.Costumer,
        //  x => x.CostumerId, d => new Costumer(d), c => c?.Data, x => x?.Costumer?.Data);
        //[TestMethod]public void CountryTest() => relatedItemsTest<ICountriesRepo, CostumerCountry, Country, CountryData>
        //  (CostumerCountryTest, () => obj.CostumersCountry, () => obj.Country,
        //   x => x.CountryId, d => new Country(d), c => c?.Data, x => x?.Country?.Data);
    }
}
