using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Domain.Party
{
    public interface ICurrenciesRepo : IRepo<Currency> { }
    public sealed class Currency : Entity<CurrencyData> {
        public Currency() : this(new CurrencyData()) { }
        public Currency(CurrencyData d) : base(d) { }
        public string Name => getValue(Data?.Name);
        public string Code => getValue(Data?.Code);
        public string Description => getValue(Data?.Description);
    }
}
