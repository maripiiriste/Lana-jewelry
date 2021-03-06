using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public sealed class CurrenciesRepo : Repo<Currency, CurrencyData>, ICurrenciesRepo {
        public CurrenciesRepo(Lana_jewelryDb? db) : base(db, db?.Currencies) { }
        protected internal override Currency toDomain(CurrencyData d) => new (d);
        internal override IQueryable<CurrencyData> addFilter(IQueryable<CurrencyData> q) {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q : q.Where(
                x => x.Code.Contains(y)
                || x.Id.Contains(y)
                || x.Name.Contains(y)
                || x.Description.Contains(y));
        }
    }
}
