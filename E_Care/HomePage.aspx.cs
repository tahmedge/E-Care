using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Drawing;
using System.Linq;
using System.Text;


namespace E_Care
{
    public partial class HomePage : System.Web.UI.Page
    {
        public static string b="randy orton";
        protected void Page_Load(object sender, EventArgs e)
        {
            IntroPage ob = new IntroPage();
            b = IntroPage.a;
        //    TextBox3.Text = b;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("BloodGroupSearchResult.aspx");
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("DoctorSearchResult.aspx");
        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("DoctorSearchResult.aspx");
        }
    }
}