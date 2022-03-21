using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using Microsoft.EntityFrameworkCore;

namespace Lana_jewelry.Infra.Shipment
{
    public class TransportsRepo : Repo<Transport, TransportData>, ITransportsRepo
    {
        public TransportsRepo(Lana_jewelryDb? db) : base(db, db?.Transports){ }
        protected override Transport toDomain(TransportData d)=> new (d);

    }
}
