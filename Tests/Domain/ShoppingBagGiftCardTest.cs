using Lana_jewelry.Aids;
using Lana_jewelry.Data;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Domain.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lana_jewelry.Tests.Domain.Shipment{
    [TestClass] public class ShoppingBagGiftCardTest : SealedClassTests<ShoppingBagGiftCard, NamedEntity<ShoppingBagGiftCardData>>{
        protected override ShoppingBagGiftCard createObj() => new(GetRandom.Value<ShoppingBagGiftCardData>());
        [TestMethod] public void GiftCardIdTest() => isReadOnly(obj.Data.GiftCardId);
        [TestMethod] public void ShoppingBagIdTest() => isReadOnly(obj.Data.ShoppingBagId);
        [TestMethod]public void ShoppingBagTest() => itemTest<IShoppingBagRepo, ShoppingBag, ShoppingBagData>(
            obj.ShoppingBagId, d => new ShoppingBag(d), () => obj.ShoppingBag);
        [TestMethod] public void GiftCardTest() => itemTest<IGiftCardRepo, GiftCard, GiftCardData>(
            obj.GiftCardId, d => new GiftCard(d), () => obj.GiftCard);
    }
}
