using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace G27_DenniLicious
{
    public partial class Licensieringstest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string path = Server.MapPath("fragor.xml");
            //XmlSwitchCase();
        }
        
        //public void XmlSwitchCase()
        //{
        //    string fragor = "";
        //    string path = Server.MapPath("fragor.xml");
        //    XmlTextReader xreader = new XmlTextReader(path);

        //    //läser igenom Xml-filen
        //    while (xreader.Read())
        //    {
        //        switch (xreader.Name)
        //        {
        //            case "text":
        //                fragor += xreader.ReadString();
        //                break;
        //        }
        //    }

        //    allafragor.InnerHtml = fragor;
        //}
    }
}