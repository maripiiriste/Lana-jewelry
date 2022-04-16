using Lana_jewelry.Data;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain;
using System.Globalization;

namespace Lana_jewelry.Infra.Initializers {
    public sealed class CountryCurrenciesInitializer : BaseInitializer<CountryCurrencyData> {
        public CountryCurrenciesInitializer(Lana_jewelryDb? db) : base(db, db?.CountryCurrencies) { }
        protected override IEnumerable<CountryCurrencyData> getEntities {
            get {
                var l = new List<CountryCurrencyData>();
                foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures)) {
                    var c = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                    var countryId = c.ThreeLetterISORegionName;
                    var currencyId = c.ISOCurrencySymbol;
                    var nativeName = c.CurrencyNativeName;
                    var currencyCode = c.CurrencySymbol;
                    var d = createEntity(countryId, currencyId, currencyCode, nativeName);
                    l.Add(d);
                }
                return l;
            }
        }

        internal static CountryCurrencyData createEntity(string countryId, string currencyId,string code, string? name=null, string? description=null)
            => new() { 
                Id = UniqueData.NewId,
                CurrencyId=currencyId,
                CountryId=countryId,
                Code = code ?? UniqueEntity.DefaultStr, 
                Name = name, 
                Description = description 
            };
    }
    public sealed class CostumerCountryInitializer : BaseInitializer<CostumerCountryData>
    {
        public CostumersCountryInitializer(Lana_jewelryDb? db) : base(db, db?.CostumersCountry) { }
        protected override IEnumerable<CostumerCountryData> getEntities
        {
            get
            {
                var l = new List<CostumerCountryData>();
                foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
                {
                    var c = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                    var countryId = c.ThreeLetterISORegionName;
                    var costumerId = c.ISOCostumerSymbol;
                    var nativeName = c.CostumerNativeName;
                    var costumerCode = c.CostumerSymbol;
                    var d = createEntity(countryId, costumerId, costumerCode, nativeName);
                    l.Add(d);
                }
                return l;
            }
        }

        internal static CostumerCountryData createEntity(string countryId, string costumerId, string code, string? name = null, string? description = null)
            => new()
            {
                Id = UniqueData.NewId,
                CostumerId = costumerId,
                CountryId = countryId,
                Code = code ?? UniqueEntity.DefaultStr,
                Name = name,
                Description = description
            };
    }
}
