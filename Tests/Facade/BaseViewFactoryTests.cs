using Lana_jewelry.Aids;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade;
using Lana_jewelry.Facade.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lana_jewelry.Tests.Facade {
    [TestClass]public class BaseViewFactoryTests : AbstractClassTests<BaseViewFactory<InfoView, Info, InfoData>, object> {
        private class testClass : BaseViewFactory<InfoView, Info, InfoData> {
            protected override Info toEntity(InfoData d) => new Info(d);
        }
        protected override BaseViewFactory<InfoView, Info, InfoData> createObj() => new testClass();
        [TestMethod] public void CreatTest (){}
        [TestMethod] public void CreatViewTest() {
            var v = GetRandom.Value<InfoView>();
            var o = obj.Create(v);
            arePropertiesEqual(v, o.Data);
        }
        [TestMethod] public void CreatObjectTest() {
            var d = GetRandom.Value<InfoData>();
            var v = obj.Create(new Info(d));
            arePropertiesEqual(d, v);
        }
    }
}
