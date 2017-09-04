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
    public partial class PrescriptionSend : System.Web.UI.Page
    {
        string uname;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                string oradb = "Data Source=localhost;User Id=system;Password=965720;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select username from ecare_user where id='" + Data.pid + "'";
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                TextBox4.Text = dr.GetString(0);
                Label_Date.Text = DateTime.Now.ToString("d");
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            uname = TextBox4.Text;
          //  Label1.Text = uname;
        }
        string id, senderid, recieverid, body, issuedate;
        protected void Button1_Click(object sender, System.EventArgs e)
        {
            uname = TextBox4.Text;
            Data ob = new Data();
            int check = ob.checkuser(uname);
            string getname = ob.getdocname(Data.docid);
            if(check==0)
            {
                MessageBox.ShowMessage("There is no user with that username in ECARE!", this.Page);
            }
            else
            {
                Label1.Text = check.ToString();
                id = ob.getprescriptionid(Data.pid);
                body = Textbox_Body.Text;
                issuedate = Label_Date.Text;
                int status = 0;
                ob.insertprescription(id, Data.docid,Data.pid,getname, body, issuedate,0);
                Response.Redirect("DoctorProfileOwn.aspx");
            }
           // Response.Redirect("DoctorProfileOwn.aspx");
        }
    }
}