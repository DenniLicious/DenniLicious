using System;
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
            if (!IsPostBack)
            {              
                ddProvdeltagare.DataTextField = "namn";
                ddProvdeltagare.DataValueField = "id";
                ddProvdeltagare.DataSource = Databas.Provdeltagarna();
                ddProvdeltagare.DataBind();
            }

        }

        protected void btnSkaSkrivaTest_Click(object sender, EventArgs e)
        {
            if(rbLicensieringstest.Checked)
            {
                lbPersonerSomSkaSkrivaTest.DataSource = Databas.Del1();
                lbPersonerSomSkaSkrivaTest.DataBind();
            }
            else if(rbAkutest.Checked)
            {
                lbPersonerSomSkaSkrivaTest.DataSource = Databas.Del2();
                lbPersonerSomSkaSkrivaTest.DataBind();
            }
        }

        protected void ddProvdeltagare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnResultat_Click(object sender, EventArgs e)
        {
            int vald = int.Parse(ddProvdeltagare.SelectedValue);
            List<Provresultat> pr = new List<Provresultat>();
            pr = Databas.hämtaResultat(vald);

            test.Text = "";
            datum.Text = "";
            produkt.Text = "";
            ekonomi.Text = "";
            etik.Text = "";
            totalt.Text = "";
            resultat.Text = "";

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
                    produkt.Text = prov.resultat_produkter;
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


    }
}