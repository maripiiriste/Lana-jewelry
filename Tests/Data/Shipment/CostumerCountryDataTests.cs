
using Lana_jewelry.Data;
using Lana_jewelry.Data.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Data.Party
{
    [TestClass] public class CostumerCountryDataTests : SealedClassTests<CostumerCountryData, UniqueData>{
        [TestMethod] public void CountryIdTest() => isProperty<string>();
        [TestMethod] public void CostumerIdTest() => isProperty<string>();
    }
}
