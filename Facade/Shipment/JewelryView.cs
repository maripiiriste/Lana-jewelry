using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade.Shipment{
    public sealed class JewelryView : UniqueView{
        [DisplayName("Ring")] [Required] public string? Ring { get; set; }
        [DisplayName("Necklace")] [Required] public string? Necklace { get; set; }
        [DisplayName("Bracelet")] [Required] public string? Bracelet { get; set; }
        [DisplayName("Earring")] [Required] public string? Earring { get; set; }
    }
    public sealed class JewelryViewFactory : BaseViewFactory<JewelryView, Jewelry, JewelryData>{
        protected override Jewelry toEntity(JewelryData d) => new(d);
    }
}
