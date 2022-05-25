using Lana_jewelry.Facade;
using Lana_jewelry.Facade.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lana_jewelry.Tests.Facade.Party {
    [TestClass] public class CostumerViewTests : SealedClassTests<CostumerView, UniqueView>{
        [TestMethod] public void IdTest() => isProperty<string>();
        [TestMethod] public void FirstNameTest() => isProperty<string?>();
        [TestMethod] public void LastNameTest() => isProperty<string?>();
        [TestMethod] public void DoBTest() => isProperty<DateTime?>();
        [TestMethod] public void EmailTest() => isProperty<string?>();
    }
}
