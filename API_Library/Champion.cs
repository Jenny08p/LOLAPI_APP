using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace API_Library
{
    public class Champion : INotifyPropertyChanged
    {
        public string championName { get; set; }

        public int masteryLevel { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
