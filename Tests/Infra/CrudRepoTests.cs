using Lana_jewelry.Aids;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace Lana_jewelry.Tests.Infra {
    [TestClass] public class CrudRepoTests
        :AbstractClassTests<CrudRepo<GiftCard, GiftCardData>, BaseRepo<GiftCard, GiftCardData>> {
        private Lana_jewelryDb? db;
        private DbSet<GiftCardData>? set;
        private GiftCardData? d;
        private GiftCard? g;
        private int cnt;
        private class testClass : CrudRepo<GiftCard, GiftCardData> {
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s) { }
            protected internal override GiftCard toDomain(GiftCardData d) => new(d);
        }
        protected override CrudRepo<GiftCard, GiftCardData> createObj() {
            db = GetRepo.Instance<Lana_jewelryDb>();
            set = db?.GiftCards;
            isNotNull(set);
            return new testClass(db,set);
        }
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            initSet();
            initGiftCard();
        }
        private void initSet() {
            cnt = GetRandom.Int32(5,15);
            for (var i = 0; i < cnt; i++) set?.Add(GetRandom.Value<GiftCardData>());
            _=db?.SaveChanges();
        }
        private void initGiftCard() {
            d = GetRandom.Value<GiftCardData>();
            isNotNull(d);
            g = new GiftCard(d);
            var x = obj.Get(d.Id);
            isNotNull(x);
            areNotEqual(d.Id, x.Id);
        }
        [TestMethod] public async Task AddTest() {
            isNotNull(g);
            isNotNull(set);
            _ = obj?.Add(g);
            areEqual(cnt+1,await set.CountAsync());
        }
        [TestMethod] public async Task AddAsyncTest() {
            isNotNull(g);
            isNotNull(set);
            _ = await obj.AddAsync(g);
            areEqual(cnt + 1, await set.CountAsync());
        }
        [TestMethod] public async Task DeleteTest() {
            isNotNull(d);
            await GetTest();
            _ = obj.Delete(d.Id);
            var x = obj.Get(d.Id);
            isNotNull(x);
            areNotEqual(d.Id, x.Id);
        }
        [TestMethod] public async Task DeleteAsyncTest() {
            isNotNull(d);
            await GetTest();
            _ = await obj.DeleteAsync(d.Id);
            var x = obj.Get(d.Id);
            isNotNull(x);
            areNotEqual(d.Id, x.Id);
        }
        [TestMethod] public async Task GetTest() {
            isNotNull(d);
            await AddTest();
            var x = obj.Get(d.Id);
            arePropertiesEqual(d, x.Data);
        }

        [DataRow(nameof(GiftCardData.Id))]
        [DataRow(nameof(GiftCardData.Price))]
        [DataRow(null)]
        [TestMethod] public void GetAllTest(string s) {
            Func<GiftCard, dynamic>? orderBy =null;
            if (s is nameof(GiftCard.Id)) orderBy = x => x.Id;
            else if (s is nameof(GiftCard.Price)) orderBy = x => x.Price;
            var l= obj.GetAll(orderBy);
            areEqual(cnt, l.Count);
            if (orderBy is null) return;
            for(var i=0; i < l.Count - 1; i++) {
                var a = l[i];
                var b = l[i + 1];
                var aX = orderBy(a) as IComparable;
                var bX = orderBy(b) as IComparable;
                isNotNull(aX);
                isNotNull(bX);
                var r = aX.CompareTo(bX);
                isTrue(r <= 0);
            }
        }
        [TestMethod] public void GetListTest() {
            var l=obj.Get();
            areEqual(cnt, l.Count);
        }
        [TestMethod] public async Task GetAsyncTest() {
            await AddTest();
            var x = await obj.GetAsync(d.Id);
            arePropertiesEqual(d, x.Data);
        }
        [TestMethod] public async Task GetListAsyncTest() {
            var l =  await obj.GetAsync();
            areEqual(cnt, l.Count);
        }
        [TestMethod] public async Task UpdateTest() {
            await GetTest();
            var dX = GetRandom.Value<GiftCardData>() as GiftCardData;
            isNotNull(d);
            isNotNull(dX);
            dX.Id = d.Id;
            var aX = new GiftCard(dX);
            _ = obj.Update(aX);
            var x=obj.Get(d.Id);
            arePropertiesEqual(dX, x.Data);
        }
        [TestMethod] public async Task UpdateAsyncTest() {
            await GetTest();
            var dX = GetRandom.Value<GiftCardData>() as GiftCardData;
            isNotNull(d);
            isNotNull(dX);
            dX.Id = d.Id;
            var aX = new GiftCard(dX);
            _ = await obj.UpdateAsync(aX);
            var x = obj.Get(d.Id);
            arePropertiesEqual(dX, x.Data);
        }
    }
}
