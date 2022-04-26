using Lana_jewelry.Aids;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Infra.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lana_jewelry.Tests.Domain.Shipment
{
    [TestClass] public  class CostumerCountrytests : SealedClassTests<CostumerCountry, NamedEntity<CostumerCountryData>>
    {
           [TestInitialize] public void TestInitialize(){
            (GetRepo.Instance<ICountriesRepo>()as CountriesRepo)?.clear();
            (GetRepo.Instance<ICostumersRepo>() as CostumersRepo)?.clear();
           }
            protected override CostumerCountry createObj() => new(GetRandom.Value<CostumerCountryData>());
            [TestMethod] public void CountryIdTest() => isReadOnly(obj.Data.CountryId);
            [TestMethod] public void CostumerIdTest() => isReadOnly(obj.Data.CostumerId);
            [TestMethod] public void CountryTest() => testItem<ICountriesRepo, Country, CountryData>( 
                obj.CountryId, d=> new Country(d), () => obj.Country);
            [TestMethod] public void CostumerTest() => testItem<ICostumersRepo, Costumer, CostumerData>(
                obj.CostumerId, d => new Costumer(d), () => obj.Costumer);
    }
}
