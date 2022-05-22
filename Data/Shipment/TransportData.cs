namespace Lana_jewelry.Data.Shipment{
    public sealed class TransportData:UniqueData{
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? CountryId { get; set; }
        public double Price { get; set; }
        public DateTime Duration { get; set; }
    }
}
  