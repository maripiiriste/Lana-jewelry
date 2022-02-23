using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Domain.Party{
    public class Costumer:Entity<CostumerData> {
        private const string defaultStr = "Undefined";
        private DateTime defaultDate => DateTime.MinValue;
        public Costumer(): this(new CostumerData()) { }
        public Costumer(CostumerData d) : base(d) { }
        public string Id=>Data?.Id?? defaultStr;
        public string FirstName => Data?.FirstName ?? defaultStr;
        public string LastName => Data?.LastName ?? defaultStr;
        public DateTime DoB => Data?.DoB ?? defaultDate;
        public string Email=>Data?.Email ?? defaultStr;
        public override string ToString() => $"{FirstName} {LastName} {Email} ({DoB})";
    }
}
