namespace Lana_jewelry.Infra.Initializers {
    public static class Lana_jewelryDbInitializer {
        public static void Init(Lana_jewelryDb? db) {
         new GiftCardInitializer(db).Init();
         new TransportInitializer(db).Init();
         new CountriesInitializer(db).Init();
         new CostumersInitializer(db).Init();
         new InfoInitializer(db).Init();
         new CurrenciesInitializer(db).Init();
         new CountryCurrenciesInitializer(db).Init();
        }
       
    }

}
