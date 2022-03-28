using Lana_jewelry.Data.Shipment;
using System.Globalization;

namespace Lana_jewelry.Infra.Initializers
{
    public sealed class CurrencyInitializer : BaseInitializer<CurrencyData>
    {
        public CurrencyInitializer(Lana_jewelryDb? db): base(db, db?.Currencies) { }
        protected override IEnumerable<CurrencyData> getEntities{
            get{
                var l = new List<CurrencyData>();
                foreach(CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures)){
                    var c = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                    var d = createCurrency(c.ThreeLetterISORegionName, c.EnglishName, c.NativeName);
                    if (l.FirstOrDefault(x => x.Id == d.Id) is not null) continue;
                    l.Add(d);
                }
                return l; }

        }
        internal static CurrencyData createCurrency(string code, string name, string symbol)
            => new(){Id = code, Code = code, Name = name, Symbol=symbol};
    }
}
