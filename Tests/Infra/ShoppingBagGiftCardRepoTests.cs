using Lana_jewelry.Data;
using Lana_jewelry.Domain;
using Lana_jewelry.Infra;
using Lana_jewelry.Infra.Party;
using Lana_jewelry.Tests.Infra.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Lana_jewelry.Tests.Infra.Shipment{
    [TestClass]public class ShoppingBagGiftCardRepoTests : SealedRepoTests<ShoppingBagGiftCardRepo, Repo<ShoppingBagGiftCard, ShoppingBagGiftCardData>
    , ShoppingBagGiftCard, ShoppingBagGiftCardData>{
        protected override ShoppingBagGiftCardRepo createObj() => new(GetRepo.Instance<Lana_jewelryDb>());
        protected override object? getSet(Lana_jewelryDb db) => db.ShoppingBagGiftCards;
    }
}
