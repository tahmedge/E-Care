using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Care
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditPatient.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePageUser.aspx");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("IntroPage.aspx");
       /*     Data.docid="-1";
            Data.pid="-1"; */
        }
    }
}