using Lana_jewelry.Aids;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Aids
{
    [TestClass] public class MethodsTests : TypeTests {
        [TestMethod] public void HasAttributeTest() {
            var m = GetType().GetMethod(nameof(HasAttributeTest));
            isTrue(Methods.HasAttributes<TestMethodAttribute>(m));
            isFalse(Methods.HasAttributes<TestInitializeAttribute>(m));
        }
        [TestMethod]public void GetAttributeTest(){
            var m = GetType().GetMethod(nameof(GetAttributeTest));
            isNotNull(Methods.GetAttributes<TestMethodAttribute>(m));
            isNull(Methods.GetAttributes<TestInitializeAttribute>(m));
        }
    }
}
