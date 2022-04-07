﻿using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lana_jewelry.Pages.Extensions {
    public static class MyBtnHtml { 
        public static IHtmlContent MyBtn<TModel>(
        this IHtmlHelper<TModel> h, string handler, string id) {
            var s = htmlStrings(handler,id, h.ViewData.Model as IPageModel);
            return new HtmlContentBuilder(s);
        }
        private static List<object> htmlStrings(string handler, string id,IPageModel? m) {
            var l = new List<object>();
            l.Add(new HtmlString($"<a style=\"text-decoration: none;\" href\"/ href=\"/{pageName(m)}/{handler}?"));
            l.Add(new HtmlString($"handler={handler}&amp;"));
            l.Add(new HtmlString($"id={id}&amp;"));
            l.Add(new HtmlString($"order={m?.CurrentOrder}&amp;"));
            l.Add(new HtmlString($"idx={m?.PageIndex ?? 0}&amp;"));
            l.Add(new HtmlString($"filter={m?.CurrentFilter}\">"));
            l.Add(new HtmlString($"{handler}</a>"));
            return l;
        }
        private static string? pageName(IPageModel? m) => m?.GetType()?.Name?.Replace("Page", "");
    }
}

