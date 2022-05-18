using Lana_jewelry.Data;
using Lana_jewelry.Data.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Data.Party {
    [TestClass] public class InfoDataTests : SealedClassTests<InfoData, UniqueData> {

        [TestMethod] public void CountryTest() => isProperty<string?>();
        [TestMethod] public void CityTest() => isProperty<string?>();
        [TestMethod] public void RegionTest() => isProperty<string?>();
        [TestMethod] public void StreetTest() => isProperty<string?>();
        [TestMethod] public void StreetNumberTest() => isProperty<string?>();
        [TestMethod] public void ZipCodeTest() => isProperty<string?>();
        [TestMethod] public void PhoneNumberTest() => isProperty<string?>();
        [TestMethod] public void EmailAddressTest() => isProperty<string?>();


    }
}
