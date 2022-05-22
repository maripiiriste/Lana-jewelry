using Lana_jewelry.Data.Party;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lana_jewelry.Domain.Party {
    public interface IBraceletRepo : IRepo<Bracelet> { }
    public sealed class Bracelet : UniqueEntity<BraceletData> {
        public Bracelet() : this(new()) { }
        public Bracelet(BraceletData d) : base(d) { }
        public string Name => getValue(Data?.Name);
        public double Price => getValue(Data?.Price);
        public int Quantity => getValue(Data?.Quantity);
    }
}
