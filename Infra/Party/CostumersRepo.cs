using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;
using Microsoft.EntityFrameworkCore;


namespace Lana_jewelry.Infra.Party
{
    public class CostumersRepo : Repo<Costumer, CostumerData>, ICostumersRepo {
        public CostumersRepo(DbContext c, DbSet<CostumerData> s) : base(c, s) {}
        protected override Costumer toDomain(CostumerData d) => new Costumer(d);

    }
}
