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


    }
}