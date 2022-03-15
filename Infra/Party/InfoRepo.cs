using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public class InfoRepo : Repo<Info, InfoData>, IInfoRepo {
        public InfoRepo(Lana_jewelryDb db) : base(db, db.Infos) { }
        protected override Info toDomain(InfoData d) => new(d);
    }
}
