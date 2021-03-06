using Lana_jewelry.Facade;
using Lana_jewelry.Facade.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Facade.Party {
    [TestClass] public class BraceletViewTests : SealedClassTests<BraceletView, UniqueView> {
        [TestMethod] public void IdTest() => isProperty<string>();
        [TestMethod] public void PriceTest() => isProperty<double>();
        [TestMethod] public void QuantityTest() => isProperty<string?>();
        [TestMethod] public void NameTest() => isProperty<string?>();
    }
}
