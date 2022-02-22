using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;

namespace Lana_jewelry.Infra.Shipment
{
    public class TransportsRepo : Repo<Transport, TransportData>, ITransportsRepo
    {
        public TransportsRepo(DbContext c, DbSet<TransportData> s) : base(c, s){ }
        protected override Transport toDomain(TransportData d)=> new Transport(d);

    }
}
