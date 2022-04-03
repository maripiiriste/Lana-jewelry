﻿using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public class CurrenciesRepo : Repo<Currency, CurrencyData>, ICurrenciesRepo {
        public CurrenciesRepo(Lana_jewelryDb? db) : base(db, db?.Currencies) { }
        protected override Currency toDomain(CurrencyData d) => new (d);
        internal override IQueryable<CurrencyData> addFilter(IQueryable<CurrencyData> q) {
            var y = CurrentFilter;
            if (string.IsNullOrWhiteSpace(y)) return q;
            return q.Where(
                x => x.Code.Contains(y)
                || x.Id.Contains(y)
                || x.Name.Contains(y)
                || x.Description.Contains(y));
        }
    }
}
