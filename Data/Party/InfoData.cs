namespace Lana_jewelry.Data.Party{
    public sealed class InfoData:UniqueData {
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? Street { get; set; }
        public string? StreetNumber {get; set;}
        public string? ZipCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
    }
}
