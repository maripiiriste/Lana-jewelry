using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public class CurrenciesRepo : Repo<Currency, CurrencyData>, ICurrenciesRepo {
        public CurrenciesRepo(Lana_jewelryDb? db) : base(db, db?.Currencies) { }
        protected override Currency toDomain(CurrencyData d) => new (d);
        internal override IQueryable<CurrencyData> addFilter(IQueryable<CurrencyData> q) {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q : q.Where(
                x => contains(x.Code,y)
                || contains(x.Id,y)
                || contains(x.Name,y)
                || contains(x.Description,y));
        }
    }
}
