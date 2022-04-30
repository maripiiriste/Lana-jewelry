using Lana_jewelry.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lana_jewelry.Tests.Facade
{
    [TestClass]
    public class IsoNamedViewTests : AbstractClassTests<IsoNamedView, NamedView>
    {
        private class testClass : IsoNamedView { }
        protected override IsoNamedView createObj() => new testClass();
        [TestMethod] public void CodeTest() => isRequired<string>("ISO three-letter code");
        [TestMethod]public void NameTest() => isDisplayNamed<string>("ENglish name");
        [TestMethod] public void DescriptionTest() => isDisplayNamed<string>("Native name");
    }
}
