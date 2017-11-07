using HTML_Parser.Core;


namespace HTML_Parser.Habra
{

    //Settings for habrahabr.ru's parser
    class HabraSettings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://habrahabr.ru/";

        //Prefix "page{CurrentId}" - defines each page at the habrahabr.ru. Like www.habrahabr.ru/page3
        public string Prefix { get; set; } = "page{CurrentId}";

        public int StartPoint { get ; set ; }

        public int EndPoint { get ; set ; }

        public HabraSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end; 
        }

    }
}
