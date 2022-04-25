using Lana_jewelry.Facade.Shipment;
using Lana_jewelry.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Lana_jewelry.Tests.Facade.Shipment
{
    [TestClass] public class GiftCardViewTests: SealedClassTests<GiftCardView>
    {
        [TestMethod] public void IdTest() => isProperty<string>();
        [TestMethod] public void PriceTest() => isProperty<double>();
    }
}
