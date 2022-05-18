using Lana_jewelry.Data;
using Lana_jewelry.Domain;

namespace Lana_jewelry.Infra.Party
{
    public sealed class ShoppingBagGiftCardRepo : Repo<ShoppingBagGiftCard, ShoppingBagGiftCardData>, IShoppingBagGiftCardRepo
    {
        public ShoppingBagGiftCardRepo(Lana_jewelryDb? db) : base(db, db?.ShoppingBagGiftCards) { }
        protected internal override ShoppingBagGiftCard toDomain(ShoppingBagGiftCardData d) => new(d);
        internal override IQueryable<ShoppingBagGiftCardData> addFilter(IQueryable<ShoppingBagGiftCardData> q)
        {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q : q.Where(
                x => x.Id.Contains(y)
                || x.ShoppingBagId.Contains(y)
                || x.GiftCardId.Contains(y)
             );
        }
    }
}
