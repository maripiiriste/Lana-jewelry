using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;

namespace Lana_jewelry.Infra.Shipment
{
    public class GiftCardRepo : Repo<GiftCard, GiftCardData>, IGiftCardRepo
    {
        public GiftCardRepo(Lana_jewelryDb? db) : base(db, db?.GiftCards) { }
        protected override GiftCard toDomain(GiftCardData d) => new (d);

    }
}
