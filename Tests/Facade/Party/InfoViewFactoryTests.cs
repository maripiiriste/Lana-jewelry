﻿using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade;
using Lana_jewelry.Facade.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lana_jewelry.Tests.Facade.Party
{
    [TestClass]
    public class InfoViewFactoryTests:SealedClassTests<InfoViewFactory, BaseViewFactory<InfoView, Info, InfoData>> {
    }
}
