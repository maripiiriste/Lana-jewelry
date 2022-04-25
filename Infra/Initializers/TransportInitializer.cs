using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Infra.Initializers
{
    public sealed class TransportInitializer : BaseInitializer<TransportData> {
        public TransportInitializer(Lana_jewelryDb? db) : base(db, db?.Transports) { }
        internal static TransportData createTransport(string id, string costumerAadress, double price, DateTime duration) {
            var transport = new TransportData {
                Id = id,
                Price = price,
                Duration = duration
            };
            return transport;
        }
        protected override IEnumerable<TransportData> getEntities => new[] {
            createTransport("HarryPotter", "Nelgi tee 37", 7, new DateTime(2022, 03, 27)),
            createTransport("HermioneGrenger", "Aia tee 5", 5, new DateTime(2022, 03, 29)),
            createTransport("RonaldWeasley", "Kauna 5", 15, new DateTime(2022, 03, 23)),
        };
    }
   
}
