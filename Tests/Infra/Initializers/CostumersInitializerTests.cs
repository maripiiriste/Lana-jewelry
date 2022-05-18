﻿using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain;
using Lana_jewelry.Infra;
using Lana_jewelry.Infra.Initializers;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lana_jewelry.Tests.Infra.Initializers {
    [TestClass] public class CostumersInitializerTests
        :SealedBaseTests<CostumersInitializer, BaseInitializer<CostumerData>>{
        protected override CostumersInitializer createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            return new CostumersInitializer(db);
        }
    }
    [TestClass] public class CountiresInitializerTests
       : SealedBaseTests<CountriesInitializer, BaseInitializer<CountryData>> {
        protected override CountriesInitializer createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            return new CountriesInitializer(db);
        }
    }
    [TestClass] public class CurrenciesInitializerTests
       : SealedBaseTests<CurrenciesInitializer, BaseInitializer<CurrencyData>> {
        protected override CurrenciesInitializer createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            return new CurrenciesInitializer(db);
        }
    }
    [TestClass]
    public class CountryCurrenciesInitializerTests
       : SealedBaseTests<CountryCurrenciesInitializer, BaseInitializer<CountryCurrencyData>> {
        protected override CountryCurrenciesInitializer createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            return new CountryCurrenciesInitializer(db);
        }
    }
    [TestClass]
    public class GiftCardsInitializerTests
       : SealedBaseTests<GiftCardInitializer, BaseInitializer<GiftCardData>> {
        protected override GiftCardInitializer createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            return new GiftCardInitializer(db);
        }
    }
    [TestClass] public class InfosInitializerTests
       : SealedBaseTests<InfoInitializer, BaseInitializer<InfoData>> {
        protected override InfoInitializer createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            return new InfoInitializer(db);
        }
    }
    [TestClass] public class TransportsInitializerTests
       : SealedBaseTests<TransportInitializer, BaseInitializer<TransportData>> {
        protected override TransportInitializer createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            return new TransportInitializer(db);
        }
    }
    [TestClass] public class CostumerCountriesInitializerTests
       : SealedBaseTests<CostumerCountryInitializer, BaseInitializer<CostumerCountryData>> {
        protected override CostumerCountryInitializer createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            return new CostumerCountryInitializer(db);
        }
    }
    [TestClass] public class BaseInitializerTests
       : AbstractClassTests<BaseInitializer<GiftCardData>, object> {
        private class testClass : BaseInitializer<GiftCardData> {
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s) { }
            protected override IEnumerable<GiftCardData> getEntities => throw new System.NotImplementedException();
        }
        protected override BaseInitializer<GiftCardData> createObj() {
            var db = GetRepo.Instance<Lana_jewelryDb>();
            return new BaseInitializer<GiftCardData>(db);
        }
    }
    [TestClass] public class Lana_jewelryDbInitializerTests:TypeTests { }
}