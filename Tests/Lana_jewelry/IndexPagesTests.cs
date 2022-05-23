using Lana_jewelry.Aids;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace Lana_jewelry.Tests.Lana_jewelry {
    [TestClass] public class IndexPagesTests:HostTests {
        [TestMethod] public async void GetCountriesIndexPageTest() {
            int cnt;
            var d = addRandomItems<ICountriesRepo, Country, CountryData>(out cnt, x => new Country(x));
            var page = await client.GetAsync("/Countries?handler=Index");
            areEqual(HttpStatusCode.OK, page.StatusCode);
            var html = await page.Content.ReadAsStringAsync();
            isTrue(html.Contains("<h1>Index</h1>"));
            isTrue(html.Contains("<h4>Countries</h4>"));
        }
        [TestMethod] public async void GetCurrenciesIndexPageTest() {
            int cnt;
            var d = addRandomItems<ICurrenciesRepo, Currency, CurrencyData>(out cnt, x => new Currency(x));
            var page = await client.GetAsync("/Currencies?handler=Index");
            areEqual(HttpStatusCode.OK, page.StatusCode);
            var html = await page.Content.ReadAsStringAsync();
            isTrue(html.Contains("<h1>Index</h1>"));
            isTrue(html.Contains("<h4>Currencies</h4>"));
        }
        [TestMethod] public async void GetCostumersIndexPageTest() {
            var page = await client.GetAsync("/Costumers?handler=Index");
            areEqual(HttpStatusCode.OK, page.StatusCode);
            var html = await page.Content.ReadAsStringAsync();
            isTrue(html.Contains("<h1>Log in</h1>"));
        }
        [TestMethod]
        public async void GetTransportsIndexPageTest()
        {
            var page = await client.GetAsync("/Transports?handler=Index");
            areEqual(HttpStatusCode.OK, page.StatusCode);
            var html = await page.Content.ReadAsStringAsync();
            isTrue(html.Contains("<h1>Index</h1>"));
            isTrue(html.Contains("<h1>Transports</h1>"));
        }
        [TestMethod]
        public async void GetGiftCardsIndexPageTest()
        {
            var page = await client.GetAsync("/GiftCards?handler=Index");
            areEqual(HttpStatusCode.OK, page.StatusCode);
            var html = await page.Content.ReadAsStringAsync();
            isTrue(html.Contains("<h1>Index</h1>"));
            isTrue(html.Contains("<h1>GiftCards</h1>"));
        }
        [TestMethod] public async void GetCountriesDetailedPageTest() {
            int cnt;
            var id = GetRandom.String();
            var d = addRandomItems<ICountriesRepo, Country, CountryData>(out cnt, x => new Country(x), id);
            isNotNull(d);
            isNotNull(d.Name);
            isNotNull(d.Description);
            var page = await client.GetAsync($"/Countries/Details?handler=Details&id={id}&order=&idx=0filter=");
            areEqual(HttpStatusCode.OK, page.StatusCode);
            var html = await page.Content.ReadAsStringAsync();
            isTrue(html.Contains("<h1>Details</h1>"));
            isTrue(html.Contains(id));
            isTrue(html.Contains(d.Code));
            isTrue(html.Contains(d.Name));
            isTrue(html.Contains(d.Description));
        }
    }
}
