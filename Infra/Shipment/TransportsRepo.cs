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
            return string.IsNullOrWhiteSpace(y)
                ?q
                :q.Where(
                x => x.Id.Contains(y)
                || x.Street.Contains(y)
                || x.City.Contains(y)
                || x.ZipCode.Contains(y)
                || x.CountryId.Contains(y)
                || x.Duration.ToString().Contains(y)
                || x.Price.ToString().Contains(y));
        }
    }
}
