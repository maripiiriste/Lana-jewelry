using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Infra.Initializers {
    public sealed class CostumersInitializer : BaseInitializer<CostumerData> {
        public CostumersInitializer(Lana_jewelryDb? db) : base(db, db?.Costumers){}
        internal static CostumerData createCostumer(string firstnName, string lastName, DateTime dob, string email ) {
            var costumer = new CostumerData {
                Id = email,
                FirstName = firstnName,
                LastName = lastName,
                DoB = dob,
                Email = email
            };
            return costumer;
        }
        protected override IEnumerable<CostumerData> getEntities=> new [] {
            createCostumer("Hanna", "Puu", new DateTime(2002,03,30), "Hannapuu@gmail.com"),
            createCostumer("Elle", "Randoja", new DateTime(2001, 12, 30), "Ellerandoja@gmail.com"),
            createCostumer("Maria", "Kikas", new DateTime(2002, 11, 20), "Mariakikas@gmail.com"),
        };
    }
}
