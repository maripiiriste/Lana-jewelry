

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Tests.Data.Shipment
{
    [TestClass]
    public class TransportDataTest : BaseTests<TransportData>{
        [TestMethod] public void TransportIdTest() => isProperty<string>();
        [TestMethod] public void CostumerAddressTest() => isProperty<string>();
        [TestMethod] public void TransportPriceTest() => isProperty<double>();
        [TestMethod] public void TransportDurationTest() => isProperty<DateTime>();
    }
}