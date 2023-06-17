using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _kalıtımm
{
    internal class ucak:yolcu
    {
        private string marka;
        private string varıs;
        private string kalkis;

        public string Marka
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }

        public string VARIS
        {
            get { return varıs; }
            set { varıs = value.ToLower(); }
        }

        public string KALKIS
        {
            get { return kalkis; }
            set { kalkis = value.ToUpper(); }
        }
    }
}
