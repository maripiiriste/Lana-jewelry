using Lana_jewelry.Aids;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace Lana_jewelry.Tests.Facade.Party
{
    public class CostumerViewFactoryTests: SealedClassTests<CostumerViewFactory> {
        [TestMethod] public void CreateTest() { }
        [TestMethod] public void CreateViewTest() {
            var d = GetRandom.Value<CostumerData>();
            var e = new Costumer(d);
            var v = new CostumerViewFactory().Create(e);
            isNotNull(v);
            areEqual(v.Id, e.Id);
            areEqual(v.FirstName, e.FirstName);
            areEqual(v.LastName, e.LastName);
            areEqual(v.Email, e.Email);
            areEqual(v.DoB, e.DoB);
        }
        [TestMethod] public void CreateEntityTest() {
            var v = GetRandom.Value<CostumerView>() as CostumerView;
            var e = new CostumerViewFactory().Create(v);
            isNotNull(e);
            isNotNull(v);
            arePropertiesEqual(e, v);
            areEqual(e.Id, v.Id);
            areEqual(e.FirstName, v.FirstName);
            areEqual(e.LastName, v.LastName);
            areEqual(e.Email, v.Email);
            areEqual(e.DoB, v.DoB);
        }
    }
}
