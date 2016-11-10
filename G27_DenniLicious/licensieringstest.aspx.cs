using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Web.UI.HtmlControls;

namespace G27_DenniLicious
{
    public partial class Licensieringstest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = Server.MapPath("fragor.xml");
            XmlSwitchCase();
        }

        public void XmlSwitchCase()
        {
            string fragor = "";
            string alternativ = "";
            string rattSvar = "";
            string path = Server.MapPath("fragor.xml");
            XmlTextReader xreader = new XmlTextReader(path);

            //läser igenom Xml-filen
            while (xreader.Read())
            {
                //HtmlGenericControl fragan = new HtmlGenericControl("div");
                //CheckBox cb1 = new CheckBox();
                switch (xreader.Name)
                {
                    case "text":
                        //fragan.InnerHtml = xreader.ReadString();
                        //fragan.Controls.Add(fragan);
                        fragor += xreader.ReadString();
                        break;

                    case "svarsalternativ":
                        //Visar facit
                        rattSvar += xreader.GetAttribute("svar");
                        //Måste ligga under rattSvar, annars funkar inte rattSvar.
                        alternativ += xreader.ReadString();                        
                        break;
                }
                allafragor.InnerHtml = fragor; //+ alternativ + rattSvar;
            alternativen.InnerHtml = alternativ;
            rattasvaret.InnerHtml = rattSvar;
            }

            
        }
    }
}