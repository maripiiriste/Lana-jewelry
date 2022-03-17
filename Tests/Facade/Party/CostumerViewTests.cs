using Lana_jewelry.Facade.Party;
using Lana_jewelry.Tests.Data.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lana_jewelry.Tests.Facade.Party
{
    [TestClass] public class CostumerViewTests : SealedClassTests<CostumerView>
    {
        [TestMethod] public void IdTest() => isProperty<string>();
        [TestMethod] public void FirstNameTest() => isProperty<string?>();
        [TestMethod] public void LastNameTest() => isProperty<string?>();
        [TestMethod] public void DoBTest() => isProperty<DateTime?>();
        [TestMethod] public void EmailTest() => isProperty<string?>();
       
    }
}
