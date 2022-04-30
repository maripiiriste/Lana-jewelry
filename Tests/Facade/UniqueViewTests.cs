using Lana_jewelry.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lana_jewelry.Tests.Facade
{
    [TestClass]
    public class UniqueViewTests : AbstractClassTests<UniqueView, object> {
        private class testClass : UniqueView { }
        protected override UniqueView createObj() => new testClass();
        [TestMethod] public void IdTest() => isProperty<string>();
    }
}
