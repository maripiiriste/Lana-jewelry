using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade.Party {
    public sealed class RingView : UniqueView {
    [DisplayName("Name")] [Required] public double? Name { get; set; }
    [DisplayName("Price")] [Required] public string? Price { get; set; }
    [DisplayName("Quantity")] [Required] public string? Quantity { get; set; }

    }
    public sealed class RingViewFactory : BaseViewFactory<RingView, Ring, RingData> {
        protected override Ring toEntity(RingData d) => new(d);
    }
}
