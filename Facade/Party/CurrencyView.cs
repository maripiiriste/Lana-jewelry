using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Facade.Party {

    public sealed class CurrencyView : BaseView {
        [DisplayName("ISO three-letter code")] [Required] public string? Code { get; set; }
        [DisplayName("English name")] public string? Name { get; set; }
        [DisplayName("Native name")] public string? Description { get; set; }

    }
    public sealed class CurrencyViewFactory : BaseViewFactory<CurrencyView, Currency, CurrencyData> {
        protected override Currency toEntity(CurrencyData d) => new(d);
    }
}
