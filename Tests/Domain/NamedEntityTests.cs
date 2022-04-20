using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain {
    [TestClass] public class NamedEntityTests : AbstractClassTests {
        private class testClass : NamedEntity<CountryData> { }
        protected override object createObj() => new TestClassAttribute();
    }
}
