using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade;
using Lana_jewelry.Facade.Party;

namespace Lana_jewelry.Tests.Facade.Party {
    public class NecklaceViewFactoryTests : SealedClassTests<NecklaceViewFactory, BaseViewFactory<NecklaceView, Necklace, NecklaceData>> { }
}


