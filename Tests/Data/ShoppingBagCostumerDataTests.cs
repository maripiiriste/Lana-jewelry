using Lana_jewelry.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Data.Party {
    [TestClass] public class ShoppingBagCostumerDataTests : SealedClassTests<ShoppingBagCostumerData, NamedData> {
        [TestMethod] public void ShoppingBagIdTest() => isProperty<string>();
        [TestMethod] public void CostumerIdTest() => isProperty<string>();
    }
}
