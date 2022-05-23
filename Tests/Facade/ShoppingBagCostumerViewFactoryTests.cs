using Lana_jewelry.Data;
using Lana_jewelry.Domain;
using Lana_jewelry.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using University.Tests.Facade.Party;

namespace Lana_jewelry.Tests.Facade.Party {
    [TestClass] public class ShoppingBagCostumerViewFactoryTests
        : ViewFactoryTests<ShoppingBagCostumerViewFactory, ShoppingBagCostumerView, ShoppingBagCostumer, ShoppingBagCostumerData> {
        protected override ShoppingBagCostumer toObject(ShoppingBagCostumerData d) => new(d);
    }
}
