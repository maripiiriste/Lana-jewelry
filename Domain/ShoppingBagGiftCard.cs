using Lana_jewelry.Data;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Domain.Shipment;

namespace Lana_jewelry.Domain{
    public interface IShoppingBagGiftCardRepo : IRepo<ShoppingBagGiftCard> { }
    public sealed class ShoppingBagGiftCard : NamedEntity<ShoppingBagGiftCardData>{
        public ShoppingBagGiftCard() : this(new ShoppingBagGiftCardData()) { }
        public ShoppingBagGiftCard(ShoppingBagGiftCardData d) : base(d) { }
        public string ShoppingBagId => getValue(Data?.ShoppingBagId);
        public string GiftCardId => getValue(Data?.GiftCardId);
        public ShoppingBag? ShoppingBag => GetRepo.Instance<IShoppingBagRepo>()?.Get(ShoppingBagId);
        public GiftCard? GiftCard => GetRepo.Instance<IGiftCardRepo>()?.Get(GiftCardId);
    }
}
