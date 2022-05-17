using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Domain.Shipment
{
    public interface IJewelryRepo : IRepo<Jewelry> { }
    public sealed  class Jewelry: UniqueEntity<JewelryData>{
        public Jewelry() : this(new()) { }
        public Jewelry(JewelryData d) : base(d) { }
        public string Ring => getValue(Data?.Ring);
        public string Necklace => getValue(Data?.Necklace);
        public string Bracelet => getValue(Data?.Bracelet);
        public string Earring => getValue(Data?.Earring);
    }
}
