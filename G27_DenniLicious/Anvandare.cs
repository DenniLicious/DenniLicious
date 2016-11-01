using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace G27_DenniLicious
{
    public class Anvandare
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public string Typ { get; set; }

        public override string ToString()
        {
            return Namn + " " + Typ;
        }
    }
}