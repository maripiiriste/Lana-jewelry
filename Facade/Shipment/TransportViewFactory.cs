using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;

namespace Lana_jewelry.Facade.Shipment{
    public class TransportViewFactory{
        public Transport Create(TransportView v) => new Transport(new TransportData {
            Id = v.Id,
            CostumerAddress = v.CostumerAddress,
            Price = v.TransportPrice,
            Duration = v.TransportDuration
        });
        public TransportView Create(Transport o) => new(){
        Id = o.TransportId,
        CostumerAddress = o.CostumerAddress,
        TransportPrice = o.TransportPrice,
        TransportDuration = o.TransportDuration
        };

    }
}
