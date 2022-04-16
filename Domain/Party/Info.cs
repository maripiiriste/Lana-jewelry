using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Domain.Party
{
    public interface IInfoRepo : IRepo<Info> { }
    public sealed class Info : UniqueEntity<InfoData> {
        public Info() : this(new()) { }
        public Info(InfoData d) : base(d) { }
        public string Country=>getValue(Data?.Country);
        public string City=> getValue(Data?.City);
        public string Region=> getValue(Data?.Region);
        public string Street=> getValue(Data?.Street);
        public string StreetNumber=> getValue(Data?.StreetNumber);
        public string ZipCode=> getValue(Data?.ZipCode);
        public string PhoneNumber=> getValue(Data?.PhoneNumber);
        public string EmailAddress=> getValue(Data?.EmailAddress);
    }
}
