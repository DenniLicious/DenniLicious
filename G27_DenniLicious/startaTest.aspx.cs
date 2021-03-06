﻿using System;
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
        int ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Tar fram ID:et ur session så vi kan skapa en array av vald användare igen.
            //Lägger in den personen som metoden plockar fram och tilldelar värden(id, namn, typ, aku) från databasen till en array.
            ID = (int)Session["anvandarId"];
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

            Session["anvandarId"] =  ID;
        }
    }
}