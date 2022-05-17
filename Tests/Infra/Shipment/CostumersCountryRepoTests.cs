using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Infra;
using Lana_jewelry.Infra.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Infra.Party {
    [TestClass] public class CostumersCountryRepoTests : SealedRepoTests<CostumersCountryRepo, Repo<CostumerCountry, CostumerCountryData>
        , CostumerCountry, CostumerCountryData> {
        protected override CostumersCountryRepo createObj() => new(GetRepo.Instance<Lana_jewelryDb>());
        protected override object? getSet(Lana_jewelryDb db) => db.CostumerCountries;
    }
    }

