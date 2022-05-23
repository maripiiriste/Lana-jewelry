using Lana_jewelry.Data;
using Lana_jewelry.Domain;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Lana_jewelry.Facade {
    public class ShoppingBagGiftCardView : NamedView{
        [Required] [DisplayName("ShoppingBag")] public string ShoppingBagId { get; set; } = string.Empty;
        [Required] [DisplayName("GiftCard")] public string GiftCardId { get; set; } = string.Empty;
    }
    public sealed class ShoppingBagGiftCardViewFactory : BaseViewFactory<ShoppingBagGiftCardView, ShoppingBagGiftCard, ShoppingBagGiftCardData>{
        protected override ShoppingBagGiftCard toEntity(ShoppingBagGiftCardData d) => new(d);
    }
}
