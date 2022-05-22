using Lana_jewelry.Data;
using Lana_jewelry.Data.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Data.Party {
    [TestClass] public class ShoppingBagTests : SealedClassTests<ShoppingBagData, UniqueData> {
        [TestMethod] public void IdTest() => isProperty<string>();
        [TestMethod] public void TotalTest() => isProperty<double>();
        [TestMethod] public void DeliveryTest() => isProperty<string?>();
        [TestMethod] public void PaymentSystemTest() => isProperty<string>();
        [TestMethod] public void DiscountCodeTest() => isProperty<string>();
    }
}
