using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public class CostumersRepo : Repo<Costumer, CostumerData>, ICostumersRepo {
        public CostumersRepo(Lana_jewelryDb db) : base(db, db.Costumers) {}
        protected override Costumer toDomain(CostumerData d) => new Costumer(d);
    }
}
