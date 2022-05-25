using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Domain.Shipment{
    public interface ITransportShoppingBagRepo : IRepo<TransportShoppingBag> { }
    public sealed class TransportShoppingBag : NamedEntity<TransportShoppingBagData> {
        public TransportShoppingBag() : this(new TransportShoppingBagData()) { }
        public TransportShoppingBag(TransportShoppingBagData d) : base(d) { }
        public string ShoppingBagId => getValue(Data?.ShoppingBagId);
        public string TransportId => getValue(Data?.TransportId);
        public ShoppingBag? ShoppingBag => GetRepo.Instance<IShoppingBagRepo>()?.Get(ShoppingBagId);
        public Transport? Transport => GetRepo.Instance<ITransportsRepo>()?.Get(TransportId);
    }
}
