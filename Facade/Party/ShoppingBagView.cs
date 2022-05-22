using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade;
using Lana_jewelry.Facade.Party;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade.Party {
    public sealed class ShoppingBagView : UniqueView {
        [DisplayName("Total")] public double? Total { get; set; }
        [DisplayName("Delivery")] [Required] public string? Delivery { get; set; }
        [DisplayName("Payment system")] [Required] public string? PaymentSystem { get; set; }
        [DisplayName("Discount code")] public string? DiscountCode { get; set; }
    }
    public sealed class ShoppingBagViewFactory : BaseViewFactory<ShoppingBagView, ShoppingBag, ShoppingBagData> {
        protected override ShoppingBag toEntity(ShoppingBagData d) => new(d);
    }
}
