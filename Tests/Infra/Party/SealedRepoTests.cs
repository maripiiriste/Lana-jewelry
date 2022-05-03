using Lana_jewelry.Aids;
using Lana_jewelry.Data;
using Lana_jewelry.Domain;
using Lana_jewelry.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lana_jewelry.Tests.Infra.Party {
    public abstract class SealedRepoTests<TClass, TBaseClass, TDomain, TData>
        : SealedBaseTests<TClass, TBaseClass>
        where TClass :FilteredRepo<TDomain, TData>
        where TBaseClass : class
        where TDomain : UniqueEntity<TData>, new() where TData : UniqueData, new() {
        private static Type lana_jewelryType => typeof(Lana_jewelryDb);
        private static Type setType => typeof(DbSet<TData>);
        private Lana_jewelryDb? lana_jewelryDb {
            get {
                var o = obj.db;
                isNotNull(o);
                var db = o as Lana_jewelryDb;
                isNotNull(db);
                return db;
            }
        }
        protected void instanceTest(object? o, Type t) {
            isNotNull(o);
            isInstanceOfType(o, t);
        }
        protected void instanceTest(object? o, Type t, object? expected) {
            instanceTest(o, t);
            instanceTest(expected, t);
            areEqual(expected, o);
        }
        [TestMethod] public void DbContextTest() => instanceTest(obj.db, lana_jewelryType);
        [TestMethod] public void DbSetTest() => instanceTest(obj.set, setType, getSet(lana_jewelryDb));
        [TestMethod] public void ToDomainTest() {
            var d = GetRandom.Value<TData>();
            var o = obj.toDomain(d);
            isNotNull(o);
            isInstanceOfType(o, typeof(TDomain));
            areEqualProperties(d, o.Data);
        }
        [TestMethod] public void AddFilterTest() {
            string contains(string s) => $"x.{nameof(s)}.Contains";
            string toStrContains(string s) => $"x.{nameof(s)}.ToString().Contains";
            obj.CurrentFilter = "abc";
            var q = obj.createSql();
            var s = q.Expression.ToString();
            foreach (var p in typeof(TData).GetProperties()) {
                if (p.PropertyType == typeof(string))
                    isTrue(s.Contains(contains(p.Name)), $"Nowhere part found for the property {p.Name}");
                else
                    isTrue(s.Contains(toStrContains(p.Name)), $"Nowhere part found for the property {p.Name}");
            }
        }

        protected abstract object? getSet(Lana_jewelryDb db);
    }
}

