using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Data.Shipment
{
    public class TransportData:EntityData{
        public string CostumerAddress { get; set; }
        public double TransportPrice { get; set; }
        public DateTime TransportDuration { get; set; }
    }
}
  