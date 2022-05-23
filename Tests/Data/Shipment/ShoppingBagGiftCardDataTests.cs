using Lana_jewelry.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lana_jewelry.Tests.Data.Shipment
{
    [TestClass]public class ShoppingBagGiftCardDataTests : SealedClassTests<ShoppingBagGiftCardData, UniqueData>
    {
        [TestMethod] public void GiftCardIdTest() => isProperty<string>();
        [TestMethod] public void ShoppingBagIdTest() => isProperty<string>();
    }
}
