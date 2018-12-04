using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using DPDAppWpf.Model;
using DPDAppWpf.ViewModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;


namespace DPDAppWpf.ViewModel
{
    class DPDVM
    {
       private IEnumerable<DPDCities> cities;        
       private DPDAppWpf.DPDCalc.auth _auth;       
        private string clientKey;
        private long clientNumber;

        public IEnumerable<DPDCities> Cities { get => cities; set { cities = value; OnPropertyChanged("Cities"); } }
        public DPDCalc.auth Auth { get => _auth; set { _auth = value; OnPropertyChanged("Auth"); } }
        public string ClientKey { get => clientKey; set  { clientKey = value; OnPropertyChanged("ClientKey"); } }
        public long ClientNumber { get => clientNumber; set { clientNumber = value; OnPropertyChanged("ClientNumber"); } }

      private IEnumerable<DPDCities> GetDPDCities()
        {
            IEnumerable<DPDCities> cities = null;

            var sr = new StreamReader("GeographyDPD_20181127.csv", System.Text.Encoding.GetEncoding("Windows-1251"), false);

            //  TextReader textReader = File.OpenText("GeographyDPD_20181127.csv");
            var csv = new CsvReader(sr);
            cities = csv.GetRecords<DPDCities>();
            return cities;
        }

        private void GetAuth()
        {
            Auth.clientKey = clientKey;
            Auth.clientNumber = clientNumber;
        }



        //Command
        public RelayCommand GetAuthCommand => new RelayCommand(o =>
        {
            GetAuth();
        });

        public RelayCommand GetCitiesCommand => new RelayCommand(o =>
        {
            Cities = GetDPDCities();
        });



        //Command

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
