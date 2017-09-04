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
    public partial class PatientVerification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Data ob = new Data();
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   Data ob = new Data();
            //  cmd.Connection = conn;
            cmd.CommandText = "select patientid,appointmentdate,id from ECARE_APPOINTMENT where doctorid='" + Data.docid + "' and appointmentstatus=" + 1 + " order by appointmentdate asc";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader(); int i = 0;
            while (dr.Read())
            {
                string ids = dr.GetString(0);
                string name = ob.getnamepatient(ids);
                i++;

                LinkButton Name = new LinkButton();
                //  myLabel.Font.Size = FontUnit.XLarge;
                Name.ForeColor = Color.Green;
                Name.Text = name;
                Name.ID = dr.GetString(0)+dr.GetString(2);
                //      Name.Attributes.Add("runat", "server");
                //   Name.C += new EventHandler(Dynamic_Click);
                Name.Click += new EventHandler(Dynamic_Click);
                Label msg = new Label();
                //  myLabels.CssClass = "style1";
                msg.Text = " has booked an appointment on " + dr.GetString(1) +" "+dr.GetString(2);
                msg.ID = dr.GetString(0) + dr.GetString(2)+"msg";
                msg.ForeColor = Color.Blue;

 
               
                DoctorSearchResultPlaceHolder.Controls.Add(Name);
         //       DoctorSearchResultPlaceHolder.Controls.Add(Degree);
         //       DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
           //     DoctorSearchResultPlaceHolder.Controls.Add(Accept);
             //   DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("     "));
                DoctorSearchResultPlaceHolder.Controls.Add(msg);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                str.Controls.Add(DoctorSearchResultPlaceHolder);
            } conn.Dispose();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientProfileView.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
                    }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientProfileView.aspx");

        }
        protected void Dynamic_Click(object sender, EventArgs e)
        {
            LinkButton lss = (LinkButton)sender;
            string s = lss.ID;
            Data.pid="";
            for (int i = 0; i < s.Length;i++ )
            {
                if (s[i] >= '9') break;
                else Data.pid += s[i];
            }
                Response.Redirect("PatientProfileView.aspx");
        }
    }
}