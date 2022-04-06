using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;

namespace Lana_jewelry.Infra.Shipment
{
    public class GiftCardRepo : Repo<GiftCard, GiftCardData>, IGiftCardRepo
    {
        public GiftCardRepo(Lana_jewelryDb? db) : base(db, db?.GiftCards) { }
        protected override GiftCard toDomain(GiftCardData d) => new (d);
        internal override IQueryable<GiftCardData> addFilter(IQueryable<GiftCardData> q)
        {
            var y = CurrentFilter;
            if (string.IsNullOrWhiteSpace(y)) return q;
            return q.Where(
                x => x.Price.ToString().Contains(y)
                  || x.Id.Contains(y));
        }
    }
}
