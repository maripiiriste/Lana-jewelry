using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests {
    public abstract class AbstractClassTests:BaseTests {
        [TestMethod] public void IsAbstractTest()=>isTrue(obj?.GetType()?.BaseType?.IsAbstract?? false);
    }
}
