using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace FlightTrackerClassLib
{
    public class RESTAPIHandlerer
    {
        //Function that returns a variable of type string that contains all of the REST API data(json).
        public string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
        //Function that resurns a list of variables(JToken's) that contain singular flights and all their data/info.
        public List<JToken> GetAllFlightsFromAPI() 
        {
            string url = "https://opensky-network.org/api/states/all";
            string json = CallRestMethod(url);
            JObject jsonObject = JObject.Parse(json);
            var flights = jsonObject["states"].ToList();
            return flights;
        } 
    }
}
