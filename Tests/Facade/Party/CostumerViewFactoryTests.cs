using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lana_jewelry.Tests.Facade.Party
{
    public class CostumerViewFactoryTests: SealedClassTests<CostumerViewFactory> {
        [TestMethod] public void CreateTest() { }
        [TestMethod] public void CreateViewTest() {
            var d = new CostumerData() {
                Id = "Id",
                FirstName = "First",
                LastName = "Last",
                DoB = DateTime.Now,
                Email = "Email"
            };
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
            var v = new CostumerView() {
                Id = "Id",
                FirstName = "First",
                LastName = "Last",
                DoB = DateTime.Now,
                Email = "Email"
            };
            var e = new CostumerViewFactory().Create(v);
            isNotNull(e);
            areEqual(e.Id, v.Id);
            areEqual(e.FirstName, v.FirstName);
            areEqual(e.LastName, v.LastName);
            areEqual(e.Email, v.Email);
            areEqual(e.DoB, v.DoB);
        }
    }
}
