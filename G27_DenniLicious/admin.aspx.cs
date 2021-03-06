﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace G27_DenniLicious
{
    public partial class Admin : System.Web.UI.Page
    {
        Db Databas = new Db();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Laddar in dropdownen med namn och id från Användarna(Anställd och nyanställd) i databasen vid load om det inte är postback.
            if (!IsPostBack)
            {              
                ddProvdeltagare.DataTextField = "namn";
                ddProvdeltagare.DataValueField = "id";
                //Metod för att hämta anställda och nyanställda ur databas.
                ddProvdeltagare.DataSource = Databas.Provdeltagarna();
                ddProvdeltagare.DataBind();
                //Inaktiverar knappen aterstallAku
                aterstallAku.Enabled = false;
            }

        }

        protected void btnSkaSkrivaTest_Click(object sender, EventArgs e)
        {

            if(rbLicensieringstest.Checked)
            {
                //Metod som tar fram vilka som ska skriva licensieringstest
                lbPersonerSomSkaSkrivaTest.DataSource = Databas.Del1();
                lbPersonerSomSkaSkrivaTest.DataBind();
            }
            else if(rbAkutest.Checked)
            {
                //Metod som tar fram vilka som ska skriva AKU
                lbPersonerSomSkaSkrivaTest.DataSource = Databas.Del2();
                lbPersonerSomSkaSkrivaTest.DataBind();
            }
        }

        protected void ddProvdeltagare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnResultat_Click(object sender, EventArgs e)
        {
            //Tilldelar värdet(Användares ID) från den användare som är vald i dropdownen.
            int vald = int.Parse(ddProvdeltagare.SelectedValue);
            List<Provresultat> pr = new List<Provresultat>();
            //Metod som lägger till den valda personens senaste prov i en lista.
            pr = Databas.hämtaResultat(vald);

            test.Text = "";
            datum.Text = "";
            produkt.Text = "";
            ekonomi.Text = "";
            etik.Text = "";
            totalt.Text = "";
            resultat.Text = "";
            //Loopar igenom listan och plockar ut värden för den som är vald.
                foreach (Provresultat prov in pr)
                {
                    if (prov.test_typ == "aku2016")
                    {
                        test.Text = "Årligt Kunskapstest";
                    }
                    else if (prov.test_typ == "lictest")
                    {
                        test.Text = "Licensieringstest";
                    }



                    datum.Text = prov.datum.ToShortDateString();
                    produkt.Text =  prov.resultat_produkter;
                    ekonomi.Text = prov.resultat_ekonomi;
                    etik.Text = prov.resultat_etik;
                    totalt.Text = prov.resultat_totalt;

                    if (prov.godkand == true)
                    {
                        resultat.Text = "Godkänd";
                    }
                    else if (prov.godkand == false)
                    {
                        resultat.Text = "Underkänd";
                    }
                }
            
            
        }

        protected void aterstallAku_Click(object sender, EventArgs e)
        {
            //Metod som sätter allas "AKU" till false i tabellen användare.
            Databas.aterstallAku();
        }

        protected void aktiveraAkuKnapp_Click(object sender, EventArgs e)
        {
            aterstallAku.Enabled = true;

        }

        



    }
}