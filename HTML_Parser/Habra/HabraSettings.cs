using HTML_Parser.Core;


namespace HTML_Parser.Habra
{
    class HabraSettings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://habrahabr.ru/";
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
