using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using API_Library;
using System.IO;

namespace API_Application
{
    class ViewModel : INotifyPropertyChanged
    {
        private PlayerData mPlayerData;
        public PlayerData playerData
        {
            set
            {
                if (mPlayerData != value)
                {
                    mPlayerData = value;
                    if (mPlayerData != null)
                    {
                        matchData = new BindingList<Match>(mPlayerData.matchData);
                        championData = new BindingList<Champion>(mPlayerData.championData);
                        playerName = mPlayerData.summonerName;
                        playerLevel = mPlayerData.summonerLevel;
                    }
                    else
                    {
                        matchData = new BindingList<Match>();
                        championData = new BindingList<Champion>();
                        playerName = "";
                        playerLevel = 0;
                    }
                }
            }
        }

        public BindingList<Champion> championData { get; set; }

        public BindingList<Match> matchData { get; set; }

        public string playerName { get; set; }

        public int playerLevel { get; set; }

        public ViewModel(PlayerData playData = null)
        {
            playerData = playData;
        }

        public void SaveRiot()
        {
            if (string.IsNullOrEmpty(playerName))
            {
                throw new InvalidProgramException("Summoner Name Expected");
            }
            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(playerName))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, mPlayerData);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

