using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Facade.Party {
    public class CountryCurrencyView : NamedView {
        [Required] [DisplayName("Country")]public string CountryId { get; set; } = string.Empty;
        [Required] [DisplayName("Currency")]public string CurrencyId { get; set; } = string.Empty;
        [DisplayName("Currency native code")] public new string? Code { get; set; } 
        [DisplayName("Currency native name")] public new string? Name { get; set; }
    }
    public sealed class CountryCurrencyViewFactory : BaseViewFactory<CountryCurrencyView, CountryCurrency, CountryCurrencyData> {
        protected override CountryCurrency toEntity(CountryCurrencyData d) => new(d);
    }
}
