using Lana_jewelry.Facade;
using Lana_jewelry.Facade.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Facade.Party {
    [TestClass] public class ShoppingBagViewTests : SealedClassTests<ShoppingBagView, UniqueView> {
        [TestMethod] public void IdTest() => isProperty<string>();
        [TestMethod] public void TotalTest() => isProperty<double>();
        [TestMethod] public void DeliveryTest() => isProperty<string?>();
        [TestMethod] public void PaymentSystemTest() => isProperty<string?>();
        [TestMethod] public void DiscountCodeTest() => isProperty<string?>();
    }
}
