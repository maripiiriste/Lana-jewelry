using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Facade.Shipment;

namespace Lana_jewelry.Pages
{
    public class TransportPage : BasePage<TransportView, Transport, ITransportsRepo>{
        public TransportPage(ITransportsRepo r) : base(r) { }
        protected override Transport toObject(TransportView? item) => new TransportViewFactory().Create(item);
        protected override TransportView toView(Transport? entity) => new TransportViewFactory().Create(entity);
    }
}


