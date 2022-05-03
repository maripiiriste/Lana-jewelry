using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Infra;
using Lana_jewelry.Infra.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Infra.Party {
    [TestClass] public class TransportsTests : SealedRepoTests<TransportsRepo, Repo<Transport, TransportData>, Transport, TransportData> {
        protected override TransportsRepo createObj() => new(GetRepo.Instance<Lana_jewelryDb>());
        protected override object? getSet(Lana_jewelryDb db) => db.Transports;
        }
    }

