using Lana_jewelry.Data;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain;
using System.Globalization;

namespace Lana_jewelry.Infra.Initializers {
    public sealed class CostumerCountryInitializer : BaseInitializer<CostumerCountryData> {
        public CostumerCountryInitializer(Lana_jewelryDb? db) : base(db, db?.CostumerCountries) { }
        protected override IEnumerable<CostumerCountryData> getEntities {
            get {
                var l = new List<CostumerCountryData>();
                foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures)) {
                    var c = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                    var countryId = c.ThreeLetterISORegionName;
                    //var costumerId = c.ISOCostumerSymbol;
                    var nativeName = c.NativeName;
                    //var costumerCode = c.CostumerSymbol;
                    var d = createEntity(countryId, /*costumerId, costumerCode,*/ nativeName);
                    l.Add(d);
                }
                return l;
            }
        }

        internal static CostumerCountryData createEntity(string countryId, /*/*string costumerId,*/ string code, string? name = null, string? description = null)
            => new() {
                Id = UniqueData.NewId,
                //CostumerId = costumerId,
                CountryId = countryId,
                Code = code ?? UniqueEntity.DefaultStr,
                Name = name,
                Description = description
            };
    }
}
