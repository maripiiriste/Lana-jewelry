using Lana_jewelry.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lana_jewelry.Tests.Facade
{
    [TestClass]
    public class NamedViewTests : AbstractClassTests<NamedView, UniqueView>
    {
        private class testClass : NamedView { }
        protected override NamedView createObj() => new testClass();
    }
}
