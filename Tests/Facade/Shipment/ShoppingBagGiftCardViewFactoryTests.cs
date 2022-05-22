using Lana_jewelry.Data;
using Lana_jewelry.Domain;
using Lana_jewelry.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using University.Tests.Facade.Party;

namespace Lana_jewelry.Tests.Facade.Shipment
{
    [TestClass] public class ShoppingBagGiftCardViewFactoryTests
        : ViewFactoryTests<ShoppingBagGiftCardViewFactory, ShoppingBagGiftCardView, ShoppingBagGiftCard, ShoppingBagGiftCardData>
    {
        protected override ShoppingBagGiftCard toObject(ShoppingBagGiftCardData d) => new(d);
    }
}
