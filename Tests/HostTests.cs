﻿using Lana_jewelry.Aids;
using Lana_jewelry.Data;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Infra.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Lana_jewelry.Tests {
    public abstract class HostTests : TestAsserts {
        internal static readonly TestHost<Program> host;
        internal static readonly HttpClient client;
        [TestInitialize] public virtual void testInitialize() {
            (GetRepo.Instance<ICountriesRepo>() as CountriesRepo)?.clear();
            (GetRepo.Instance<ICurrenciesRepo>() as CurrenciesRepo)?.clear();
            (GetRepo.Instance<ICountryCurrenciesRepo>() as CountryCurrenciesRepo)?.clear();
        }
        static HostTests() {
            host = new TestHost<Program>();
            client = host.CreateClient();
        }
        protected virtual object? isReadOnly<T>(string? callingMethod = null) => null;

            protected void itemTest<TRepo, TObj, TData>(string id, Func<TData, TObj> toObj, Func<TObj?> getObj)
            where TRepo : class, IRepo<TObj>
            where TObj : UniqueEntity {

                var c = isReadOnly<TObj>(nameof(itemTest));
                isNotNull(c);
                isInstanceOfType(c, typeof(TObj));

                var r = GetRepo.Instance<TRepo>();
                var d = GetRandom.Value<TData>();
                d.Id = id;

                var cnt = GetRandom.Int32(0, 30);
                var idx = GetRandom.Int32(0, cnt);
                for (var i = 0; i < cnt; i++) {
                    var x = (i == idx) ? d : GetRandom.Value<TData>();
                    isNotNull(x);
                    r?.Add(toObj(x));
                }
                r.PageSize = 30;
                areEqual(cnt, r.Get().Count);
                areEqualProperties(d, getObj());
        }

        protected void itemsTest<TRepo, TObj, TData>(Action<TData> setId, Func<TData, TObj> toObj, Func<List<TObj>> getList)  
            where TRepo : class, IRepo<TObj> where TObj : UniqueEntity<TData> where TData : UniqueData, new() {

            var o = isReadOnly<List<TObj>>(nameof(itemsTest));

            isNotNull(o);
            isInstanceOfType(o, typeof(List<TObj>));

            var r = GetRepo.Instance<TRepo>();
            isNotNull(r);

            var list = new List<CountryCurrencyData>();
            var cnt = GetRandom.Int32(0, 30);
            for (var i = 0; i < cnt; i++) {
                var x = GetRandom.Value<TData>();
                if (GetRandom.Bool()) {
                    setId(x);
                    list.Add(x);
                }
                r.Add(toObj(x));
            }
            r.PageSize = 30;
            areEqual(cnt, r.Get().Count);

            var l = getList();
            areEqual(list.Count, l.Count);
            foreach (var d in list) {
                var y = l.Find(z => z.Id == d.Id);
                isNotNull(y);
                areEqualProperties(d, y);
            }
        }
    } 
}
