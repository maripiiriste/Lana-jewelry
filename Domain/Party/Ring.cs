using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Domain.Party {
    public interface IRingRepo : IRepo<Ring> { }
    public sealed class Ring : UniqueEntity<RingData> {
        public Ring() : this(new()) { }
        public Ring(RingData d) : base(d) { }
        public string Name => getValue(Data?.Name);
        public double Price => getValue(Data?.Price);
        public int Quantity => getValue(Data?.Quantity);
    }
}
