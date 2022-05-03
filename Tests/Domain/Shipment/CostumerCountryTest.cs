using Lana_jewelry.Aids;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Shipment
{
    [TestClass] public  class CostumerCountryTest : SealedClassTests<CostumerCountry, NamedEntity<CostumerCountryData>>
    {
            protected override CostumerCountry createObj() => new(GetRandom.Value<CostumerCountryData>());
            [TestMethod] public void CountryIdTest() => isReadOnly(obj.Data.CountryId);
            [TestMethod] public void CostumerIdTest() => isReadOnly(obj.Data.CostumerId);
            [TestMethod] public void CountryTest() => itemTest<ICountriesRepo, Country, CountryData>( 
                obj.CountryId, d=> new Country(d), () => obj.Country);
            [TestMethod] public void CostumerTest() => itemTest<ICostumersRepo, Costumer, CostumerData>(
                obj.CostumerId, d => new Costumer(d), () => obj.Costumer);
    }
}
