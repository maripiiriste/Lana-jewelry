using Lana_jewelry.Facade;
using Lana_jewelry.Facade.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Facade.Party{
    [TestClass] public class InfoViewTests: SealedClassTests<InfoView, UniqueView> {
        [TestMethod] public void IdTest() => isProperty<string>();
        [TestMethod] public void CountryTest() => isProperty<string>();
        [TestMethod] public void CityTest() => isProperty<string>();
        [TestMethod] public void RegionTest() => isProperty<string>();
        [TestMethod] public void StreetTest() => isProperty<string>();
        [TestMethod] public void StreetNumberTest() => isProperty<string>();
        [TestMethod] public void ZipCodeTest() => isProperty<string>();
        [TestMethod] public void PhoneNumberTest() => isProperty<string>();
        [TestMethod] public void EmailAddressTest() => isProperty<string>();
    }
}
