using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
    public partial class HomePageUser : System.Web.UI.Page
    {
        protected void Dynamic_Click(object sender, EventArgs e)
        {
            LinkButton lss = (LinkButton)sender;
            Data.presid = lss.ID;
            Response.Redirect("PrescriptionDetails.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           // if (Page.IsPostBack == false)
            {
             
               // m.Attributes["enabled"] = "true";
            }

                 // myTextBox.Style.Add("myStyle", "myvalue")
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Data.searchspeciality = DropDownList1.SelectedItem.Value;
            Data.searchdistrict = DropDownList2.SelectedItem.Value;
            Response.Redirect("DoctorSearchResult.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoctorSearchResult.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Data.searchbloodtype = DropDownList3.SelectedItem.Value;
            Data.searchblooddistrict = DropDownList4.SelectedItem.Value;
            Response.Redirect("BloodGroupSearchResult.aspx");
        }
    }
}