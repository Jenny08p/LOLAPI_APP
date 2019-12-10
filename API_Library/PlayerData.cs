using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace API_Library
{
    public class PlayerData : INotifyPropertyChanged
    {
        public string summonerName { get; set; }

        public int summonerLevel { get; set; }

        public int MyProperty { get; set; }

        public List<Champion> championData = new List<Champion>();

        public List<Match> matchData = new List<Match>();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
