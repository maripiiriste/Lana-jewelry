using Lana_jewelry.Aids;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Facade;
using Lana_jewelry.Facade.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace Lana_jewelry.Tests.Facade.Shipment{
    [TestClass] public class TransportViewFactoryTests : SealedClassTests<TransportViewFactory, BaseViewFactory<TransportView, Transport, TransportData>>{
        [TestMethod] public void CreateTest() { }
        [TestMethod] public void CreateViewTest() {
            var d = GetRandom.Value<TransportData>();
            var e = new Transport(d);
            var v = new TransportViewFactory().Create(e);
            isNotNull(v);
            areEqual(v.TransportDuration, e.TransportDuration);
            areEqual(v.Id, e.Id);
            areEqual(e.Street, v.Street);
            areEqual(e.City, v.City);
            areEqual(e.ZipCode, v.ZipCode);
            areEqual(e.Country, v.CountryId);
            areEqual(v.TransportPrice, e.TransportPrice);
        }
        [TestMethod] public void CreateEntityTest() {
            var v = GetRandom.Value<TransportView>() as TransportView;
            var e = new TransportViewFactory().Create(v);
            isNotNull(e);
            isNotNull(v);
            arePropertiesEqual(e, v);
            areEqual(e.TransportDuration, v.TransportDuration);
            areEqual(e.Id, v.Id);
            areEqual(e.Street, v.Street);
            areEqual(e.City, v.City);
            areEqual(e.ZipCode, v.ZipCode);
            areEqual(e.Country, v.CountryId);
            areEqual(e.TransportPrice, v.TransportPrice);
        }
        internal protected void arePropertiesEqual(object x, object y){
            var px=x?.GetType()?.GetProperties()?? Array.Empty<PropertyInfo>();
            var hasProperties = false;
            foreach(var p in px){
                var a=p.GetValue(x,null);
                var py = y?.GetType()?.GetProperty(p.Name);
                if(py is null)continue;
                var b = py?.GetValue(y, null);
                areEqual(a, b);
                hasProperties = true;
            }
            isTrue(hasProperties, $"No properties found for {x}");
        }
    }
}
