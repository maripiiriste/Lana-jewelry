
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade.Shipment
{
    public sealed class TransportView: UniqueView
    {
        [DisplayName("Your aadress")] [Required] public string? CostumerAddress { get; set; }
        [DisplayName("Transportation cost")] [Required] public double TransportPrice { get; set; }
        [DisplayName("Arrival time")] [Required] public DateTime TransportDuration { get; set; }
    }
    public sealed class TransportViewFactory : BaseViewFactory<TransportView, Transport, TransportData>
    {
        protected override Transport toEntity(TransportData d) => new(d);

    }
}
