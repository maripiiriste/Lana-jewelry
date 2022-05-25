using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Shipment{
    [TestClass] public class GiftCardTests:SealedClassTests<GiftCard, UniqueEntity<GiftCardData>> {
        [TestMethod] public void PriceTest() => isInconclusive();
    }
}
