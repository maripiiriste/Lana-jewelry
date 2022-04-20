using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Domain.Party{
    public interface ICostumersRepo : IRepo<Costumer> { }
    public sealed class Costumer:UniqueEntity<CostumerData> {
        public Costumer(): this(new()) { }
        public Costumer(CostumerData d) : base(d) { }
        public string FirstName => getValue(Data?.FirstName);
        public string LastName => getValue(Data?.LastName);
        public DateTime DoB => getValue(Data?.DoB);
        public string Email=> getValue(Data?.Email);
        public override string ToString() => $"{FirstName} {LastName} {Email} ({DoB})";
    }
}
