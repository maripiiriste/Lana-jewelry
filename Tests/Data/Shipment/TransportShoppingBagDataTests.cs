using Lana_jewelry.Data;
using Lana_jewelry.Data.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lana_jewelry.Tests.Data.Shipment
{
    [TestClass] public class TransportShoppingBagDataTests : SealedClassTests<TransportShoppingBagData, UniqueData>
    {
        [TestMethod] public void TransportIdTest() => isProperty<string>();
        [TestMethod] public void ShoppingBagIdTest() => isProperty<string>();
    }
}
