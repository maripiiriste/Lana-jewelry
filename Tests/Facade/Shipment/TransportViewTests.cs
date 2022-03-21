using Lana_jewelry.Facade.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace Lana_jewelry.Tests.Facade.Shipment
{
    [TestClass]
    public class TransportViewTests: SealedClassTests<TransportView>
    {
        [TestMethod] public void TransportIdTest() => isProperty<string>();
        [TestMethod] public void CostumerAddressTest() => isProperty<string>();
        [TestMethod] public void TransportPriceTest() => isProperty<double>();
        [TestMethod] public void TransportDurationTest() => isProperty<DateTime>();
    }
}
