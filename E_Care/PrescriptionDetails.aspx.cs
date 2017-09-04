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
    public partial class PrescriptionDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select doctorid,body,doctorname,issuedate from ecare_prescription where id='" + Data.presid + "' and patientid='"+Data.pid+"'";
            //       cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string id = dr.GetString(0);
          //  cmd.CommandText = "select fullname from ecare_doctor where id='" + id + "'";
            //       cmd.CommandType = CommandType.Text;
         //   OracleDataReader drr = cmd.ExecuteReader();
            //

            int i = 0;
          //  while (dr.Read())
            {
                // if(i>0)
                //   stf.InnerHtml = "<hr>";
                i++;
                Data.docid=id;
                LinkButtonName.Text = dr.GetString(2);
                LabelDate.Text = dr.GetString(3);
                TextBoxBody.Text = dr.GetString(1);
             
            }
            conn.Dispose();
            if(IntroPage.usertype==0)
            {
                Button3.Visible = false;
                Button4.Visible = false;
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Message.aspx");
        }

        protected void Button3_Click(object sender, System.EventArgs e)
        {
            Data ob = new Data();
            ob.updateprescription(Data.pid, Data.presid);
        }

        protected void Button4_Click(object sender, System.EventArgs e)
        {
            Data ob = new Data();
            ob.deleteprescription(Data.pid, Data.presid);
            Response.Redirect("HomePageUser.aspx");
        }
        protected void Dynamic_Click(object sender, EventArgs e)
        {
            LinkButton lss = (LinkButton)sender;
            Data.presid = lss.ID;
            Response.Redirect("PrescriptionDetails.aspx");
        }

        protected void LinkButtonName_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("DoctorProfileVisit.aspx");
        }
    }
}