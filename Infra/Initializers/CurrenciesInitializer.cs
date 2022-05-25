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
                    var id = c.ISOCurrencySymbol;
                    if (!isCorrectIsoCode(id)) continue;
                    if (l.FirstOrDefault(x => x.Id == id) is not null) continue;
                    var d = createCurrency(id, c.CurrencyEnglishName, c.CurrencyNativeName);
                    l.Add(d);
                }
                return l; }
        }   internal static CurrencyData createCurrency(string code, string name, string description)
            => new(){Id = code?? UniqueData.NewId, Code = code?? UniqueEntity.DefaultStr, Name = name, Description=description};
    }
}
