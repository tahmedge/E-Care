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

    public partial class EditPatient : System.Web.UI.Page
    {
        string password = "";
        Data ob = new Data();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                string oradb = "Data Source=localhost;User Id=system;Password=965720;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                //    Data.searchspeciality = DropDownList1.SelectedItem.Value;
                //    Data.searchdistrict = DropDownList2.SelectedItem.Value;
                cmd.CommandText = "select email,password from ecare_user where id='" + Data.pid + "'";
                //       cmd.CommandType = CommandType.Text;
                OracleDataReader user = cmd.ExecuteReader();
                while (user.Read())
                {
                    TextBox2.Text = user.GetString(0);
                    TextBox3.Text = user.GetString(1);
                    TextBox4.Text = user.GetString(1);
                }
                //  password = user.GetString(1);
                //   conn.Dispose();
                cmd.CommandText = "select fullname,district,bloodgroup,contactnumber from ecare_patient where id='" + Data.pid + "'";

                //       cmd.CommandType = CommandType.Text;
                OracleDataReader pat = cmd.ExecuteReader();
                pat.Read();
                TextBox5.Text = pat.GetString(0);
                DropDownList2.SelectedValue = pat.GetString(1);
                DropDownList3.SelectedValue = pat.GetString(2);
                TextBox1.Text = pat.GetString(3);
                conn.Dispose();
            }
        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
            if (TextBox3.Text == TextBox4.Text)
            {
            
                ob.updatepatient(Data.pid,TextBox5.Text,DropDownList2.SelectedValue,DropDownList3.SelectedValue,TextBox1.Text);
   
                ob.updateuser(Data.pid, TextBox2.Text, TextBox3.Text);
                MessageBox.ShowMessage("Saved Changes Succesfully!", this.Page);
                Response.Redirect("HomePageUser.aspx");
            }
            else
            {
                MessageBox.ShowMessage("Password Filled did not match!", this.Page);
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}