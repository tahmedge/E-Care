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
    public partial class PatientProfileView : System.Web.UI.Page
    {
        public static int val = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
           // if (Page.IsPostBack)
            {
                if(IntroPage.usertype!=0)
                {
                    Button1.Visible = false;
                    Button2.Visible = false;
                    Button3.Visible = false;
                }
                else
                {
                    Button1.Visible = true;
                    Button2.Visible = true;
                    Button3.Visible = true;

                }
                string oradb = "Data Source=localhost;User Id=system;Password=965720;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select fullname,contactnumber,sex,district,bloodgroup from ecare_patient where id='" + Data.pid + "'";
                //       cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                //

                int i = 0;
                while (dr.Read())
                {
                    // if(i>0)
                    //   stf.InnerHtml = "<hr>";
                    i++;


                    NM.Text = dr.GetString(0);
                    CN.Text = dr.GetString(1);
                    SEX.Text = dr.GetString(2);
                    DS.Text = dr.GetString(3);
                    BG.Text = dr.GetString(4);

                }
                Data ob = new Data();
                string eml = ob.getemail(Data.pid);
             //   drr.Read();
                EM.Text = eml;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         
          Response.Redirect("Message.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("PrescriptionHistory.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Data.recieverid = Data.pid;
            Response.Redirect("PrescriptionSend.aspx");
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}