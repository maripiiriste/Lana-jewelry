using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade.Shipment
{
    public class CostumerCountryView : NamedView
    {
        [Required][DisplayName("Person")] public string CostumerId { get; set; } = string.Empty;
        [Required] [DisplayName("Country")] public string CountryId { get; set; } = string.Empty;
        [DisplayName("Country native code")] public new string? Code { get; set; }
        [DisplayName("Country native name")] public new string? Name { get; set; }
    }
    public sealed class CostumerCountryViewFactory : BaseViewFactory<CostumerCountryView, CostumerCountry, CostumerCountryData>{
        protected override CostumerCountry toEntity(CostumerCountryData d) => new(d);

    }
}
