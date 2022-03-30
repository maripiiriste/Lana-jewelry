using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Domain.Party
{
    public interface ICurrenciesRepo : IRepo<Currency> { }
    public sealed class Currency : NamedEntity<CurrencyData> {
        public Currency() : this(new CurrencyData()) { }
        public Currency(CurrencyData d) : base(d) { }
    }
}
