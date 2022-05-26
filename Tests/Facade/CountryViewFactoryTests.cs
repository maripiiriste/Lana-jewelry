using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using University.Tests.Facade.Party;

namespace Lana_jewelry.Tests.Facade.Party{
    [TestClass] public class CountryViewFactoryTests
    : ViewFactoryTests<CountryViewFactory, CountryView, Country, CountryData>{
        protected override Country toObject(CountryData d) => new(d);
    }
}
