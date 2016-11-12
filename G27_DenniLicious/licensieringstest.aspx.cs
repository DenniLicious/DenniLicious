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
            string fragebild = "";
            string path = Server.MapPath("fragor.xml");
            XmlTextReader xreader = new XmlTextReader(path);

            //läser igenom Xml-filen
            while (xreader.Read())
            {
                HtmlGenericControl div1 = new HtmlGenericControl("div");
                HtmlGenericControl div2 = new HtmlGenericControl("div");
                CheckBox cb = new CheckBox();
                Image img = new Image();
                //CheckBox cb1 = new CheckBox();
                switch (xreader.Name)
                {
                    case "text":
                        
                        //fragan.InnerHtml = xreader.ReadString();
                        //fragan.Controls.Add(fragan);
                        div1.InnerText = xreader.ReadString();
                        //fragor += xreader.ReadString();
                        allafragor.Controls.Add(div1);
                        break;

                    case "bild":

                        fragebild = xreader.GetAttribute("img");
                        img.ImageUrl = fragebild;
                        allafragor.Controls.Add(img);
                        break;

                    case "svarsalternativ":
                        //Visar facit
                        rattSvar = xreader.GetAttribute("svar");
                        //div2.InnerText = rattSvar;
                        //allafragor.Controls.Add(div2);
                        //Måste ligga under rattSvar, annars funkar inte rattSvar.
                       
                        alternativ = xreader.ReadString();
                        cb.Text = alternativ;
                        allafragor.Controls.Add(cb);

                        break;

                }
                //allafragor.InnerHtml = fragor; //+ alternativ + rattSvar;
            //alternativen.InnerHtml = alternativ;
            //rattasvaret.InnerHtml = rattSvar;
            }

            
        }
    }
}