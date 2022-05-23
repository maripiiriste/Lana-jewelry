using Lana_jewelry.Aids;
using Lana_jewelry.Data;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Party {
    [TestClass] public class ShoppingBagCostumerTests : SealedClassTests<ShoppingBagCostumer, NamedEntity<ShoppingBagCostumerData>> {
        protected override ShoppingBagCostumer createObj() => new(GetRandom.Value<ShoppingBagCostumerData>());
        [TestMethod] public void ShoppingBagIdTest() => isReadOnly(obj.Data.ShoppingBagId);
        [TestMethod] public void CostumerIdTest() => isReadOnly(obj.Data.CostumerId);
        [TestMethod] public void ShoppingBagTest() => itemTest<IShoppingBagRepo, ShoppingBag, ShoppingBagData>(obj.ShoppingBagId, d => new ShoppingBag(d), () => obj.ShoppingBag);
        [TestMethod] public void CostumerTest() => itemTest<ICostumersRepo, Costumer, CostumerData>(obj.CostumerId, d => new Costumer(d), () => obj.Costumer);
    }
}
