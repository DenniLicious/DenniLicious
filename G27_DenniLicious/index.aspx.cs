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
            if (!IsPostBack)
            {
                Anvandarlista = Databas.Anvandarna();

                
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
            
            int va = int.Parse(aktuell);
            string[] aktuellA = { "", "", "" };
            aktuellA = Databas.ValdAnvandare(va);
            //Databas.ValdAnvandare(va);


            Session["anvandarId"] = va;
            
            

            if(aktuellA[2] == "Nyanställd" || aktuellA[2] == "Anställd")
            {
                Response.Redirect("StartaTest.aspx");
            }

            else if (aktuellA[2]=="Admin")
            {
                Response.Redirect("Admin.aspx");
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuell = DropDownList1.SelectedValue;
        }
    }
}