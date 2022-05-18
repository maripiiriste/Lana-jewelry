using Lana_jewelry.Facade;
using Lana_jewelry.Facade.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Facade.Shipment{
    [TestClass] public class JewelryViewTests : SealedClassTests<JewelryView, UniqueView>{
        [TestMethod] public void IdTest() => isProperty<string>();
        [TestMethod] public void RingTest() => isProperty<string>();
        [TestMethod] public void BraceletTest() => isProperty<string>();
        [TestMethod] public void NecklaceTest() => isProperty<string>();
        [TestMethod] public void EarringTest() => isProperty<string>();
    }
}
