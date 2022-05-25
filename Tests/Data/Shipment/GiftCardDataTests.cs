using Lana_jewelry.Data;
using Lana_jewelry.Data.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Data.Party
{
    [TestClass] public class GiftCardDataTests : SealedClassTests<GiftCardData, UniqueData>{
        [TestMethod] public void PriceTest() => isProperty<double>();
    }
}
