using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPDAppWpf.DPDGeo;
using System.IO;
using CsvHelper;

namespace DPDAppWpf.Model
{
    public class DPDCities
    {
        private long id;
        private string cityID;
        private string type;
        private string cityName;
        private string regionName;
        private string countryName;

        public long ID {get => id; set => id = value; }
        public string CityID { get => cityID; set => cityID = value; }
        public string Type { get => type; set => type=value ; }
        public string CityName { get => cityName; set => cityName = value; }
        public string RegionName { get => regionName; set => regionName=value; }
        public string CountryName { get => countryName ; set => countryName=value; }




    }
    /*
    public class DPDGeography
    {
        private auth Auth;
        public void AuthSet(long ClientNumber, string Key)
        {
            Auth.clientKey = Key;
            Auth.clientNumber = ClientNumber;
        }

        public void AuthSet(string Key, long ClientNumber)
        {
            Auth.clientKey = Key;
            Auth.clientNumber = ClientNumber;
        }

        public dpdCitiesCashPayRequest GeoRequest;

        public void SetGeoRequest(string CountryCode)
        {
            GeoRequest.auth = Auth;
            GeoRequest.countryCode = CountryCode;
        }

      } 
      
     */
}
