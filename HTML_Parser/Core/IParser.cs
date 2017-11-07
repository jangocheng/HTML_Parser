using AngleSharp.Dom.Html;

namespace HTML_Parser.Core
{
    /// <summary>
    /// Defines behavior of the parser using AngleSharp IHtmlDocument
    /// </summary>
    /// <typeparam name="T">Data to parse</typeparam>
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
