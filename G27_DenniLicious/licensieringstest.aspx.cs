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
            HämtaFrågor(XMLToList());
            
            //string path = Server.MapPath("licensiering.xml");
            //XmlSwitchCase();
        }

        protected void btnSkickaLic_Click(object sender, EventArgs e)
        {
        
        }

        public void HämtaFrågor(List<Fragor> allaFragor) //Metod 2
        {
            foreach (Fragor Q in allaFragor)
            {
                HtmlGenericControl div = new HtmlGenericControl("div");
                HtmlGenericControl divHjalp = new HtmlGenericControl("divHjalp");
                Image img = new Image();
                CheckBox cb = new CheckBox();
                    CheckBox cbb = new CheckBox();
                    CheckBox cbbb = new CheckBox();
                //CheckBox cbb = new CheckBox();
                //HtmlGenericControl svarA = new HtmlGenericControl("svarA");
                //HtmlGenericControl svarB = new HtmlGenericControl("svarB");

                divHjalp.InnerText = Q.hjalpText;
                div.InnerText = Q.frageText;
                img.ImageUrl = Q.bild;
                allafragor.Controls.Add(div);
                allafragor.Controls.Add(divHjalp);
                allafragor.Controls.Add(img);

                
                //                div1.InnerText = "";
                //                allafragor.Controls.Add(img);

                foreach (Svar s in Q.svaren)
                {
                    
                    cb.Text = s.svar1;
                    cbb.Text = s.svar2;
                    cbbb.Text = s.svar3; 
                    allafragor.Controls.Add(cb);
                    allafragor.Controls.Add(cbb);
                    allafragor.Controls.Add(cbbb);
                }

                
                
                ////svarA.InnerText = tf.svarsalternativ;
                ////svarB.InnerText = tf.svarsalternativ1;
                //cb.Text = tf.svarsalternativ1;
                //cbb.Text = tf.svarsalternativ;
                ////+ " " + tf.svarsalternativ; //skulle kunna använda .InnerHtml
                //allafragor.Controls.Add(div);
                ////allafragor.Controls.Add(svarA);
                ////allafragor.Controls.Add(svarB);
                //allafragor.Controls.Add(cb);

                //allafragor.Controls.Add(cbb);

            }
        }

       public List<Fragor> XMLToList()
        {
            List<Fragor> Test = new List<Fragor>();

            string path = Server.MapPath("licensiering.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList allaFragor = doc.SelectNodes("/fragor/kategori/fraga");
            //XmlNodeList allaSvar = doc.SelectNodes("/fragor/kategori/fraga/svar");

            foreach (XmlNode node in allaFragor)
            {
                
                Fragor Q = new Fragor();
                Q.kategori = node.ParentNode.Attributes["typ"].Value;
                Q.frageText = node["text"].InnerText;
                Q.hjalpText = node["hjalp"].InnerText;
                Q.bild = node["bild"].InnerText;
                
                Svar S = new Svar();

                S.svar1 = node["svarsalternativ1"].InnerText;
                S.ratt1 = node["svarsalternativ1"].Attributes["svar"].Value;

                S.svar2 = node["svarsalternativ2"].InnerText;
                S.ratt2 = node["svarsalternativ2"].Attributes["svar"].Value;

                S.svar3 = node["svarsalternativ3"].InnerText;
                S.ratt3 = node["svarsalternativ3"].Attributes["svar"].Value;
                Q.svaren.Add(S);
            
            // foreach(XmlNode svar in allaSvar)
            //{
                
            //    Svar S = new Svar();
            //    S.svar1 = svar["svarsalternativ1"].InnerText;
            //    S.ratt1 = svar["svarsalternativ1"].Attributes["svar"].Value;

            //    S.svar2 = svar["svarsalternativ2"].InnerText;
            //    S.ratt2 = svar["svarsalternativ2"].Attributes["svar"].Value;

            //    S.svar3 = svar["svarsalternativ3"].InnerText;
            //    S.ratt3 = svar["svarsalternativ3"].Attributes["svar"].Value;

            //    S.id = svar.ParentNode.Attributes["id"].Value;
            //    Q.svaren.Add(S);
            //}
            Test.Add(Q);
             
            }
        
         

            
            return Test;

        }
        
        //public void XmlSwitchCase()
        //{
        //    string alternativ = "";
        //    string rattSvar = "";
        //    string fragebild = "";
        //    string path = Server.MapPath("licensiering.xml");
        //    XmlTextReader xreader = new XmlTextReader(path);

        //    //läser igenom Xml-filen
        //    while (xreader.Read())
        //    {
        //        HtmlGenericControl div1 = new HtmlGenericControl("div");
        //        HtmlGenericControl div2 = new HtmlGenericControl("div2");
        //        HtmlGenericControl divHjalp = new HtmlGenericControl("divHjalp");
        //        CheckBox cb = new CheckBox();
        //        Image img = new Image();
        //        Fragor Q = new Fragor();
              
        //        switch (xreader.Name)
        //        {
        //            //visas som en rubrik när ny kategori börjar
        //            case "kategori":
        //                div2.InnerText = xreader.GetAttribute("typ");
        //                allafragor.Controls.Add(div2);
        //                break;

        //            //frågan
        //            case "text":
        //                Q.frageText = xreader.ReadString();
        //                div1.InnerText = xreader.ReadString();
                        
        //                //fragor += xreader.ReadString();
        //                allafragor.Controls.Add(div1);
        //                break;

        //            //hjälptext visas om det finns inlagt i XML-elementet fråga
        //            case "hjalp":
        //                Q.hjalpText = xreader.ReadString();
        //                divHjalp.InnerText = xreader.ReadString();
        //                allafragor.Controls.Add(divHjalp);
        //                break;

        //            case "bild":
        //                fragebild = xreader.GetAttribute("img");
        //                img.ImageUrl = fragebild;
        //                div1.InnerText = "";
        //                allafragor.Controls.Add(img);
        //                break;

        //            case "svarsalternativ":
        //                //Visar facit
        //                rattSvar = xreader.GetAttribute("svar");
        //                //Måste ligga under rattSvar, annars funkar inte rattSvar.                    
        //                alternativ = xreader.ReadString();
        //                cb.Text = alternativ;
        //                allafragor.Controls.Add(cb);
        //                break;
        //        }
            }

            
        }
