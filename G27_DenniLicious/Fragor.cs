using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace G27_DenniLicious
{
    public class Fragor
    {
        public List<Svar> svaren { get; set; }
        public Fragor()
        {
            svaren = new List<Svar>();
        }
        public string frageText { get; set; }
        public string hjalpText { get; set; }
        public string kategori {get; set;}
        public string frageId {get; set;}
        public string bild { get; set; }
        

        public string alt1 {get; set;}
        public string alt2 {get; set;}
        public string alt3 {get; set;}

        public string svar1 { get; set; }
        public string svar2 { get; set; }
        public string svar3 { get; set; }
        public int svarade { get; set; }
        public int treSvar { get; set; }
    }
}