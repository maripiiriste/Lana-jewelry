using Lana_jewelry.Aids;
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

namespace Lana_jewelry.Tests.Domain.Shipment
{
    [TestClass] public class TransportShoppingBagTest : SealedClassTests<TransportShoppingBag, NamedEntity<TransportShoppingBagData>>
    {
        protected override TransportShoppingBag createObj() => new(GetRandom.Value<TransportShoppingBagData>());
        [TestMethod] public void TransportIdTest() => isReadOnly(obj.Data.TransportId);
        [TestMethod] public void ShoppingBagIdTest() => isReadOnly(obj.Data.ShoppingBagId);
        [TestMethod]
        public void ShoppingBagTest() => itemTest<IShoppingBagRepo, ShoppingBag, ShoppingBagData>(
            obj.ShoppingBagId, d => new ShoppingBag(d), () => obj.ShoppingBag);
        [TestMethod]
        public void TransportTest() => itemTest<ITransportsRepo, Transport, TransportData>(
            obj.TransportId, d => new Transport(d), () => obj.Transport);
    }
}
