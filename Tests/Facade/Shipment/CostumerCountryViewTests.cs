using Lana_jewelry.Facade;
using Lana_jewelry.Facade.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Facade.Party
{
    [TestClass] public class CostumerCountryViewTests: SealedClassTests<CostumerCountryView, NamedView>
    {
        [TestMethod] public void CountryIdTest() => isRequired<string>("Country");
        [TestMethod] public void CostumerIdTest() => isRequired<string>("Person");
        [TestMethod] public void CodeTest() => isDisplayNamed<string?>("Country native code");
        [TestMethod] public void NameTest() => isDisplayNamed<string?>("Native name");
    }
}
