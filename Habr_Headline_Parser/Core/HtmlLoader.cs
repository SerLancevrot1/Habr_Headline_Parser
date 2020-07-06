using AngleSharp.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Habr_Headline_Parser.Core
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseURL}/{settings.Prefix}/";
        }

        public async Task<string> GetSourseByPageId(int id)
        {
            var currentUrl = url.Replace("{CurrentId}", id.ToString());

            var response = await client.GetAsync(currentUrl);

            string sourse = null;

            if(response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
            {

            }
            return sourse;
        }
    }
}
