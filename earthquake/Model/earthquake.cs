using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace earthquake.Model
{


    public class pipes
    {
        public string assetName { get; set; }
    }




    public class earthquakeRecord : INotifyPropertyChanged
    {
        string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    RaisePropertyChanged("title");
                }
            }
        }

        float _mag;
        public float Mag
        {
            get
            {
                return _mag;
            }
            set
            {
                if (_mag != value)
                {
                    _mag = value;
                    RaisePropertyChanged("mag");
                }
            }
        }
        string _coords;
        public string Coords
        {
            get
            {
                return _coords;
            }
            set
            {
                if (_coords != value)
                {
                    _coords = value;
                    RaisePropertyChanged("coods");
                }
            }
        }

        string _url;
        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
                if (_url != value)
                {
                    _url = value;
                    RaisePropertyChanged("Url");
                }
            }
        }


        string _time;
        public string time
        {
            get
            {
                return _time;
            }
            set
            {
                if (_time != value)
                {
                    _time = value;
                    RaisePropertyChanged("xtime");
                }
            }
        }

        public List<pipes>pipes { get; set; }






        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
