using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain {
    [TestClass] public class UniqueEntityTests : AbstractClassTests<UniqueEntity<CountryData>,UniqueEntity > {
        private class testClass : UniqueEntity<CountryData> { }
        protected override UniqueEntity<CountryData> createObj() => new testClass();
        [TestMethod] public void IdTest() => isInconclusive();
        [TestMethod] public void DataTest() => isInconclusive();
        [TestMethod] public void DefaultStrTest() => isInconclusive();
    }
}
