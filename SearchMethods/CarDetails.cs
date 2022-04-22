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

        private async Task<HtmlDocument> UrlSearchResult(string url)
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
        private void SearchResultDetails(List<string> carDetailList, List<HtmlNode> productHttp)
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

        public async Task<string> GetScore(string url)
        {
            string score = "";
            HtmlDocument htmlDocument = await UrlSearchResult(url);

            //product price
            var productPrice = htmlDocument.DocumentNode.Descendants("span")
                .Where(node => node.GetAttributeValue("class", "").Equals("offer-price__number")).ToList();
            string splitPrice = productPrice[0].InnerText.ToString().Trim();
            var price = splitPrice.Remove(splitPrice.Length - 3, 3).Replace(" ", "");

            //manufactured date
            var productFabricationDate = htmlDocument.DocumentNode.Descendants("span")
                .Where(node => node.GetAttributeValue("class", "").Equals("offer-main-params__item")).ToList();
            var fabricationDate = productFabricationDate[0].InnerText.Trim();

            // Km made
            var productKM = htmlDocument.DocumentNode.Descendants("span")
                .Where(node => node.GetAttributeValue("class", "").Equals("offer-main-params__item")).ToList();
            string splitKm = productKM[1].InnerText.ToString().Trim();
            var km = splitKm.Remove(splitKm.Length - 2, 2).Replace(" ", "");

            double calculator = (0.4 * int.Parse(km) + 0.4 * int.Parse(price) + 0.2 * int.Parse(fabricationDate)) / 1000;
            score = string.Format("{0:0.0}", calculator);
            return score;
        }
    }
}
