using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Facade.Party {
    
    public sealed class CountryView : IsoNamedView { }
   
    public sealed class CountryViewFactory : BaseViewFactory<CountryView, Country, CountryData> {
        protected override Country toEntity(CountryData d) => new(d);
    }
}
