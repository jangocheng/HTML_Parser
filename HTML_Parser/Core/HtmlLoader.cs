using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace HTML_Parser.Core
{
    /// <summary>
    /// HtmlLoader - downloads source code of the web-page according to the IParserSettings
    /// </summary>
    class HtmlLoader
    {
        //For connection
        readonly HttpClient client;

        //Url of the page to download
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            
            //Building an url string with BaseUrl+Prefix
            url = $"{settings.BaseUrl}/{settings.Prefix}";
        }

        /// <summary>
        /// Downloads the source code of the specified by id web-page
        /// </summary>
        /// <param name="id">Id of the specific web-page of the site</param>
        /// <returns></returns>
        public async Task<string> GetSourceByPageId(int id)
        {
            //Here we edit the url by placing current id instead of the placeholder
            var currentUrl = url.Replace("{CurrentId}", id.ToString());

            //Request for the needed data (source code)
            var response = await client.GetAsync(currentUrl);

            string source = null;

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
