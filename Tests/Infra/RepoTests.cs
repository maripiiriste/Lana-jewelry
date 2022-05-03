using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lana_jewelry.Tests.Infra
{
    [TestClass] public class RepoTests
        : AbstractClassTests<Repo<GiftCard, GiftCardData>, PagedRepo<GiftCard, GiftCardData>> {
        private class testClass : Repo<GiftCard, GiftCardData>{
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s){}
            protected internal override GiftCard toDomain(GiftCardData d)=> new (d);
        }
        protected override Repo<GiftCard, GiftCardData> createObj() => new testClass(null, null);
    }
    [TestClass] public class BaseRepoTests
        : AbstractClassTests<BaseRepo<GiftCard, GiftCardData>, object> {
        private class testClass : BaseRepo<GiftCard, GiftCardData> {
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s) { }
            public override bool Add(GiftCard obj)=> throw new NotImplementedException();
            public override Task<bool> AddAsync(GiftCard obj) => throw new NotImplementedException();
            public override bool Delete(string id) =>throw new NotImplementedException();
            public override Task<bool> DeleteAsync(string id) => throw new NotImplementedException();
            public override List<GiftCard> Get()=> throw new NotImplementedException();
            public override GiftCard Get(string id) =>  throw new NotImplementedException();
            public override List<GiftCard> GetAll(Func<GiftCard, dynamic>? orderBy = null)
                => throw new NotImplementedException();
            public override Task<List<GiftCard>> GetAsync()=> throw new NotImplementedException();
            public override Task<GiftCard> GetAsync(string id) => throw new NotImplementedException();
            public override bool Update(GiftCard obj) =>throw new NotImplementedException();
            public override Task<bool> UpdateAsync(GiftCard obj) =>  throw new NotImplementedException();
        }
        protected override BaseRepo<GiftCard, GiftCardData> createObj() => new testClass(null, null);

        [TestMethod] public void DbTest() => isInconclusive();
        [TestMethod] public void SetTest() => isInconclusive();
        [TestMethod] public void BaseRepoTest() => isInconclusive();
        [TestMethod]public void ClearTest() => isInconclusive();
        [TestMethod] public void AddTest() => isAbstractMethod(nameof(obj.Add), typeof(GiftCard));
        [TestMethod] public void AddAsyncTest() => isAbstractMethod(nameof(obj.AddAsync), typeof(GiftCard));
        [TestMethod] public void DeleteTest() => isAbstractMethod(nameof(obj.Delete), typeof(string));
        [TestMethod] public void DeleteAsyncTest() => isAbstractMethod(nameof(obj.DeleteAsync), typeof(string));
        [TestMethod] public void GetListTest() => isAbstractMethod(nameof(obj.Get));
        [TestMethod] public void GetAllTest() => isAbstractMethod(nameof(obj.GetAll), typeof(Func<GiftCard, dynamic>));
        [TestMethod] public void GetTest() => isAbstractMethod(nameof(obj.Get), typeof(string));
        [TestMethod] public void GetListAsyncTest() => isAbstractMethod(nameof(obj.GetAsync));
        [TestMethod] public void GetAsyncTest() => isAbstractMethod(nameof(obj.GetAsync), typeof(string));
        [TestMethod] public void UpdateTest() => isAbstractMethod(nameof(obj.Update), typeof(GiftCard));
        [TestMethod] public void UpdateAsyncTest() => isAbstractMethod(nameof(obj.UpdateAsync), typeof(GiftCard));
    }

    [TestClass] public class CrudRepoTests
        :AbstractClassTests<CrudRepo<GiftCard, GiftCardData>, BaseRepo<GiftCard, GiftCardData>> {
        private class testClass : CrudRepo<GiftCard, GiftCardData> {
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s) { }
            protected internal override GiftCard toDomain(GiftCardData d) => new(d);
        }
        protected override CrudRepo<GiftCard, GiftCardData> createObj() => new testClass(null, null);
    }
    [TestClass] public class FilteredRepoTests
        : AbstractClassTests<FilteredRepo<GiftCard, GiftCardData>, FilteredRepo<GiftCard, GiftCardData>> {
        private class testClass : FilteredRepo<GiftCard, GiftCardData> {
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s) { }
            protected internal override GiftCard toDomain(GiftCardData d) => new(d);
        }
        protected override FilteredRepo<GiftCard, GiftCardData> createObj() => new testClass(null, null);
    }
    [TestClass] public class OrderedRepoTests
        : AbstractClassTests<OrderedRepo<GiftCard, GiftCardData>, OrderedRepo<GiftCard, GiftCardData>> {
        private class testClass : OrderedRepo<GiftCard, GiftCardData> {
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s) { }
            protected internal override GiftCard toDomain(GiftCardData d) => new(d);
        }
        protected override OrderedRepo<GiftCard, GiftCardData> createObj() => new testClass(null, null);
    }
    [TestClass] public class PagedRepoTests
        : AbstractClassTests<PagedRepo<GiftCard, GiftCardData>, PagedRepo<GiftCard, GiftCardData>> {
        private class testClass : PagedRepo<GiftCard, GiftCardData> {
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s) { }
            protected internal override GiftCard toDomain(GiftCardData d) => new(d);
        }
        protected override PagedRepo<GiftCard, GiftCardData> createObj() => new testClass(null, null);
    }
    [TestClass] public class Lana_jewelryDbTests : SealedBaseTests<Lana_jewelryDb, DbContext> {
        protected override Lana_jewelryDb createObj() => null;
        protected override void isSealedTest() => isInconclusive();
    }
}
