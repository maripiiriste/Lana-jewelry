using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain {
    [TestClass] public class NamedEntityTests : AbstractClassTests<NamedEntity<CountryData>, UniqueEntity<CountryData>> {
        private class testClass : NamedEntity<CountryData> { }
        protected override NamedEntity<CountryData> createObj() => new testClass();
        [TestMethod] public void NameTest() => isInconclusive();
        [TestMethod] public void CodeTest() => isInconclusive();
        [TestMethod] public void DescriptionTest() => isInconclusive();
    }
}
