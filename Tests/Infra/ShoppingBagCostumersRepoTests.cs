using Lana_jewelry.Data;
using Lana_jewelry.Domain;
using Lana_jewelry.Infra;
using Lana_jewelry.Infra.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Infra.Party {
    [TestClass] public class ShoppingBagCostumersRepoTests : SealedRepoTests<ShoppingBagCostumerRepo, Repo<ShoppingBagCostumer, ShoppingBagCostumerData>
        , ShoppingBagCostumer, ShoppingBagCostumerData> {
        protected override ShoppingBagCostumerRepo createObj() => new(GetRepo.Instance<Lana_jewelryDb>());
        protected override object? getSet(Lana_jewelryDb db) => db.ShoppingBagCostumers;
    }
}

