using Lana_jewelry.Data;
using Lana_jewelry.Data.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Data.Shipment{
    [TestClass] public class JewelryDataTests : SealedClassTests<JewelryData, UniqueData>{
        [TestMethod] public void RingTest() => isProperty<string?>();
        [TestMethod] public void NecklaceTest() => isProperty<string?>();
        [TestMethod] public void BraceletTest() => isProperty<string?>();
        [TestMethod] public void EarringTest() => isProperty<string?>();
    }
}
