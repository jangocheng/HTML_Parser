using AngleSharp.Parser.Html;
using System;

namespace HTML_Parser.Core
{
    /// <summary>
    /// With help of IParser and IParserSettings parse data from web-site
    /// </summary>
    /// <typeparam name="T">Type of the data you want to parse</typeparam>
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;

        IParserSettings parserSettings;

        HtmlLoader loader;

        //Defines if ParserWorker is parses data at the moment
        bool isActive;

         #region Properties

        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public IParserSettings ParserSettings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }

        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        #endregion

        //Indicates when parser parses some new data
        public event Action<object, T> OnNewData;

        //Indicates when parser ends his work(or stop)
        public event Action<object> OnCompleted;

        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }

        //Start parsing proccess
        public void Start()
        {
            isActive = true;
            Worker();
        }

        //Stop parsing proccess
        public void Stop()
        {
            isActive = false;
        }

        //Do all of the dirty work
        private async void Worker()
        {
            for(int i = parserSettings.StartPoint; i <= parserSettings.EndPoint;i++)
            {
                if(!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                //loads the source code of the current web-page
                var source = await loader.GetSourceByPageId(i);

                //AngleSharp parser to parse source code to IHtmlDocument object
                var domParser = new HtmlParser();

                //gets IHtmlDocument object
                var document = await domParser.ParseAsync(source);
                
                //Parse needed data with help of out Parser
                var result = parser.Parse(document);

                OnNewData?.Invoke(this, result);
            }

            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}
