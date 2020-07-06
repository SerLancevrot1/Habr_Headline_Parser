using AngleSharp.Browser;
using AngleSharp.Html;
using AngleSharp.Html.Dom;
using Habr_Headline_Parser.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habr_Headline_Parser.Habr
{
    class HabrParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();

            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null &&
            item.ClassName.Contains("post__title_link"));

            foreach(var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
