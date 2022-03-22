using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lana_jewelry.Data.Shipment;
using Microsoft.EntityFrameworkCore;

namespace Lana_jewelry.Infra.Initializers
{
    public sealed class GiftCardInitializer:BaseInitializer{
        internal Lana_jewelryDb database;
        internal DbSet<GiftCardData> giftCards;
        public GiftCardInitializer(Lana_jewelryDb db, DbSet<GiftCardData> set)
        {
            database = db;
            giftCards = set;
        }
        public void Initi()
        {
            var harry = createGiftCard("HarryPotter", 25);
            var hermione = createGiftCard("HermioneGrenger", 50);
            var ron = createGiftCard("RonaldWeasley", 15);
            giftCards.Add(harry);
            giftCards.Add(hermione);
            giftCards.Add(ron);
            database.SaveChanges();
        }
        internal static GiftCardData createGiftCard(string id,double price)
        {
            var giftCard = new GiftCardData
            {
                Id = id,
                Price = price
            };
            return giftCard;
        }
    }
    internal class TransportInitializer: BaseInitializer{
        internal Lana_jewelryDb database;
        internal DbSet<TransportData> transports;
        public TransportInitializer(Lana_jewelryDb db, DbSet<TransportData> set){
            database = db;
            transports = set;
        }
        public void Initi(){
            var harry = createTransport("HarryPotter", "Nelgi tee 37", 7, new DateTime(27,03,2022));
            var hermione = createTransport("HermioneGrenger", "Aia tee 5", 5, new DateTime(29, 03, 2022));
            var ron= createTransport("RonaldWeasley", "Kauna 5", 15, new DateTime(23, 03, 2022));
            transports.Add(harry);
            transports.Add(hermione);
            transports.Add(ron);
            database.SaveChanges();
        }
        internal static TransportData createTransport(string id, string costumerAadress, double price, DateTime duration ){
            var transport = new TransportData{
                Id = id,
                CostumerAddress = costumerAadress,
                Price = price,
                Duration = duration
            };
            return transport;
        }
    }
    public abstract class BaseInitializer{

    }
}
