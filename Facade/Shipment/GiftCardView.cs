using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade.Shipment
{
    public class GiftCardView : BaseView
    {
        [DisplayName("Gift card price")] [Required] public double Price { get; set; }
    }
    public sealed class GiftCardViewFactory : BaseViewFactory<GiftCardView, GiftCard, GiftCardData>
    {
        protected override GiftCard toEntity(GiftCardData d) => new(d);
    }
}
