namespace Lana_jewelry.Data {
    public abstract class TypeData:UniqueData {
        public string? Name { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
