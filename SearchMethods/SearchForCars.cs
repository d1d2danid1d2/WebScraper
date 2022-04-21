using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraper
{
    public interface ISearchForCars
    {
        Task<List<string>> GetAllCarsFromPages(int pageCount, string url);
        Task<List<string>> GetCars(string url);
    }
    public class SearchForCars : ISearchForCars
    {
        public async Task<List<string>> GetAllCarsFromPages(int pageCount, string url)
        {
            List<string> items = new List<string>();
            if (pageCount != 0)
            {
                for (int i = 1; i <= pageCount; i++)
                {
                    var link = $"{url}?page={i}";
                    items.AddRange(await GetCars(link));
                };
            }
            else
            {
                pageCount = 1;
                for (int i = 1; i <= pageCount; i++)
                {
                    items.AddRange(await GetCars(url));
                };
            }
            return items;
        }
        public async Task<List<string>> GetCars(string url)
        {
            List<string> carLinks = new List<string>();


            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            // query
            var productHttp = htmlDocument.DocumentNode.Descendants("main").Where(node => node.GetAttributeValue("data-testid", "").Equals("search-results")).ToList();

            var productList = productHttp[0].Descendants("article").Where(node => node.GetAttributeValue("data-testid", "").Equals("listing-ad"));

            //add to array
            foreach (var item in productList)
            {
                carLinks.Add(item.Descendants("a").FirstOrDefault().GetAttributeValue("href", ""));
            }
            return carLinks;
        }
    }


}
