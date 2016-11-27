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
    public partial class AKUtest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HämtaFrågor(XMLToList());
        }



        public List<Fragor> XMLToList()
        {
            List<Fragor> Test = new List<Fragor>();

            string path = Server.MapPath("aku.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList allaFragor = doc.SelectNodes("/fragor/kategori/fraga");
            //XmlNodeList allaSvar = doc.SelectNodes("/fragor/kategori/fraga/svar");

            foreach (XmlNode node in allaFragor)
            {

                Fragor Q = new Fragor();
                Q.prov = node.ParentNode.Attributes["prov"].Value;
                Q.kategori = node.ParentNode.Attributes["typ"].Value;
                Q.frageText = node["text"].InnerText;
                Q.hjalpText = node["hjalp"].InnerText;
                Q.bild = node["bild"].InnerText;
                Q.frageId = node.Attributes["id"].Value;
                Svar S = new Svar();

                S.id = node.Attributes["id"].Value;
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

        public void HämtaFrågor(List<Fragor> allaFragor) //Metod 2
        {

            foreach (Fragor Q in allaFragor)
            {
                if (Q.frageId == "1")
                {
                    div1.InnerText = Q.kategori;
                    f1.InnerText = Q.frageText;
                    h1.InnerText = Q.hjalpText;
                    Image1.ImageUrl = Q.bild;
                }

                else if (Q.frageId == "2")
                {
                    f2.InnerText = Q.frageText;
                    h2.InnerText = Q.hjalpText;
                    Image2.ImageUrl = Q.bild;
                }

                else if (Q.frageId == "3")
                {
                    f3.InnerText = Q.frageText;
                    h3.InnerText = Q.hjalpText;
                    Image3.ImageUrl = Q.bild;
                }

                else if (Q.frageId == "4")
                {
                    f4.InnerText = Q.frageText;
                    h4.InnerText = Q.hjalpText;
                    Image4.ImageUrl = Q.bild;
                }

                else if (Q.frageId == "5")
                {
                    f5.InnerText = Q.frageText;
                    h5.InnerText = Q.hjalpText;
                    Image5.ImageUrl = Q.bild;
                }

                else if (Q.frageId == "6")
                {
                    div2.InnerText = Q.kategori;
                    f6.InnerText = Q.frageText;
                    h6.InnerText = Q.hjalpText;
                    Image6.ImageUrl = Q.bild;
                }

                else if (Q.frageId == "7")
                {
                    f7.InnerText = Q.frageText;
                    h7.InnerText = Q.hjalpText;
                    Image7.ImageUrl = Q.bild;
                }

                else if (Q.frageId == "8")
                {
                    f8.InnerText = Q.frageText;
                    h8.InnerText = Q.hjalpText;
                    Image8.ImageUrl = Q.bild;
                }

                else if (Q.frageId == "9")
                {
                    div2.InnerText = Q.kategori;
                    f9.InnerText = Q.frageText;
                    h9.InnerText = Q.hjalpText;
                    Image9.ImageUrl = Q.bild;
                }

                else if (Q.frageId == "10")
                {
                    f10.InnerText = Q.frageText;
                    h10.InnerText = Q.hjalpText;
                    Image10.ImageUrl = Q.bild;
                }

                else if (Q.frageId == "11")
                {
                    div3.InnerText = Q.kategori;
                    f11.InnerText = Q.frageText;
                    h11.InnerText = Q.hjalpText;
                    Image11.ImageUrl = Q.bild;
                }

                else if (Q.frageId == "12")
                {
                    f12.InnerText = Q.frageText;
                    h12.InnerText = Q.hjalpText;
                    Image12.ImageUrl = Q.bild;
                }

                else if (Q.frageId == "13")
                {
                    f13.InnerText = Q.frageText;
                    h13.InnerText = Q.hjalpText;
                    Image13.ImageUrl = Q.bild;
                }

                else if (Q.frageId == "14")
                {
                    f14.InnerText = Q.frageText;
                    h14.InnerText = Q.hjalpText;
                    Image14.ImageUrl = Q.bild;
                }

                else if (Q.frageId == "15")
                {
                    f15.InnerText = Q.frageText;
                    h15.InnerText = Q.hjalpText;
                    Image15.ImageUrl = Q.bild;
                }



                //HtmlGenericControl div = new HtmlGenericControl("div");
                //HtmlGenericControl divHjalp = new HtmlGenericControl("divHjalp");
                //Image img = new Image();
                //CheckBox cb = new CheckBox();
                //    CheckBox cbb = new CheckBox();
                //    CheckBox cbbb = new CheckBox();
                //CheckBox cbb = new CheckBox();
                //HtmlGenericControl svarA = new HtmlGenericControl("svarA");
                //HtmlGenericControl svarB = new HtmlGenericControl("svarB");

                ////Koden som vi hade innan hårdkodning
                //div = new HtmlGenericControl("div");
                //divHjalp = new HtmlGenericControl("divHjalp");
                //img = new Image();


                //cb = new textCb();
                //cbb = new textCb();
                //cbbb = new textCb();

                //divHjalp.InnerText = Q.hjalpText;
                //div.InnerText = Q.frageText;
                //img.ImageUrl = Q.bild;
                //allafragor.Controls.Add(div);
                //allafragor.Controls.Add(divHjalp);
                //allafragor.Controls.Add(img);
                ////Slut på den

                //                div1.InnerText = "";
                //                allafragor.Controls.Add(img);

                foreach (Svar s in Q.svaren)
                {
                    if (s.id == "1")
                    {
                        CheckBox1.Text = s.svar1;
                        CheckBox2.Text = s.svar2;
                        CheckBox3.Text = s.svar3;
                    }

                    else if (s.id == "2")
                    {
                        CheckBox4.Text = s.svar1;
                        CheckBox5.Text = s.svar2;
                        CheckBox6.Text = s.svar3;
                    }

                    else if (s.id == "3")
                    {
                        CheckBox7.Text = s.svar1;
                        CheckBox8.Text = s.svar2;
                        CheckBox9.Text = s.svar3;
                    }

                    else if (s.id == "4")
                    {
                        CheckBox10.Text = s.svar1;
                        CheckBox11.Text = s.svar2;
                        CheckBox12.Text = s.svar3;
                    }

                    else if (s.id == "5")
                    {
                        CheckBox13.Text = s.svar1;
                        CheckBox14.Text = s.svar2;
                        CheckBox15.Text = s.svar3;
                    }

                    else if (s.id == "6")
                    {
                        CheckBox16.Text = s.svar1;
                        CheckBox17.Text = s.svar2;
                        CheckBox18.Text = s.svar3;
                    }

                    else if (s.id == "7")
                    {
                        CheckBox19.Text = s.svar1;
                        CheckBox20.Text = s.svar2;
                        CheckBox21.Text = s.svar3;
                    }

                    else if (s.id == "8")
                    {
                        CheckBox22.Text = s.svar1;
                        CheckBox23.Text = s.svar2;
                        CheckBox24.Text = s.svar3;
                    }

                    else if (s.id == "9")
                    {
                        CheckBox25.Text = s.svar1;
                        CheckBox26.Text = s.svar2;
                        CheckBox27.Text = s.svar3;
                    }

                    else if (s.id == "10")
                    {
                        CheckBox28.Text = s.svar1;
                        CheckBox29.Text = s.svar2;
                        CheckBox30.Text = s.svar3;
                    }

                    else if (s.id == "11")
                    {
                        CheckBox31.Text = s.svar1;
                        CheckBox32.Text = s.svar2;
                        CheckBox33.Text = s.svar3;
                    }

                    else if (s.id == "12")
                    {
                        CheckBox34.Text = s.svar1;
                        CheckBox35.Text = s.svar2;
                        CheckBox36.Text = s.svar3;
                    }

                    else if (s.id == "13")
                    {
                        CheckBox37.Text = s.svar1;
                        CheckBox38.Text = s.svar2;
                        CheckBox39.Text = s.svar3;
                    }

                    else if (s.id == "14")
                    {
                        CheckBox40.Text = s.svar1;
                        CheckBox41.Text = s.svar2;
                        CheckBox42.Text = s.svar3;
                    }

                    else if (s.id == "15")
                    {
                        CheckBox43.Text = s.svar1;
                        CheckBox44.Text = s.svar2;
                        CheckBox45.Text = s.svar3;
                    }



                    ////Gammal kod för att generera svar
                    //string cbIdTal = s.id.ToString() + ":" + "1";
                    //string cbbIdTal = s.id.ToString() + ":" + "2";
                    //string cbbbIdTal = s.id.ToString() + ":" + "3";

                    //cb.ID = cbIdTal;
                    //cbb.ID = cbbIdTal;
                    //cbbb.ID = cbbbIdTal;

                    //cb.Value = s.ratt1;
                    //cbb.Value = s.ratt2;
                    //cbbb.Value = s.ratt3;

                    //cb.text = s.svar1;
                    //cbb.text = s.svar2;
                    //cbbb.text = s.svar3;

                    //allafragor.Controls.Add(cb);
                    //allafragor.Controls.Add(cbb);
                    //allafragor.Controls.Add(cbbb);
                    ////Slut
                }
            }
        }

        protected void btnSkickaAku_Click(object sender, EventArgs e)
        {

        }

       
    }
}