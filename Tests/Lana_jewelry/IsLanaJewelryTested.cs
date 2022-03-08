using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Lana_jewelry.Tests.Lana_jewelry{
    [TestClass] public class IsLanaJewelryTested : IsAssemblyTested{
        protected override void isAllTested() => isInconclusive("Namespace has to be changed to\" Lana_jewelry.Lana_jewelry\"");
        }
    }

