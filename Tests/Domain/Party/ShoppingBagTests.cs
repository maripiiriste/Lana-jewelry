using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Party {
    [TestClass] public class ShoppingBagTests : SealedClassTests<Costumer, UniqueEntity<ShoppingBagData>> {
        [TestMethod] public void TotalTest() => isInconclusive();
        [TestMethod] public void DeliveryTest() => isInconclusive();
        [TestMethod] public void PaymentSystemTest() => isInconclusive();
        [TestMethod] public void DiscountCodeTest() => isInconclusive();
    }
}
