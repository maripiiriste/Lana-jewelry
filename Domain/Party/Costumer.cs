using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Domain.Party{
    public interface ICostumersRepo : IRepo<Costumer> { }
    public class Costumer:Entity<CostumerData> {
        public Costumer(): this(new CostumerData()) { }
        public Costumer(CostumerData d) : base(d) { }
        public string FirstName => Data?.FirstName ?? defaultStr;
        public string LastName => Data?.LastName ?? defaultStr;
        public DateTime DoB => Data?.DoB ?? defaultDate;
        public string Email=>Data?.Email ?? defaultStr;
        public override string ToString() => $"{FirstName} {LastName} {Email} ({DoB})";
    }
}
