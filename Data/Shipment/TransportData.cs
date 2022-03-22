using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Data.Shipment
{
    public sealed class TransportData:EntityData{
        public string? CostumerAddress { get; set; }
        public double Price { get; set; }
        public DateTime Duration { get; set; }
    }
}
  