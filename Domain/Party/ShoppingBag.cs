using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Domain.Party {
    public interface IShoppingBagRepo : IRepo<ShoppingBag> { }
    public sealed class ShoppingBag : UniqueEntity<ShoppingBagData> {
        public ShoppingBag() : this(new()) { }
        public ShoppingBag(ShoppingBagData d) : base(d) { }
        public double Total => getValue(Data?.Total);
        public string Delivery => getValue(Data?.Delivery);
        public string PaymentSystem => getValue(Data?.PaymentSystem);
        public string DiscountCode => getValue(Data?.DiscountCode);
    }
}
