using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Domain.Party {
    public interface INecklaceRepo : IRepo<Necklace> { }
    public sealed class Necklace : UniqueEntity<NecklaceData> {
        public Necklace() : this(new()) { }
        public Necklace(NecklaceData d) : base(d) { }
        public string Name => getValue(Data?.Name);
        public double Price => getValue(Data?.Price);
        public int Quantity => getValue(Data?.Quantity);
    }
}
