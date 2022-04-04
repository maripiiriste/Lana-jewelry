using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public class InfoRepo : Repo<Info, InfoData>, IInfoRepo {
        public InfoRepo(Lana_jewelryDb? db) : base(db, db?.Infos) { }
        protected override Info toDomain(InfoData d) => new(d);

        //internal override IQueryable<InfoData> addFilter(IQueryable<InfoData> q) {
        //    var y = CurrentFilter;
        //    if (string.IsNullOrWhiteSpace(y)) return q;
        //    return q.Where(
        //        x => x.Street.Contains(y)
        //        || x.Id.Contains(y)
        //        || x.Country.Contains(y)
        //        || x.City.Contains(y)
        //        || x.Region.Contains(y)
        //        || x.ZipCode.Contains(y)
        //        || x.StreetNumber.Contains(y)
        //        || x.PhoneNumber.Contains(y)
        //        || x.EmailAddress.Contains(y));
        //}
    }
}
