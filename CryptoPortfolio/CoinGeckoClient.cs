using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;
using System.Configuration;
using RestSharp;


namespace CryptoPortfolio
{
    public class Coin
    {
        public string id { get; set; }
        public string name { get; set; }
        public double current_price { get; set; }

        public string image { get; set; }

    }

    public class priceOnly
    {
        public string Id { get; set; }
        public decimal Price { get; set; }

    }
    public class CoinGeckoClient
    {
        public string _apiKey { get; set; }


        public Boolean Authenticate()
        {

            Debug.WriteLine("Authenticating api key: " + _apiKey);

            var client = new RestClient("https://api.coingecko.com/api/v3/ping");
            var request = new RestRequest();

            Debug.WriteLine($"#{_apiKey}#");
            request.AddHeader("x-cg-api-key", _apiKey);
            request.AddHeader("Host", "api.coingecko.com");


            request.AddParameter("method", "GET");
            var response = client.Execute(request);


            Debug.WriteLine(response.Content);


            JsonNode jsonObject = JsonSerializer.Deserialize<JsonNode>(response.Content);


            try
            {
                string temp = (string)jsonObject["gecko_says"];
                Debug.WriteLine(temp);
                if (temp == "(V3) To the Moon!")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Api key is invalid.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                if (response.Content.ToString().Contains("API Key Missing")){
                    MessageBox.Show("Api key is invalid.");

                    return false;
                }
                else
                {
                    MessageBox.Show("Unknown error occured!\n" + response.Content);
                }
                
            }



            return false;

        }

        public List<Coin> getTopCoins(string coinName = null)
        {

            Debug.WriteLine("Getting coins data");

            var client = new RestClient("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc");
            var request = new RestRequest();


            request.AddHeader("x-cg-api-key", _apiKey);
            request.AddParameter("method", "GET");
            var response = client.Execute(request);

            List<Coin> coins = JsonSerializer.Deserialize<List<Coin>>(response.Content);

            Debug.WriteLine(response.Content);

            //foreach (Coin coin in coins)
            //{
            //    Debug.WriteLine($"Name: {coin.name}, Price {coin.current_price}");
            //}

            int coinsAmount = int.Parse(ConfigurationManager.AppSettings["coinsAmount"]);


            List<Coin> newList = coins.Take(coinsAmount).ToList();

            return newList ;
        }

        public Dictionary<string, Dictionary<string, decimal>> getPrices(List<string> ids)
        {

            Debug.WriteLine("Getting coins prices");

            var client = new RestClient("https://api.coingecko.com/api/v3/simple/price");
            var request = new RestRequest();


            request.AddHeader("x-cg-api-key", _apiKey);
            request.AddParameter("method", "GET");

            request.AddParameter("ids", string.Join(",", ids));
            request.AddParameter("vs_currencies", "usd");

            var response = client.Execute(request);

            Debug.WriteLine(response.Content);

            Dictionary<string, Dictionary<string, decimal>> pricesDict = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, decimal>>>(response.Content);



            List<priceOnly> coins = new List<priceOnly>();
            foreach (var kvp in pricesDict)
            {
                coins.Add(new priceOnly { Id = kvp.Key, Price = kvp.Value["usd"] });
            }



            return pricesDict;
        }



    }
}
