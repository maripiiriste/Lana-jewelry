﻿using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Infra
{
    [TestClass]
    public class RepoTests: AbstractClassTests{
        private class testClass : Repo<GiftCard, GiftCardData>{
            public testClass(DbContext? c, DbSet<GiftCardData>? s) : base(c, s){}
            protected override GiftCard toDomain(GiftCardData d)=> new (d);
        }
        protected override object createObj() => new testClass(null, null);
    }
}