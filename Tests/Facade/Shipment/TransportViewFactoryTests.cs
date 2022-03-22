using Lana_jewelry.Aids;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Facade.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Facade.Shipment
{
    [TestClass]
    public class TransportViewFactoryTests:SealedClassTests<TransportViewFactory>
    {
        [TestMethod] public void CreateTest() { }
        [TestMethod] public void CreateViewTest() {
            var d = GetRandom.Value<TransportData>();
            var e = new Transport(d);
            var v = new TransportViewFactory().Create(e);
            isNotNull(v);
            areEqual(v.TransportDuration, e.TransportDuration);
            areEqual(v.Id, e.Id);
            areEqual(v.CostumerAddress, e.CostumerAddress);
            areEqual(v.TransportPrice, e.TransportPrice);
        }
        [TestMethod] public void CreateEntityTest() {
            var v = GetRandom.Value<TransportView>();
            var e = new TransportViewFactory().Create(v);
            isNotNull(e);
            areEqual(e.TransportDuration, v.TransportDuration);
            areEqual(e.Id, v.Id);
            areEqual(e.CostumerAddress, v.CostumerAddress);
            areEqual(e.TransportPrice, v.TransportPrice);
        }
    }
}
