using Lana_jewelry.Data;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using System.Globalization;

namespace Lana_jewelry.Infra.Initializers
{
    public sealed class CurrenciesInitializer : BaseInitializer<CurrencyData>
    {
        public CurrenciesInitializer(Lana_jewelryDb? db): base(db, db?.Currencies) { }
        protected override IEnumerable<CurrencyData> getEntities{
            get{
                var l = new List<CurrencyData>();
                foreach(CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures)){
                    var c = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                    if (l.FirstOrDefault(x => x.Id == c.ISOCurrencySymbol) is not null) continue;
                    if (string.IsNullOrWhiteSpace(c.ISOCurrencySymbol)) continue;
                    var d = createCurrency(c.ISOCurrencySymbol, c.CurrencyEnglishName, c.CurrencyNativeName);
                    l.Add(d);
                }
                return l; }

        }
        internal static CurrencyData createCurrency(string code, string name, string description)
            => new(){Id = code?? EntityData.NewId, Code = code?? Entity.DefaultStr, Name = name, Description=description};
    }
}
