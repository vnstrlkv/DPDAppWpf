using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPDAppWpf.DPDCalc;
using DPDAppWpf.DPDGeo;
using DPDAppWpf.DPDOrder;

namespace DPDAppWpf.Model
{
   public abstract class Auth 
    {
        public void AuthSet(DPDAppWpf.DPDCalc.auth a, long ClientNumber, string Key)
        {
            a.clientKey = Key;
            a.clientNumber = ClientNumber;
        }

        public void AuthSet(DPDAppWpf.DPDCalc.auth a, string Key, long ClientNumber)
        {
            a.clientKey = Key;
            a.clientNumber = ClientNumber;
        }

    }
}
