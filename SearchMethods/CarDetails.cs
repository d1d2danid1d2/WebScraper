using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraper
{
    public class CarDetails
    {

        public async Task<List<string>> GetInfoAboutCar(string url)
        {
            List<string> carDetailList = new List<string>();

            HtmlDocument htmlDocument = await UrlSearchResult(url);

            // query
            var productHttp = htmlDocument.DocumentNode.Descendants("ul").Where(node => node.GetAttributeValue("class", "").Equals("offer-params__list")).ToList();
            SearchResultDetails(carDetailList, productHttp);

            //add to array

            return carDetailList;
        }

        private static async Task<HtmlDocument> UrlSearchResult(string url)
        {
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            return htmlDocument;
        }

        public async Task<string> GetCarNameAsync(string url)
        {
            HtmlDocument htmlDocument = await UrlSearchResult(url);
            var productHttp = htmlDocument.DocumentNode.Descendants("span").Where(node => node.GetAttributeValue("class", "").Equals("offer-title big-text fake-title")).ToList();
            var name = productHttp[0].InnerText.Trim();
            return name;
            
        }
        private static void SearchResultDetails(List<string> carDetailList, List<HtmlNode> productHttp)
        {
            for (int i = 0; i < productHttp.Count; i++)
            {
                List<string> carDetails = new List<string>();
                List<string> carDetailsValue = new List<string>();
                var productStart = productHttp[i].Descendants("span").Where(node => node.GetAttributeValue("class", "").Equals("offer-params__label"));
                var productEnd = productHttp[i].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("offer-params__value"));
                foreach (var item in productStart)
                {

                    carDetails.Add(item.InnerText);
                }
                foreach (var item in productEnd)
                {

                    carDetailsValue.Add(item.InnerText.Trim());
                }
                for (int j = 0; j < productEnd.Count(); j++)
                {
                    carDetails[j] = carDetails[j] + ": " + carDetailsValue[j];

                }
                carDetailList.AddRange(carDetails);
            }
        }
        
    }
}
