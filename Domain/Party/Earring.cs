using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Domain.Party {
    public interface IEarringRepo : IRepo<Earring> { }
    public sealed class Earring : UniqueEntity<EarringData> {
        public Earring() : this(new()) { }
        public Earring(EarringData d) : base(d) { }
        public string Name => getValue(Data?.Name);
        public double Price => getValue(Data?.Price);
        public int Quantity => getValue(Data?.Quantity);
    }
}
