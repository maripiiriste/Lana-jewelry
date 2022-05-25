using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Infra.Initializers
{
    public sealed class TransportInitializer : BaseInitializer<TransportData> {
        public TransportInitializer(Lana_jewelryDb? db) : base(db, db?.Transports) { }
        internal static TransportData createTransport(string id, double price, DateTime duration, string countryId, string city, string street, string zipCode) {
            var transport = new TransportData {
                Id = id,
                Price = price,
                Duration = duration,
                CountryId = countryId,
                City = city,
                Street = street,
                ZipCode = zipCode,
            };
            return transport;
        }
        protected override IEnumerable<TransportData> getEntities => new[] {
            createTransport("HarryPotter", 7, new DateTime(2022, 03, 27), "Italy", "Milan", "Nelgi", "20057"),
            createTransport("HermioneGrenger", 5, new DateTime(2022, 03, 29), "Italy", "Rome", "Kauna", "40042"),
            createTransport("RonaldWeasley", 15, new DateTime(2022, 03, 23), "Italy", "Venice", "Nelgi", "30387"),
        };
    }
}
