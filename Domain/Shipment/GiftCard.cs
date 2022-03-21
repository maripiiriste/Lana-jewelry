using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Domain.Shipment
{
    public interface IGiftCardRepo : IRepo<GiftCard> { }
    public sealed class GiftCard: Entity<GiftCardData>
    {
        public GiftCard() : this(new GiftCardData()) { }
        public GiftCard(GiftCardData d) : base(d) { }
        public double Price => getValue(Data?.Price);
    }
}
