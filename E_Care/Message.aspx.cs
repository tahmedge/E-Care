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
    public partial class Message : System.Web.UI.Page
    {
        string sendername, recievername;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                if (IntroPage.usertype == 0)
                {
                    string oradb = "Data Source=localhost;User Id=system;Password=965720;";
                    OracleConnection conn = new OracleConnection(oradb);  // C#
                    conn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select fullname from ecare_patient where id='" + Data.pid + "'";
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    TextBox1.Text = dr.GetString(0);
                    LabelDate.Text = DateTime.Now.ToString("d");
                    conn.Dispose();
                }
                else if (IntroPage.usertype == 1)
                {
                    string oradb = "Data Source=localhost;User Id=system;Password=965720;";
                    OracleConnection conn = new OracleConnection(oradb);  // C#
                    conn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select fullname from ecare_doctor where id='" + Data.docid + "'";
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    TextBox1.Text = dr.GetString(0);
                    LabelDate.Text = DateTime.Now.ToString("d");
                    conn.Dispose();
                }
            }
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            Data ob = new Data();
            string id;
  string subject,body,messagetime;
            body=TextBox3.Text;
            subject=TextBox2.Text;
            messagetime= DateTime.Now.ToString("d");
              if (IntroPage.usertype == 0)
              {
                  id = ob.getmessageidpatient(Data.pid);
                   sendername=ob.getdocname(Data.docid);
                  recievername=ob.getnamepatient(Data.pid);
                  ob.insertmessagepatient(id,Data.docid,Data.pid,sendername,recievername,subject,body,messagetime);
                  TextBox1.Text = recievername;
                  Response.Redirect("DoctorProfileOwn.aspx");
              }
              else if (IntroPage.usertype == 1)
              {
                  id = ob.getmessageiddoctor(Data.docid);
                  recievername = ob.getdocname(Data.docid);
                  sendername = ob.getnamepatient(Data.pid);
                  ob.insertmessagedoctor(id, Data.pid, Data.docid, sendername,recievername, subject, body, messagetime);
                  TextBox1.Text = recievername;
                  Response.Redirect("DoctorProfileVisit.aspx");
              }
        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {

        }

        protected void Button3_Click(object sender, System.EventArgs e)
        {

        }
    }
}