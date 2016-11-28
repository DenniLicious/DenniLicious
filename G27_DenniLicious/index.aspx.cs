using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace G27_DenniLicious
{
    public partial class index : System.Web.UI.Page
    {
        List<Anvandare> Anvandarlista = new List<Anvandare>();
        Db Databas = new Db();
        //Anvandare aktuellA = new Anvandare();
        string aktuell = "1";

        protected void Page_Load(object sender, EventArgs e)
        {
            //Laddar in dropdownen med namn och id från Användarna i databasen vid load om det inte är postback.
            if (!IsPostBack)
            {
                //Lägger in alla användare i användarlistan från metoden Anvandarna();
                Anvandarlista = Databas.Anvandarna();
                //Lägger till listan i dropdownen och visar deras namn och har deras unika användarid som värde(dolt)
                DropDownList1.DataTextField = "namn";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataSource = Anvandarlista;
                DropDownList1.DataBind();
            }

            //metod för att lägga till medlem - fungerar
            //Db dennis = new Db();
            //dennis.testar();
        }

        protected void LoggaInKnapp_Click(object sender, EventArgs e)
        {
            //Lägger in den personen som metoden plockar fram och tilldelar värden(id, namn, typ, aku) från databasen till en array.
            int va = int.Parse(aktuell);
            string[] aktuellA = { "", "", "", "" };
            aktuellA = Databas.ValdAnvandare(va);
            //Databas.ValdAnvandare(va);

            //Sparar det unika IDet i en session.
            Session["anvandarId"] = va;


            if (aktuellA[2] == "Nyanställd" || aktuellA[2] == "Anställd" && aktuellA[3] != "True")
            {
                Response.Redirect("StartaTest.aspx");
            }

            else if (aktuellA[2]=="Admin")
            {
                Response.Redirect("Admin.aspx");
            }

            else if (aktuellA[2] == "Anställd" && aktuellA[3] == "True")
            {
                Response.Redirect("ingatester.aspx");
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuell = DropDownList1.SelectedValue;
        }
    }
}