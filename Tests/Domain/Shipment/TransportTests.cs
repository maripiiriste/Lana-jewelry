using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Shipment{
        [TestClass] public class TransportTests : SealedClassTests<Transport, UniqueEntity<TransportData>>{
            [TestMethod] public void StreetTest() => isInconclusive();
            [TestMethod] public void CityTest() => isInconclusive();
            [TestMethod] public void ZipCodeTest() => isInconclusive();
            [TestMethod] public void CountryIdTest() => isInconclusive();
            [TestMethod] public void PriceTest() => isInconclusive();
            [TestMethod] public void DurationTest() => isInconclusive();
    }
}
