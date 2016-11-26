using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace G27_DenniLicious
{
    public partial class StartaTest : System.Web.UI.Page
    {
        Db Databas = new Db();
        string[] aktuellA = { "", "", "" , ""};

        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = (int)Session["anvandarId"];
            aktuellA = Databas.ValdAnvandare(ID);
            
            if (aktuellA[2] == "Nyanställd")
            {
                startaTestKnapp.Text = "Starta Licensieringstest";
            }
            if (aktuellA[2] == "Anställd")
            {
                startaTestKnapp.Text = "Starta Årligt kunskapstest";
            }
        }

        protected void startaTestKnapp_Click(object sender, EventArgs e)
        {
            if (aktuellA[2] == "Nyanställd")
            {
                Response.Redirect("Licensieringstest.aspx");
            }
            else if (aktuellA[2] == "Anställd")
            {
                Response.Redirect("AKUtest.aspx");
            }
        }
    }
}