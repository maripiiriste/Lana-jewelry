using Lana_jewelry.Aids;
using Lana_jewelry.Data.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Aids{
    [TestClass] public class GetNamespaceTests : TypeTests {
    
    [TestMethod] public void OfTypeTest() {
            var obj = new CurrencyData();
            var name = obj.GetType().Namespace;
            var n = GetNamespace.OfType(obj);
            areEqual(name, n);
        } 
    [TestMethod] public void OfTypeNullTest() {
            CurrencyData? obj = null;
            var n = GetNamespace.OfType(obj);
            areEqual(string.Empty, n);
        }
    }
}
