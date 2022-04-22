using Lana_jewelry.Aids;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Party {
    [TestClass] public class InfoTests:SealedClassTests<Info, UniqueEntity<InfoData>> {
        protected override Info createObj() => new (GetRandom.Value<InfoData>());
        [TestMethod] public void CountryTest() => isReadOnly(obj.Data.Country);
        [TestMethod] public void CityTest() => isReadOnly(obj.Data.City);
        [TestMethod] public void RegionTest() => isReadOnly(obj.Data.Region);
        [TestMethod] public void StreetTest() => isReadOnly(obj.Data.Street);
        [TestMethod] public void StreetNumberTest() => isReadOnly(obj.Data.StreetNumber);
        [TestMethod] public void ZipCodeTest() => isReadOnly(obj.Data.ZipCode);
        [TestMethod] public void PhoneNumberTest() => isReadOnly(obj.Data.PhoneNumber);
        [TestMethod] public void EmailAddressTest() => isReadOnly(obj.Data.EmailAddress);
    }
}
