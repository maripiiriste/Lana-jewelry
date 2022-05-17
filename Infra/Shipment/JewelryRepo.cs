using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;

namespace Lana_jewelry.Infra.Shipment
{
    public sealed class JewelryRepo : Repo<Jewelry, JewelryData>, IJewelryRepo
    {
        public JewelryRepo(Lana_jewelryDb? db) : base(db, db?.Jewelries) { }
        protected internal override Jewelry toDomain(JewelryData d) => new(d);
        internal override IQueryable<JewelryData> addFilter(IQueryable<JewelryData> q)
        {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q : q.Where(
                x => x.Ring.Contains(y)
                || x.Id.Contains(y)
                || x.Bracelet.Contains(y)
                || x.Necklace.Contains(y)
                || x.Earring.Contains(y));
        }
    }
}
