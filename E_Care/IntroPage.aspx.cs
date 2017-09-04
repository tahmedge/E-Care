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
    public partial class IntroPage : System.Web.UI.Page
    {
        public static string a;
        public static int usertype = 0;
        public static string userid = "1";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(DropDownList2.SelectedIndex==0)
            {
                Data ob = new Data();

                int count = ob.searchuser(TextBox1_Username.Text, TextBox2_Password.Text,0);
                if (count != 1)
                {
                    // MessageBox.ShowMessage("Username and Password doesn't match!", this.Page);
                    Label3.Text = "Username or Password did not match!";
                }
                else
                {
                    Data.docid = ob.getmyid(TextBox1_Username.Text, TextBox2_Password.Text);
                    usertype = 0;
                    //    MessageBox.ShowMessage("Username and Password match!", this.Page);
                    Response.Redirect("DoctorProfileOwn.aspx");
                }
          
            }
            else if(DropDownList2.SelectedIndex==1)
            {

                Data ob = new Data();
                
                int count = ob.searchuser(TextBox1_Username.Text, TextBox2_Password.Text,1);
                if(count!=1)
                {
                   // MessageBox.ShowMessage("Username and Password doesn't match!", this.Page);
                    Label3.Text = "Username or Password did not match!";
                }
                else
                {
                    usertype = 1;
                    Data.pid = ob.getmyid(TextBox1_Username.Text, TextBox2_Password.Text);
                //    MessageBox.ShowMessage("Username and Password match!", this.Page);
                    Response.Redirect("HomePageUser.aspx");
                }
           

            }
            else if (DropDownList2.SelectedIndex == 2)
            {
                Response.Redirect("AppointmentRequestList.aspx");
            }
            /*string oradb = "Data Source=localhost;User Id=system;Password=965720;";
           j OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            string x, y, z;
            x = TextBox1.Text;
            y = TextBox2.Text;
            Label1.Text = "";
            try
            {
                cmd.CommandText = "select cn from patient where cn='"+x+"'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
               OracleString firstVariable;
                        firstVariable=dr.GetOracleString(0);
               Label1.Text=firstVariable.ToString();

          //      TextBox3.Text=  dr.GetString(0)
            }
            catch (Exception exx) { } */
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUpType.aspx");
        }

        protected void TextBox3_TextChanged(object sender, System.EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}