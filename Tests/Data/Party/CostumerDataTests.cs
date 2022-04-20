

using Lana_jewelry.Data.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lana_jewelry.Tests.Data.Party {
    [TestClass]
    public class CostumerDataTests : SealedClassTests<CostumerData> {
        [TestMethod] public void IdTest() => isProperty<string>();
        [TestMethod] public void FirstNameTest() => isProperty<string?>();
        [TestMethod] public void LastNameTest() => isProperty<string?>();
        [TestMethod] public void DoBTest() => isProperty<DateTime>();
        [TestMethod] public void EmailTest() => isProperty<string>();
    }
}
