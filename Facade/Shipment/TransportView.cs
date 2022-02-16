
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade.Shipment
{
    public class TransportView
    {
        [Key]
        [Required] public string TransportId { get; set; }
        [DisplayName("Your aadress")] [Required] public string CostumerAddress { get; set; }
        [DisplayName("Transportation cost")] [Required] public double TransportPrice { get; set; }
        [DisplayName("Arrival time")] [Required] public DateTime TransportDuration { get; set; }
    }
}
