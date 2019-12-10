using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json; 

namespace API_Project
{
    class Summoner
    {
        [JsonProperty("accountId")]
        public string AccountID { get; set; }

        [JsonProperty("puuid")]
        public string PuuID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }

        [JsonProperty("summonerID")]
        public long SummonerID { get; set; }
    }
}
