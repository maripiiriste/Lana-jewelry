using Lana_jewelry.Data;
using Lana_jewelry.Domain;
using Microsoft.EntityFrameworkCore;

namespace Lana_jewelry.Infra {
    public abstract class FilteredRepo<TDomain, TData> : CrudRepo<TDomain, TData>
        where TDomain : UniqueEntity<TData>, new() where TData : UniqueData, new() {
        protected FilteredRepo(DbContext? c, DbSet<TData>? s) : base(c, s) { }
        public string? CurrentFilter { get; set; }
        protected internal override IQueryable<TData> createSql() => addFilter(base.createSql());
        internal virtual IQueryable<TData> addFilter(IQueryable<TData> q)=> q;
    }
}
