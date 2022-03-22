using Lana_jewelry.Facade.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lana_jewelry.Tests.Facade.Shipment
{
    [TestClass]
    public class GiftCardViewTests: SealedClassTests<GiftCardView>
    {
        [TestMethod] public void IdTest() => isProperty<string>();
        [TestMethod] public void PriceTest() => isProperty<double>();
    }
}
