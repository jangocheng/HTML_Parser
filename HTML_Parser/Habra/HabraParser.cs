using HTML_Parser.Core;
using AngleSharp.Dom.Html;
using System;
using System.Linq;
using System.Collections.Generic;

namespace HTML_Parser.Habra
{
    class HabraParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("post__title_link"));

            foreach(var item in items)
            {
                list.Add(item.TextContent); 
            }

            return list.ToArray();
        }
    }
}
