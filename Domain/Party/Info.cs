using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Domain.Party
{
    public interface IInfoRepo : IRepo<Info> { }
    public sealed class Info : Entity<InfoData> {
        public Info() : this(new InfoData()) { }
        public Info(InfoData d) : base(d) { }
        public string Country=>Data?.Country?? defaultStr;
        public string City=>Data?.City ?? defaultStr;
        public string Region=>Data?.Region ?? defaultStr;
        public string Street=>Data?.Street ?? defaultStr;
        public string StreetNumber=>Data?.StreetNumber ?? defaultStr;
        public string ZipCode=>Data?.ZipCode ?? defaultStr;
        public string PhoneNumber=>Data?.PhoneNumber ?? defaultStr;
        public string EmailAddress=>Data?.EmailAddress ?? defaultStr;
    }
}
