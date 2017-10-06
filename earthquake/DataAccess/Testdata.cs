using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Collections.ObjectModel;
using System.Web.Script.Serialization;
using System.Net;

using earthquake.Model;


namespace earthquake.DataAccess

{

    public class eqapiReturn
    {
        ///<summary>
        ///handals api return passes results on to class
        /// </summary>
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<earthquakeRecord> results { get; set; }


    }






    class Earthquakedata

    {


        public static ObservableCollection<earthquakeRecord> GetEarthquakeFromAPI()
        {

            string url = @"http://104.236.67.246:9090/recent/?format=json";
            var json = new WebClient().DownloadString(url);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var eq_data = ser.Deserialize<eqapiReturn>(json);
            var eq_list = new ObservableCollection<earthquakeRecord>();
            foreach (var row in eq_data.results)
            {
                eq_list.Add(row);
            }






            return eq_list;

        }


        public static ObservableCollection<pipeline> GetPipelineFromAPI()
        {
            ///this also has not been implemented and is being simulated
            return new ObservableCollection<pipeline>
            {
                new pipeline {Name="Texas Express" },
                new pipeline {Name="Front Range" },
                new pipeline {Name= "Panola" },
                new pipeline {Name= "Chaparral" }
            };
        }


    }
}
