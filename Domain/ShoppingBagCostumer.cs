using Lana_jewelry.Data;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Domain {
    public interface IShoppingBagCostumerRepo : IRepo<ShoppingBagCostumer> { }
    public sealed class ShoppingBagCostumer : NamedEntity<ShoppingBagCostumerData> {
        public ShoppingBagCostumer() : this(new ShoppingBagCostumerData()) { }
        public ShoppingBagCostumer(ShoppingBagCostumerData d) : base(d) { }
        public string ShoppingBagId => getValue(Data?.ShoppingBagId);
        public string CostumerId => getValue(Data?.CostumerId);
        public ShoppingBag? ShoppingBag => GetRepo.Instance<IShoppingBagRepo>()?.Get(ShoppingBagId);
        public Costumer? Costumer => GetRepo.Instance<ICostumersRepo>()?.Get(CostumerId);
    }
}
