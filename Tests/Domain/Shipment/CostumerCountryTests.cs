using Lana_jewelry.Aids;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Shipment
{
    [TestClass] public  class CostumerCountrytests : SealedClassTests<CostumerCountry, NamedEntity<CostumerCountryData>>
    {
            protected override CostumerCountry createObj() => new(GetRandom.Value<CostumerCountryData>());
            [TestMethod] public void CountryIdTest() => isReadOnly(obj.Data.CountryId);
            [TestMethod] public void CostumerIdTest() => isReadOnly(obj.Data.CostumerId);
            [TestMethod] public void CountryTest() => isInconclusive();
            [TestMethod] public void CostumerTest() => isInconclusive();
        
    }
}
