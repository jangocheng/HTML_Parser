using HTML_Parser.Core;
using AngleSharp.Dom.Html;
using System;
using System.Linq;
using System.Collections.Generic;

namespace HTML_Parser.Habra
{
    /// <summary>
    /// A specific parser for the habrahabr.ru article header's
    /// </summary>
    class HabraParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            //storage for parsed data
            var list = new List<string>();
            
            //post__title_link - css class that defines every header at the site
            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("post__title_link"));

            //just adding here some parsed data from AngleSharp's document
            foreach(var item in items)
            {
                list.Add(item.TextContent); 
            }

            return list.ToArray();
        }
    }
}
