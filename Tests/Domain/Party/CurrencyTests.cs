﻿using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Party {
    [TestClass] public class CurrencyTests 
        : SealedClassTests<Currency, NamedEntity<CurrencyData>> {
        [TestMethod] public void CountryCurrenciesTest() => isInconclusive();
        [TestMethod] public void CurrenciesTest() => isInconclusive();

    }
}