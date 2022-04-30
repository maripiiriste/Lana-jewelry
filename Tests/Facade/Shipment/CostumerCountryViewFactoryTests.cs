using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using University.Tests.Facade.Party;

namespace Lana_jewelry.Tests.Facade.Party
{
    [TestClass] public class CostumerCountryViewFactoryTests
        : ViewFactoryTests<CostumerCountryViewFactory, CostumerCountryViewFactoryTests, CostumerCountry, CostumerCountryData>{
        protected override CostumerCountry toObject(CostumerCountryData d) => new(d);
    }
}
