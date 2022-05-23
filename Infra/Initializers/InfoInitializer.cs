using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Infra.Initializers {
    public sealed class InfoInitializer: BaseInitializer<InfoData> {
        
        public InfoInitializer(Lana_jewelryDb? db) :base(db,db?.Infos){}
        protected override IEnumerable<InfoData> getEntities => new[] {
          createInfo("Italy", "Milan", "Lombardy", "Lanzone", "21", "20068", "+39 5554486", "lana_jewelry.milan@gmail.com"),
        };
        internal static InfoData createInfo(string Country, string City,string Region, string Street, string StreetNumber, string ZipCode, string PhoneNumber, string EmailAddress) {
            var info = new InfoData {
                Country=Country,
                City=City,
                Region=Region,
                Street=Street,
                StreetNumber=StreetNumber,
                ZipCode=ZipCode,
                PhoneNumber=PhoneNumber,
                EmailAddress=EmailAddress
            };
            return info;
        }
    }
}
