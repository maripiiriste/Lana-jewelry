using Lana_jewelry.Aids;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Aids
{
    [TestClass] public class MethodsTests : IsTypeTested {
        [TestMethod] public void HasAttributeTest() {
            var m = GetType().GetMethod(nameof(HasAttributeTest));
            isTrue(Methods.HasAttributes<TestMethodAttribute>(m));
            isFalse(Methods.HasAttributes<TestInitializeAttribute>(m));
        }
    }
}
