using Lana_jewelry.Aids;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lana_jewelry.Tests.Infra {
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
        [TestMethod] public void dbTest() => isReadOnly<DbContext?>();
        [TestMethod] public void setTest() => isReadOnly<DbSet<GiftCardData>?>();
        [TestMethod] public void BaseRepoTest() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            var set = db?.GiftCards;
            isNotNull(set);
            obj = new testClass(db, set);
            areEqual(db,obj.db);
            areEqual(set, obj.set);
        }
        [TestMethod] public async Task ClearTest() {
            BaseRepoTest();
            var cnt = GetRandom.Int32(5, 30);
            var db = obj.db;
            isNotNull(db);
            var set = obj.set;
            isNotNull(set);
            for (var i = 0; i < cnt; i++) set.Add(GetRandom.Value<GiftCardData>());
            areEqual(0, await set.CountAsync());
            db.SaveChanges();
            areEqual(cnt, await set.CountAsync());
            obj.clear();
            areEqual(obj, await set.CountAsync());
        }
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
}
