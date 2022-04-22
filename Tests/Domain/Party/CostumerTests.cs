using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Domain.Party {
    [TestClass] public class CostumerTests : SealedClassTests<Costumer, UniqueEntity<CostumerData>> {
        [TestMethod] public void FirstNameTest() => isInconclusive();
        [TestMethod] public void LastNameTest() => isInconclusive();
        [TestMethod] public void DoBTest() => isInconclusive();
        [TestMethod] public void EmailTest() => isInconclusive();
        [TestMethod] public void ToStringTest() => isInconclusive();
    }
}
