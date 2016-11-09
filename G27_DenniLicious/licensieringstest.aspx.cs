using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Xml;

namespace G27_DenniLicious
{
    public partial class Licensieringstest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string path = Server.MapPath("fragor.xml");
            //XmlSwitchCase();
            HämtaFrågor(XMLToList());
        }

        public void HämtaFrågor(List<Testfragor> allaFragor) //Metod 2
        {
            foreach (Testfragor tf in allaFragor)
            {
                HtmlGenericControl div = new HtmlGenericControl("div");
                CheckBox cb = new CheckBox();
                CheckBox cbb = new CheckBox();
                //HtmlGenericControl svarA = new HtmlGenericControl("svarA");
                //HtmlGenericControl svarB = new HtmlGenericControl("svarB");

                div.InnerText = tf.text;

                //svarA.InnerText = tf.svarsalternativ;
                //svarB.InnerText = tf.svarsalternativ1;
                cb.Text = tf.svarsalternativ1;
                cbb.Text = tf.svarsalternativ;
                //+ " " + tf.svarsalternativ; //skulle kunna använda .InnerHtml
                allafragor.Controls.Add(div);
                //allafragor.Controls.Add(svarA);
                //allafragor.Controls.Add(svarB);
                allafragor.Controls.Add(cb);

                allafragor.Controls.Add(cbb);

            }
        }

        public List<Testfragor> XMLToList()
        {
            List<Testfragor> Test = new List<Testfragor>();

            string path = Server.MapPath("fragor.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList allaFragor = doc.SelectNodes("/fragor/produkter/fraga");

            foreach (XmlNode node in allaFragor)
            {
                
                Testfragor tf = new Testfragor();
                tf.text = node["text"].InnerText;
                tf.svarsalternativ = node["svarsalternativ"].InnerText;
                tf.svarsalternativ1 = node["svarsalternativ1"].InnerText;
                Test.Add(tf);
            }

            
            return Test;

        }
        //public void XmlSwitchCase()
        //{
        //    string fragor = "";
        //    string path = Server.MapPath("fragor.xml");
        //    XmlTextReader xreader = new XmlTextReader(path);

        //    //läser igenom Xml-filen
        //    while (xreader.Read())
        //    {
        //        switch (xreader.Name)
        //        {
        //            case "text":
        //                fragor += xreader.ReadString();
        //                break;
        //        }
        //    }

        //    allafragor.InnerHtml = fragor;
        //}
    }
}