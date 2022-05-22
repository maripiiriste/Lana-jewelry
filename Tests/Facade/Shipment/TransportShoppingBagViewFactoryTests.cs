using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using University.Tests.Facade.Party;

namespace Lana_jewelry.Tests.Facade.Shipment
{
    [TestClass]public class TransportShoppingBagViewFactoryTests
        : ViewFactoryTests<TransportShoppingBagViewFactory, TransportShoppingBagView, TransportShoppingBag, TransportShoppingBagData>
    {
        protected override TransportShoppingBag toObject(TransportShoppingBagData d) => new(d);
    }
}
