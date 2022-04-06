using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using Microsoft.EntityFrameworkCore;

namespace Lana_jewelry.Infra.Shipment
{
    public class TransportsRepo : Repo<Transport, TransportData>, ITransportsRepo
    {
        public TransportsRepo(Lana_jewelryDb? db) : base(db, db?.Transports){ }
        protected override Transport toDomain(TransportData d)=> new (d);
        internal override IQueryable<TransportData> addFilter(IQueryable<TransportData> q)
        {
            var y = CurrentFilter;
            if (string.IsNullOrWhiteSpace(y)) return q;
            return q.Where(
                x => x.CostumerAddress.Contains(y)
                || x.Id.Contains(y)
                || x.Duration.ToString().Contains(y)
                || x.Price.ToString().Contains(y));
        }
    }
}
