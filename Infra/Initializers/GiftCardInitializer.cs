using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Infra.Initializers
{
    public sealed class GiftCardInitializer:BaseInitializer<GiftCardData>{
        public GiftCardInitializer(Lana_jewelryDb? db) : base(db, db?.GiftCards) { }
        protected override IEnumerable<GiftCardData> getEntities => new []{
            createGiftCard("HarryPotter", 25),
            createGiftCard("HermioneGrenger", 50),
            createGiftCard("RonaldWeasley", 15),
        };
        internal static GiftCardData createGiftCard(string id,double price){
            var giftCard = new GiftCardData{
                Id = id,
                Price = price
            };
            return giftCard;
        }
    }
}
