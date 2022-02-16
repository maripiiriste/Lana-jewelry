using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;

namespace Lana_jewelry.Facade.Shipment{
    public class TransportViewFactory{
        public Transport Create(TransportView v) => new Transport(new TransportData {
            TransportId = v.TransportId,
            CostumerAddress = v.CostumerAddress,
            TransportPrice = v.TransportPrice,
            TransportDuration = v.TransportDuration
        });
        public TransportView Create(Transport o) => new(){
        TransportId = o.TransportId,
        CostumerAddress = o.CostumerAddress,
        TransportPrice = o.TransportPrice,
        TransportDuration = o.TransportDuration
        };

    }
}
