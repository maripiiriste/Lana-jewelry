using Lana_jewelry.Data.Shipment;
using System.Globalization;

namespace Lana_jewelry.Infra.Initializers
{
    public sealed class CountriesInitializer : BaseInitializer<CountryData>
    {
        public CountriesInitializer(Lana_jewelryDb? db): base(db, db?.Countries) { }
        protected override IEnumerable<CountryData> getEntities{
            get{
                var l = new List<CountryData>();
                foreach(CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures)){
                    var c = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                    var d = createCountry(c.ThreeLetterISORegionName, c.EnglishName, c.NativeName);
                    if (l.FirstOrDefault(x => x.Id == d.Id) is not null) continue;
                    l.Add(d);
                }
                return l; }

        }
        internal static CountryData createCountry(string code, string name, string description)
            => new(){Id = code, Code = code, Name = name, Description=description };
    }
}
