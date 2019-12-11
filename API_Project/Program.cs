using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using System; 

namespace API_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var riotApi = RiotApi.NewInstance("");
            var summoner = riotApi.SummonerV4.GetBySummonerName(Region.NA, "");
            Console.WriteLine($"Name: {summoner.Name} Level: {summoner.SummonerLevel} profileIconID: {summoner.ProfileIconId}");
        }
    }
}
