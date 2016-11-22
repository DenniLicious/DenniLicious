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
            string path = Server.MapPath("licensiering.xml");
            XmlSwitchCase();
        }

        public void XmlSwitchCase()
        {
            string alternativ = "";
            string rattSvar = "";
            string fragebild = "";
            string path = Server.MapPath("licensiering.xml");
            XmlTextReader xreader = new XmlTextReader(path);

            //läser igenom Xml-filen
            while (xreader.Read())
            {
                HtmlGenericControl div1 = new HtmlGenericControl("div");
                HtmlGenericControl div2 = new HtmlGenericControl("div2");
                HtmlGenericControl divHjalp = new HtmlGenericControl("divHjalp");
                CheckBox cb = new CheckBox();
                Image img = new Image();
                switch (xreader.Name)
                {
                    //visas som en rubrik när ny kategori börjar
                    case "kategori":
                        div2.InnerText = xreader.GetAttribute("typ");
                        allafragor.Controls.Add(div2);
                        break;

                    //frågan
                    case "text":
                        div1.InnerText = xreader.ReadString();
                        //fragor += xreader.ReadString();
                        allafragor.Controls.Add(div1);
                        break;

                    //hjälptext visas om det finns inlagt i XML-elementet fråga
                    case "hjalp":
                        divHjalp.InnerText = xreader.ReadString();
                        allafragor.Controls.Add(divHjalp);
                        break;

                    case "bild":
                        fragebild = xreader.GetAttribute("img");
                        img.ImageUrl = fragebild;
                        div1.InnerText = "";
                        allafragor.Controls.Add(img);
                        break;

                    case "svarsalternativ":
                        //Visar facit
                        rattSvar = xreader.GetAttribute("svar");
                        //Måste ligga under rattSvar, annars funkar inte rattSvar.                    
                        alternativ = xreader.ReadString();
                        cb.Text = alternativ;
                        allafragor.Controls.Add(cb);
                        break;

                }
            }

            
        }

        protected void btnSkickaLic_Click(object sender, EventArgs e)
        {

        }
    }
}