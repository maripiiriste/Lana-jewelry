﻿using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lana_jewelry.Pages.Extensions {
    public static class ItemButtonsHtml {
        public static IHtmlContent ItemButtons<TModel>(
        this IHtmlHelper<TModel> h, string id) {
            var s = htmlStrings(h,id);
            return new HtmlContentBuilder(s);
        }
        private static List<object> htmlStrings<TModel>(IHtmlHelper<TModel> h,string id) {
            var l = new List<object> {
                h.MyBtn("Edit", id),
                new HtmlString("&nbsp;"),
                h.MyBtn("Details", id),
                new HtmlString("&nbsp;"),
                h.MyBtn("Delete", id)
            };
            return l;
        }
    }
}

