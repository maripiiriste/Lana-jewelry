using Lana_jewelry.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Data.Shipment{
    [TestClass]public class ShoppingBagGiftCardDataTests : SealedClassTests<ShoppingBagGiftCardData, UniqueData>{
        [TestMethod] public void GiftCardIdTest() => isProperty<string>();
        [TestMethod] public void ShoppingBagIdTest() => isProperty<string>();
    }
}
