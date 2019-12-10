using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using System.ComponentModel;

namespace API_Project
{
    class SummonerV4 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public BindingList<Summoner> summoner { get; set; }

        // public static readonly string ApiKey = "RGAPI-1b668a58-5d25-41cf-a9d6-a57cbf78d310";
        public static readonly Uri ApiBaseAddress = new Uri("https://na1.api.riotgames.com/lol/summoner/v4/summoners");
        public HttpClient Client { get; set; }

        public SummonerV4()
        {
            Client = new HttpClient
            {
                BaseAddress = ApiBaseAddress
            };
        }

        public Summoner GetSummonerByName(string summonerName)
        {
            var uriBuilder = new UriBuilder($"{ApiBaseAddress}/by-name/{summonerName}");
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            // query["api_key"] = ApiKey;
            uriBuilder.Query = query.ToString();
            string requestUri = uriBuilder.ToString();

            var response = Client.GetAsync(requestUri).Result;
            if (response.IsSuccessStatusCode == false)
            {
                throw new Exception($"Request failed. Response: {response.StatusCode}");
            }

            string jsonResponse = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Summoner>(jsonResponse);
        }
    }
}
