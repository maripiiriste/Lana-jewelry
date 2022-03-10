using Lana_jewelry.Facade.Shipment;
using Lana_jewelry.Tests.Data.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Tests.Facade.Shipment
{
    [TestClass]
    public class TransportViewTests:BaseTests<TransportView>
    {
        [TestMethod] public void TransportIdTest() => isProperty<string>();
        [TestMethod] public void CostumerAddressTest() => isProperty<string>();
        [TestMethod] public void TransportPriceTest() => isProperty<double>();
        [TestMethod] public void TransportDurationTest() => isProperty<DateTime>();
    }
}
