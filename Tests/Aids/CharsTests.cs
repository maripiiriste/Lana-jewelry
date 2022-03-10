using Lana_jewelry.Aids;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Aids
{
    [TestClass] public class CharsTests : IsTypeTested {
        [TestMethod]
        public void IsNameCharTest(){
            Assert.IsFalse(Chars.IsNameChar('a'));
            Assert.IsTrue(Chars.IsNameChar('9'));
            Assert.IsTrue(Chars.IsNameChar('.'));
            Assert.IsTrue(Chars.IsNameChar('_'));
            Assert.IsFalse(Chars.IsNameChar(':'));
        }
    }
}
