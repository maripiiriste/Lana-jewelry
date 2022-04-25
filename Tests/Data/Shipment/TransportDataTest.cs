
using Lana_jewelry.Data;
using Lana_jewelry.Data.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lana_jewelry.Tests.Data.Party
{
    [TestClass]
    public class TransportDataTests : SealedClassTests<TransportData, UniqueData>
    {
        //midagi on valesti, kustus transportdatatests ara ja nuud ei lase teha
        [TestMethod] public void CountryIdTest() => isProperty<string?>();
        [TestMethod] public void StreetTest() => isProperty<string?>();
        [TestMethod] public void CityTest() => isProperty<string?>();
        [TestMethod] public void ZipCodeTest() => isProperty<string?>();
        [TestMethod] public void DurationTest() => isProperty<DateTime>();
        [TestMethod] public void PriceTest() => isProperty<double>();
    }
}
