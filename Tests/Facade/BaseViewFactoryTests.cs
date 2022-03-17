using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade;
using Lana_jewelry.Facade.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lana_jewelry.Tests.Facade {
    [TestClass]
    public class BaseViewFactoryTests : AbstractClassTests {
        private class testClass : BaseViewFactory<InfoView, Info, InfoData> {
            protected override Info toEntity(InfoData d) => new Info(d);
            
        }
        protected override object createObj() => new testClass();

    }
}
