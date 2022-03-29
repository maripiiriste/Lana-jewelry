using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Facade.Party {
    
    public sealed class CountryView : BaseView {
        [DisplayName("ISO three-letter code")] [Required] public string? Code { get; set; }
        [DisplayName("English name")] public string? Name { get; set; }
        [DisplayName("Native name")] public string? Description { get; set; }

    }
    public sealed class CountryViewFactory : BaseViewFactory<CountryView, Country, CountryData> {
        protected override Country toEntity(CountryData d) => new(d);
    }
}
