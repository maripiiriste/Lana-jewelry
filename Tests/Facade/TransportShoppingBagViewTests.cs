using Lana_jewelry.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lana_jewelry.Tests.Facade.Shipment{
    [TestClass]public class TransportShoppingBagViewTests : SealedClassTests<TransportShoppingBagView, NamedView>{
        [TestMethod] public void TransportIdTest() => isRequired<string>("Transport");
        [TestMethod] public void ShoppingBagIdTest() => isRequired<string>("Shopping Bag");
    }
}
