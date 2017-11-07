using AngleSharp.Dom.Html;

namespace HTML_Parser.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
