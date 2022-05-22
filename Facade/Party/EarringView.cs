using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade.Party {
    public sealed class EarringView : UniqueView {
        [DisplayName("Name")] [Required] public double? Name { get; set; }
        [DisplayName("Price")] [Required] public string? Price { get; set; }
        [DisplayName("Quantity")] [Required] public string? Quantity{ get; set; }
    }
    public sealed class EarringViewFactory : BaseViewFactory<EarringView, Earring, EarringData> {
        protected override Earring toEntity(EarringData d) => new(d);
    }
}
