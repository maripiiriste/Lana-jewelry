using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Infra;
using Lana_jewelry.Tests.Infra.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Lana_jewelry.Tests.Infra.Shipment{
    [TestClass] public class TransportShoppingBagRepoTests : SealedRepoTests<TransportShoppingBagRepo, Repo<TransportShoppingBag, TransportShoppingBagData>
    , TransportShoppingBag, TransportShoppingBagData>{
        protected override TransportShoppingBagRepo createObj() => new(GetRepo.Instance<Lana_jewelryDb>());
        protected override object? getSet(Lana_jewelryDb db) => db.TransportShoppingBags;
    }
}

