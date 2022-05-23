using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Infra.Initializers {
    public sealed class ShoppingBagsInitializer : BaseInitializer<ShoppingBagData> {
        public ShoppingBagsInitializer(Lana_jewelryDb? db) : base(db, db?.ShoppingBags) { }
        protected override IEnumerable<ShoppingBagData> getEntities => throw new NotImplementedException();
        internal static ShoppingBagData createShoppingBag(string id, string delivery, double total, string paymentSystem, string discountCode) {
            var shoppingBag = new ShoppingBagData {
                Id = id,
                Total= total,
                Delivery = delivery,
                PaymentSystem = paymentSystem,
                DiscountCode=discountCode
            };
            return shoppingBag;
        }
    }
}
