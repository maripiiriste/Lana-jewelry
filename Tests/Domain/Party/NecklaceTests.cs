﻿using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Party {
    [TestClass] public class NecklaceTests : SealedClassTests<Necklace, UniqueEntity<NecklaceData>> {
        [TestMethod] public void NameTest() => isInconclusive();
        [TestMethod] public void PriceTest() => isInconclusive();
        [TestMethod] public void QuantityTest() => isInconclusive();
    }
}
