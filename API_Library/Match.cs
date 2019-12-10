using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace API_Library
{
    public class Match : INotifyPropertyChanged
    {
        public string matches { get; set; }

        public int totalGames { get; set; }

        public string lane { get; set; }

        public long gameID { get; set; }

        public int champion { get; set; }

        public int season { get; set; }

        public int queue { get; set; }

        public string role { get; set; }

        public long timeStamp { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
