using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Shipment;

namespace Lana_jewelry.Domain.Party {
    public interface IShoppingBagRepo : IRepo<ShoppingBag> { }
    public sealed class ShoppingBag : UniqueEntity<ShoppingBagData> {
        public ShoppingBag() : this(new()) { }
        public ShoppingBag(ShoppingBagData d) : base(d) { }
        public double Total => getValue(Data?.Total);
        public string Delivery => getValue(Data?.Delivery);
        public string PaymentSystem => getValue(Data?.PaymentSystem);
        public string DiscountCode => getValue(Data?.DiscountCode);
        public List<ShoppingBagGiftCard> ShoppingBagGiftCards
          => GetRepo.Instance<IShoppingBagGiftCardRepo>()?
          .GetAll(x => x.ShoppingBagId)?
          .Where(x => x.ShoppingBagId == Id)?
          .ToList() ?? new List<ShoppingBagGiftCard>();
        public List<GiftCard?> GiftCards
            => ShoppingBagGiftCards
            .Select(x => x.GiftCard)
            .ToList() ?? new List<GiftCard?>();
    }

}
