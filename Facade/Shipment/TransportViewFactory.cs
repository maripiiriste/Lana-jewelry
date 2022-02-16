using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Shipment;

namespace Lana_jewelry.Facade.Shipment{
    public class TransportViewFactory{
        public Transport Greate(TransportView v) => new Transport(new TransportData {
            TansportId = v.TansportId,
            CostumerAddress = v.CostumerAddress,
            TransportPrice = v.TransportPrice,
            TrasnportDuration = v.TrasnportDuration
        });
        public TransportView Greate(Transport o) => new(){
        TansportId = o.TansportId,
        CostumerAddress = o.CostumerAddress,
        TransportPrice = o.TransportPrice,
        TrasnportDuration = o.TrasnportDuration
        };

        public TransportView Greate(Lana_jewelry.Pages.Transports transports)
        {
            throw new NotImplementedException();
        }
    }
}
