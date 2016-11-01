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


        protected void Page_Load(object sender, EventArgs e)
        {
            Anvandarlista = Databas.Anvandarna();
            

            DropDownList1.DataSource = Anvandarlista;
            DropDownList1.DataTextField = "namn";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
            //metod för att lägga till medlem - fungerar
            //Db dennis = new Db();
            //dennis.testar();
        }

        protected void LoggaInKnapp_Click(object sender, EventArgs e)
        {
            string aktuell = DropDownList1.SelectedValue;
            int va = int.Parse(aktuell);
            string[] aktuellA = { "", "", "" };
            aktuellA = Databas.ValdAnvandare(va);
            //Databas.ValdAnvandare(va);
            
            
            

            if(aktuellA[2] == "Nyanställd")
            {
                Response.Redirect("nyanstalld.aspx");
            }
        }
    }
}