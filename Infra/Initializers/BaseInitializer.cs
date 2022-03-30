using Lana_jewelry.Data;
using Microsoft.EntityFrameworkCore;

namespace Lana_jewelry.Infra.Initializers
{
    public abstract class BaseInitializer<TData> where TData : UniqueData{
            internal protected DbContext? db;
            internal protected DbSet<TData>? set;
            protected BaseInitializer(DbContext? c, DbSet<TData>? s){
                db = c;
                set = s;
            }
            public void Init() {
                if (set?.Any() ?? true) return;
                set.AddRange(getEntities);
                db?.SaveChanges();
            }
            protected abstract IEnumerable<TData> getEntities { get; }
            internal static bool isCorrectIsoCode(string id) => string.IsNullOrWhiteSpace(id) ? false : char.IsLetter(id[0]);

    }
    public static class Lana_jewelryDbInitializer {
        public static void Init(Lana_jewelryDb? db) {
         new GiftCardInitializer(db).Init();
         new TransportInitializer(db).Init();
         new CountriesInitializer(db).Init();
         new CostumersInitializer(db).Init();
         new InfoInitializer(db).Init();
         new CurrenciesInitializer(db).Init();
        }
       
    }

}
