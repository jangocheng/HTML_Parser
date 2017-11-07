using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML_Parser.Core
{
    /// <summary>
    /// Setting of the parser
    /// </summary>

    interface IParserSettings
    {
        //An url of the web-site we want to parse
        string BaseUrl { get; set; }

        //Prefix that adds to the url to define a specific page at the site
        string Prefix { get; set; }

        //First page of the span of pages we want to parse
        int StartPoint { get; set; }

        //Last page of the span of pages we want to parse
        int EndPoint { get; set; }
    }
}
