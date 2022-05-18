using Lana_jewelry.Aids;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lana_jewelry.Tests.Domain.Shipment
{
    [TestClass] public class JewelryTests : SealedClassTests<Jewelry, UniqueEntity<JewelryData>>
    {
        protected override Jewelry createObj() => new(GetRandom.Value<JewelryData>());
        [TestMethod] public void RingTest() => isReadOnly(obj.Data.Ring);
        [TestMethod] public void NecklaceTest() => isReadOnly(obj.Data.Necklace);
        [TestMethod] public void BraceletTest() => isReadOnly(obj.Data.Bracelet);
        [TestMethod] public void EarringTest() => isReadOnly(obj.Data.Earring);

    }
}
