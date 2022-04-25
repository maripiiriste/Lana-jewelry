

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Tests.Data.Shipment
{
    [TestClass]
    public class TransportDataTests: SealedClassTests<TransportData>{
        [TestMethod] public void TransportIdTest() => isProperty<string>();
        [TestMethod] public void StreetTest() => isProperty<string>();
        [TestMethod] public void CityTest() => isProperty<string?>();
        [TestMethod] public void ZipCodeTest() => isProperty<string?>();
        [TestMethod] public void CountryTest() => isProperty<string?>();
        [TestMethod] public void TransportPriceTest() => isProperty<double>();
        [TestMethod] public void TransportDurationTest() => isProperty<DateTime>();
    }
}