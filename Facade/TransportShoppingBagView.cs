using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade{
    public class TransportShoppingBagView : NamedView{
        [Required] [DisplayName("ShoppingBag")] public string ShoppingBagId { get; set; } = string.Empty;
        [Required] [DisplayName("Transport")] public string TransportId { get; set; } = string.Empty;
    }
    public sealed class TransportShoppingBagViewFactory : BaseViewFactory<TransportShoppingBagView, TransportShoppingBag, TransportShoppingBagData>{
        protected override TransportShoppingBag toEntity(TransportShoppingBagData d) => new(d);
    }
}
