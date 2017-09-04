using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Care
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUpType.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("IntroPage.aspx");
        }
    }
}