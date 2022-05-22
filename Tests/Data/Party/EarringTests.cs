using Lana_jewelry.Data;
using Lana_jewelry.Data.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Data.Party {
    [TestClass] public class EarringTests : SealedClassTests<EarringData, UniqueData> {
        [TestMethod] public void IdTest() => isProperty<string>();
        [TestMethod] public void PriceTest() => isProperty<double>();
        [TestMethod] public void NameTest() => isProperty<string?>();
        [TestMethod] public void QuantityTest() => isProperty<int>();
    }
}
