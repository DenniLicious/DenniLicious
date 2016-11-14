using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace G27_DenniLicious
{
    public class Provresultat
    {
        public string test_typ { get; set; }
        public bool godkand { get; set; }
        public string resultat_totalt { get; set;}
        public DateTime datum { get; set; }
        //public int anvandare_id { get; set; }
        public string resultat_produkter { get; set; }
        public string resultat_ekonomi { get; set; }
        public string resultat_etik { get; set; }
        //public int id { get; set; }
        public string namn { get; set; }
        public string typ { get; set; }
        public bool aku { get; set; }

        public override string ToString()
        {
            return namn;
        }
    }
}