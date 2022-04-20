using Lana_jewelry.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Data{
    [TestClass] public class NamedDataTests : AbstractClassTests {
        private class testClass:NamedData { }
        protected override object createObj() => new testClass();
        [TestMethod] public void CodeTest() => isProperty<string>();
        [TestMethod] public void NameTest() => isProperty<string?>();
        [TestMethod] public void DescriptionTest() => isProperty<string?>();
    }
}
