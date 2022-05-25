using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Facade;
using Lana_jewelry.Facade.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Facade.Shipment{
    [TestClass] public class JewelryViewFactoryTests : SealedClassTests<JewelryViewFactory, BaseViewFactory<JewelryView, Jewelry, JewelryData>>{}
}
