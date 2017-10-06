using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.ObjectModel;
using earthquake.Model;
using earthquake.Helpers;
using earthquake.DataAccess;

namespace earthquake.ViewModel

{ 
    class ViewModelMain : ViewModelBase
{



       public ObservableCollection<pipeline> Pipelines { get; set; }
       public ObservableCollection<earthquakeRecord> EarthquakeRecords { get; set; } 

        public earthquakeRecord SelectedEarthQuake { get; set; }

        object _SelectedEarthquake;
        public object SelectedEarthquake
        {
            get
            {
                return _SelectedEarthquake;
            }
            set
            {
                if (_SelectedEarthquake != value)
                {
                    _SelectedEarthquake = value;
                    RaisePropertyChanged("SelectedEarthquake");
                }
            }
        }
        string _selectedMag;
        public string SelectedMag
        {
            get
            {
                return _selectedMag;
            }
            set
            {
                if (SelectedMag != value)
                {
                    _selectedMag = value;
                    RaisePropertyChanged("SelectedMag");
                }
            }
        }


        public ViewModelMain()
        {
            EarthquakeRecords = Earthquakedata.GetEarthquakeFromAPI();


            Pipelines = Earthquakedata.GetPipelineFromAPI();
        }
        }

        ///Have not impemented ways to add or edit records




    }


