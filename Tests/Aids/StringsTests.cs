using Lana_jewelry.Aids;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Aids
{
    [TestClass] public class StringsTests : IsTypeTested {
        private string testStr;

        [TestInitialize] public void Init() => testStr = "a1b1c1.d1e1f1";
        [TestMethod] public void RemoveTest() => areEqual("abc.def", Strings.Remove(testStr, "1"));
        [TestMethod] public void IsTypeNameTest() => isInconclusive();
        [TestMethod] public void IsTypeFullNameTest() => isInconclusive();
        [TestMethod] public void RemoveTailTest() => areEqual("a1b1c1", Strings.RemoveTail(testStr));
    }
}
