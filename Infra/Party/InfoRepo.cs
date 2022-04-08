using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public class InfoRepo : Repo<Info, InfoData>, IInfoRepo {
        public InfoRepo(Lana_jewelryDb? db) : base(db, db?.Infos) { }
        protected override Info toDomain(InfoData d) => new(d);

        internal override IQueryable<InfoData> addFilter(IQueryable<InfoData> q) {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q: q.Where(
                x => contains(x.Street,y)
                || contains(x.Id,y)
                || contains(x.Country,y)
                || contains(x.City,y)
                || contains(x.Region,y)
                || contains(x.ZipCode,y)
                || contains(x.StreetNumber,y)
                || contains(x.PhoneNumber,y)
                || contains(x.EmailAddress,y));
        }
    }
}
