using Lana_jewelry.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Facade.Shipment{
    [TestClass]public class ShoppingBagGiftCardViewTests : SealedClassTests<ShoppingBagGiftCardView, NamedView>{
        [TestMethod] public void GiftCardIdTest() => isRequired<string>("Gift Card");
        [TestMethod] public void ShoppingBagIdTest() => isRequired<string>("Shopping Bag");
    }
}
