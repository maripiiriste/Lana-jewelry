using Lana_jewelry.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Facade.Party {
    [TestClass] public class ShoppingBagCostumerViewTests : SealedClassTests<ShoppingBagCostumerView, NamedView> {
        [TestMethod] public void ShoppingBagIdTest() => isRequired<string>("Country");
        [TestMethod] public void CostumerIdTest() => isRequired<string>("Person");
    }
}
