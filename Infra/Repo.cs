using Lana_jewelry.Data;
using Lana_jewelry.Domain;
using Microsoft.EntityFrameworkCore;

namespace Lana_jewelry.Infra{
    public abstract class Repo<TDomain, TData> : PagedRepo<TDomain, TData> 
        where TDomain : UniqueEntity<TData>, new() where TData:UniqueData, new(){
        protected Repo(DbContext? c, DbSet<TData>? s):base(c,s) {}
    }
}
