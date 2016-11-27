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
        int poängräkning;
        double poängProdukter, poängEkonomi, poängEtik;
        double antalTotal, antalProdukt, antalEkonomi, antalEtik;
        string godkantProv = "Godkänd";
        string test_typ;
        Db Databas = new Db();
        int ID;

        protected void Page_Load(object sender, EventArgs e)
        {
            ID = (int)Session["anvandarId"];
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
                int tal1 = -2;
                int tal2 = -1;
                int tal3 = 0;
                string dagensDatum = DateTime.Today.ToShortDateString();
                DateTime dD = Convert.ToDateTime(dagensDatum);

                foreach (Fragor Q in XMLToList())
                {
                    test_typ = Q.prov;
                    antalTotal++;
                    tal1 = tal1+3;
                    tal2 = tal2+3;
                    tal3 = tal3+3;
                    int antalrätta = 0;

                    int forstaRatta = 0;
                    int tredjeRatta = 0;
foreach (Svar s in Q.svaren)
                            {
                                if (Q.kategori == "Produkter och hantering av kundens affärer")
                                {
                                    antalProdukt++;
                                }

                                else if (Q.kategori == "Ekonomi - nationalekonomi, finansiell ekonomi och privatekonomi")
                                {
                                    antalEkonomi++;
                                }

                                else if (Q.kategori == "Etik och regelverk")
                                {
                                    antalEtik++;
                                }                

                    foreach (Control c in allafragor.Controls)
                    {
                        
                        if ((c is CheckBox))
                        {
                            
                            
                                int i = 0;
                                if (s.ratt1 == "true")
                                {
                                    i++;
                                }

                                if (s.ratt2 == "true")
                                {
                                    i++;
                                }

                                if (s.ratt3 == "true")
                                {
                                    i++;
                                }

                                //string cbIdTal = s.id.ToString() + ":" + "1";
                                //string cbbIdTal = s.id.ToString() + ":" + "2";
                                //string cbbbIdTal = s.id.ToString() + ":" + "3";
                                string cbIdTal = "CheckBox" + tal1.ToString();
                                
                                string cbbIdTal = "CheckBox" + tal2.ToString();
                                
                                string cbbbIdTal = "CheckBox" + tal3.ToString();
                                
                                //Är det ett rätt svarsalternativ
                                if (i == 1)
                                {
                                  
                                            //Om det är den första checkboxen i frågan den kollar
                                            if (cbIdTal == ((CheckBox)c).ID)
                                            {
                                                //Den här har jag flyttat upp - AV
                                                if (((CheckBox)c).Checked)
                                                {
                                                    Q.svarade++;
                                                    Q.treSvar++;
                                                        //AV
                                                        //forstaRatta++;
                                                    //Om den cb är ikryssad och det är rätt svarsalternativ
                                                    if (s.ratt1 == "true")
                                                    {
                                                        forstaRatta++;
                                                        poängräkning++;

                                                        if(Q.kategori == "Produkter och hantering av kundens affärer")
                                                        {
                                                            poängProdukter++;
                                                        }

                                                        else if (Q.kategori == "Ekonomi - nationalekonomi, finansiell ekonomi och privatekonomi")
                                                        {
                                                            poängEkonomi++;
                                                        }

                                                        else if (Q.kategori == "Etik och regelverk")
                                                        {
                                                            poängEtik++;
                                                        }
                                                    }
                                                }
                                            }
                                            //Om det är den andra checkboxen i frågan den kollar
                                            else if (cbbIdTal == ((CheckBox)c).ID)
                                            {
                                                //Den här har jag flyttat upp - AV
                                                if (((CheckBox)c).Checked)
                                                {
                                                    Q.svarade++;
                                                    Q.treSvar++;
                                                    //Om den cb är ikryssad och det är rätt svarsalternativ
                                                    if (s.ratt2 == "true")
                                                    {
                                                        forstaRatta++;
                                                        poängräkning++;

                                                        if (Q.kategori == "Produkter och hantering av kundens affärer")
                                                        {
                                                            poängProdukter++;
                                                        }

                                                        else if (Q.kategori == "Ekonomi - nationalekonomi, finansiell ekonomi och privatekonomi")
                                                        {
                                                            poängEkonomi++;
                                                        }

                                                        else if (Q.kategori == "Etik och regelverk")
                                                        {
                                                            poängEtik++;
                                                        }
                                                    }
                                                }
                                            }
                                            //Om det är den tredje checkboxen i frågan den kollar
                                            else if (cbbbIdTal == ((CheckBox)c).ID)
                                            {
                                                //Den här har jag flyttat upp - AV
                                                if (((CheckBox)c).Checked)
                                                {
                                                    Q.svarade++;
                                                    Q.treSvar++;
                                                    //Om den cb är ikryssad och det är rätt svarsalternativ
                                                    if (s.ratt3 == "true")
                                                    {
                                                        forstaRatta++;
                                                        tredjeRatta++;
                                                        poängräkning++;

                                                        if (Q.kategori == "Produkter och hantering av kundens affärer")
                                                        {
                                                            poängProdukter++;
                                                        }

                                                        else if (Q.kategori == "Ekonomi - nationalekonomi, finansiell ekonomi och privatekonomi")
                                                        {
                                                            poängEkonomi++;
                                                        }

                                                        else if (Q.kategori == "Etik och regelverk")
                                                        {
                                                            poängEtik++;
                                                        }
                                                    }
                                                }
                                               
                                            }
                                     if(Q.svarade > i && forstaRatta == 1)
                                     {
                                         poängräkning--;
                                         Q.svarade = 0;

                                         if (Q.kategori == "Produkter och hantering av kundens affärer")
                                         {
                                             poängProdukter--;
                                         }

                                         else if (Q.kategori == "Ekonomi - nationalekonomi, finansiell ekonomi och privatekonomi")
                                         {
                                             poängEkonomi--;
                                         }

                                         else if (Q.kategori == "Etik och regelverk")
                                         {
                                             poängEtik--;
                                         }
                                     }

                                     else if(Q.treSvar == 3 && tredjeRatta ==1)
                                     {
                                         poängräkning--;

                                         if (Q.kategori == "Produkter och hantering av kundens affärer")
                                         {
                                             poängProdukter--;
                                         }

                                         else if (Q.kategori == "Ekonomi - nationalekonomi, finansiell ekonomi och privatekonomi")
                                         {
                                             poängEkonomi--;
                                         }

                                         else if (Q.kategori == "Etik och regelverk")
                                         {
                                             poängEtik--;
                                         }

                                     }
                                            //if (Q.svar1 == "Checked")
                                            //{
                                            //    forstaRatta++;
                                            //}

                                            //if (Q.svar2 == "Checked")
                                            //{
                                            //    forstaRatta++;
                                            //}

                                            //if (Q.svar3 == "Checked")
                                            //{
                                            //    forstaRatta++;
                                            //}
                                        }
                                    //    //AV
                                    //if(antalValda > 1 && forstaRatta == 1)
                                    //{
                                    //    poängräkning--;
                                    //    antalValda = 0;
                                    //}
                                  
                                
                                    //Om två svarsalternativ är rätt
                                    else if (i == 2)
                                    {
                                        

                                        //Om det är den första checkboxen i frågan den kollar
                                        if (cbIdTal == ((CheckBox)c).ID)
                                        {
                                            if (((CheckBox)c).Checked)
                                            {
                                                Q.treSvar++;
                                        //Om den cb är ikryssad och det är rätt svarsalternativ
                                        if (s.ratt1 == "true")
                                        {
                                            antalrätta++;
                                            
                                        }
                                            }
                                        }
                                    
                                        //Om det är den andra checkboxen i frågan den kollar
                                    if(cbbIdTal == ((CheckBox)c).ID)
                                    {
                                        if (((CheckBox)c).Checked)
                                        {
                                            Q.treSvar++;
                                            //Om den cb är ikryssad och det är rätt svarsalternativ
                                            if (s.ratt2 == "true")
                                            {
                                                antalrätta++;
                                                if (antalrätta == 2)
                                                {
                                                    poängräkning++;

                                                    if (Q.kategori == "Produkter och hantering av kundens affärer")
                                                    {
                                                        poängProdukter++;
                                                    }

                                                    else if (Q.kategori == "Ekonomi - nationalekonomi, finansiell ekonomi och privatekonomi")
                                                    {
                                                        poängEkonomi++;
                                                    }

                                                    else if (Q.kategori == "Etik och regelverk")
                                                    {
                                                        poängEtik++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                        //Om det är den tredje checkboxen i frågan den kollar
                                    if(cbbbIdTal == ((CheckBox)c).ID)
                                    {
                                        if (((CheckBox)c).Checked)
                                        {
                                            Q.treSvar++;
                                            //Om den cb är ikryssad och det är rätt svarsalternativ
                                            if (s.ratt3 == "true")
                                            {
                                                antalrätta++;
                                                if (antalrätta == 2)
                                                {
                                                    poängräkning++;

                                                    if (Q.kategori == "Produkter och hantering av kundens affärer")
                                                    {
                                                        poängProdukter++;
                                                    }

                                                    else if (Q.kategori == "Ekonomi - nationalekonomi, finansiell ekonomi och privatekonomi")
                                                    {
                                                        poängEkonomi++;
                                                    }

                                                    else if (Q.kategori == "Etik och regelverk")
                                                    {
                                                        poängEtik++;
                                                    }
                                                }
                                            }
                                        }
                                        
                                    }
                                    
                                        if(Q.treSvar == 3)
                                        {
                                            poängräkning--;

                                            if (Q.kategori == "Produkter och hantering av kundens affärer")
                                            {
                                                poängProdukter--;
                                            }

                                            else if (Q.kategori == "Ekonomi - nationalekonomi, finansiell ekonomi och privatekonomi")
                                            {
                                                poängEkonomi--;
                                            }

                                            else if (Q.kategori == "Etik och regelverk")
                                            {
                                                poängEtik--;
                                            }
                                        }
                                        
                                    }

                                ((CheckBox)c).Enabled = false;
                                    //  if (cbbIdTal == ((CheckBox)c).ID)
                                    //{
                                    //    if (((CheckBox)c).Checked && s.ratt1 == "true")
                                    //    {
                                    //        poängräkning++;
                                    //    }
                                    //}

                                    //else if (cbbbIdTal == ((CheckBox)c).ID)
                                    //{
                                    //    if (((CheckBox)c).Checked && s.ratt3 == "true")
                                    //    {
                                    //        poängräkning++;
                                    //    }
                                    //}
                                   }
                            
                            }
                        }
                    }

                double procentResultat = (poängräkning / antalTotal) * 100;
                double procentProdukt = (poängProdukter / antalProdukt) * 100;
                double procentEkonomi = (poängEkonomi / antalEkonomi) * 100;
                double procentEtik = (poängEtik / antalEtik) * 100;

                string godkantresultat = "Underkänd";
                string godkantProdukt = "Underkänd";
                string godkantEkonomi = "Underkänd";
                string godkantEtik = "Underkänd";

            if(procentResultat >= 70)
            {
                godkantresultat = "Godkänd";
            }

            if(procentProdukt >= 60)
            {
                godkantProdukt = "Godkänd";
            }

            if(procentEkonomi >= 60)
            {
                godkantEkonomi = "Godkänd";
            }

            if(procentEtik >= 60)
            {
                godkantEtik = "Godkänd";
            }

            if ((godkantresultat == "Godkänd") && (godkantProdukt == "Godkänd") && (godkantEkonomi == "Godkänd") && (godkantEtik == "Godkänd"))
            {
                godkantProv = "Godkänd";
                
                Databas.akuGodkand(ID);
                Databas.RegistreraProv(test_typ, true, Convert.ToString(procentResultat+"%"), dD, ID, Convert.ToString(procentProdukt+"%"), Convert.ToString(procentEkonomi+"%"), Convert.ToString(procentEtik+"%"));
            }

            else
            {
                godkantProv = "Underkänd";
                Databas.RegistreraProv(test_typ, false, Convert.ToString(procentResultat + "%"), dD, ID, Convert.ToString(procentProdukt + "%"), Convert.ToString(procentEkonomi + "%"), Convert.ToString(procentEtik + "%"));
                
                
            }
                totalPoang.InnerText = "Totalresultat: Du är " +  godkantresultat + ". Antal rätt totalt: " + poängräkning + " av " + antalTotal + " frågor. Dvs. " + procentResultat + "%." ;
                produktPoang.InnerText = "Produkter och hantering av kundens affärer: Du är " + godkantProdukt+ ". Antal rätt totalt: " + poängProdukter + " av " + antalProdukt + " frågor. Dvs. " + procentProdukt + "%.";
                ekonomiPoang.InnerText = "Ekonomi - nationalekonomi, finansiell ekonomi och privatekonomi: Du är " + godkantEkonomi + ". Antal rätt totalt: " + poängEkonomi + " av " + antalEkonomi + " frågor. Dvs. " + procentEkonomi + "%.";
                etikPoang.InnerText = "Etik och regelverk: Du är " + godkantEtik + ". Antal rätt totalt: " + poängEtik + " av " + antalEtik + " frågor. Dvs. " + procentEtik + "%.";
                btnSkickaAku.Enabled = false;

            
            
            //rattasvaret.InnerText = poängräkning.ToString();
                //alternativen.InnerText = poängProdukter.ToString();
                }
        }

       
    }
