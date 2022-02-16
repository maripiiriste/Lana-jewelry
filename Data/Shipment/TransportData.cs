
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Data.Party
{
    public class TransportData
    {
        [Key]
        public string TansportId { get; set; }
        public string CostumerAddress { get; set; }
        public double TransportPrice { get; set; }
        public DateTime TrasnportDuration { get; set; }
    }
}
  