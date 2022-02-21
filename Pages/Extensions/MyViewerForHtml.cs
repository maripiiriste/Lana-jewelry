using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;

namespace Lana_jewelry.Pages.Extensions
{
    public static class MyViewerForHtml
    {
        public static IHtmlContent MyViewerFor<TModel, TResult>(
          this IHtmlHelper<TModel> h, Expression<Func<TModel, TResult>> e)
        {
            var s = htmlStrings(h, e);
            return new HtmlContentBuilder(s);
        }

        private static List<object> htmlStrings<TModel, TResult>(IHtmlHelper<TModel> h, Expression<Func<TModel, TResult>> e)
        {
            var l = new List<object>();
            //l.Add(new HtmlString("<div class=\"row\">"));
            //l.Add(new HtmlString("<dd class=\"col-sm-2\">"));
            //l.Add(html.LabelFor(expression, null, new { @class = "control-label" }));
            //l.Add(new HtmlString("</dd>"));
            //l.Add(new HtmlString("<dd class=\"col-sm-10\">"));
            //l.Add(html.EditorFor(expression, new { htmlAttributes = new { @class = "fore-control" } }));
            //l.Add(html.ValidationMessageFor(expression, null, new { @class = "text-danger" }));
            //l.Add(new HtmlString("</dd>"));
            //l.Add(new HtmlString("</div>"));

        
         l.Add(new HtmlString("<dl class=\"row\">"));
        l.Add(new HtmlString("<dt class=\"col-sm-2\">"));
        l.Add(h.DisplayNameFor(e));
        l.Add(new HtmlString("</dt>"));
        l.Add(new HtmlString("<dd class=\"col-sm-10\">"));
        l.Add(h.DisplayFor(e));
        l.Add(new HtmlString("</dd>"));
        l.Add(new HtmlString("<dt class=\"col-sm-2\">"));
        l.Add(h.DisplayNameFor(e));
        l.Add(new HtmlString("</dt>"));
        l.Add(new HtmlString("<dd class=\"col-sm-10\">"));
        l.Add(h.DisplayFor(e));
        l.Add(new HtmlString("</dd>"));
        l.Add(new HtmlString("<dt class=\"col-sm-2\">"));
        l.Add(h.DisplayNameFor(e));
        l.Add(new HtmlString("</dt>"));
        l.Add(new HtmlString("<dd class=\"col-sm-10\">"));
        l.Add(h.DisplayFor(e));
        l.Add(new HtmlString("</dd>"));
        l.Add(new HtmlString("</dl>"));
          
            return l;

        } 
    }
}
