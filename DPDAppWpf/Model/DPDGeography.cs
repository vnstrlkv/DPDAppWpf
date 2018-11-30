using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPDAppWpf.DPDGeo;


namespace DPDAppWpf.Model
{
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
}
