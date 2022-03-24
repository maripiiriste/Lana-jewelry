namespace Lana_jewelry.Data.Shipment
{
    public class CountryData: EntityData{
        public string Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
    public class CurrencyData : EntityData
    {
    }
}
