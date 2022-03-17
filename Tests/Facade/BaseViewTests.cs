using Lana_jewelry.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lana_jewelry.Tests.Facade
{
    [TestClass]
    public class BaseViewTests : AbstractClassTests {
        private class testClass : BaseView { }
        protected override object createObj() => new testClass();
    }
}
