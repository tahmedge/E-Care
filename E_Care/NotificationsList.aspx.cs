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
    public partial class NotificationsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   Data ob = new Data();
            cmd.Connection = conn;
            cmd.CommandText = "select id,notifications,notificationtime from ECARE_notifications where patientid='" + Data.pid + "' order by id desc";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader(); int i = 0;
            while (dr.Read())
            {
                string ids = dr.GetString(0);
             
                i++;

               LinkButton Name = new LinkButton();
                //  myLabel.Font.Size = FontUnit.XLarge;
                Name.ForeColor = Color.BlueViolet;
                Name.Text = dr.GetString(1);
                Name.ID = dr.GetString(0);
                Label time = new Label();
                //  myLabel.Font.Size = FontUnit.XLarge;
                time.ForeColor = Color.Gray;
                time.Text = dr.GetString(2);
                time.ID = dr.GetString(0)+" time";
                //      Name.Attributes.Add("runat", "server");
                  Name.Click += new EventHandler(Dynamic_Click);

             
             //   Accept.Click += new EventHandler(Accept_Click);
            //    Ignore.Click += new EventHandler(Ignore_Click);
                DoctorSearchResultPlaceHolder.Controls.Add(Name);
             
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(time);

                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                str.Controls.Add(DoctorSearchResultPlaceHolder);
            } conn.Dispose();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("DoctorProfileVisit.aspx");
        }
        protected void Dynamic_Click(object sender, EventArgs e)
        {
            Data ob = new Data();
            LinkButton lss = (LinkButton)sender;
           // Data.pid = lss.ID;
            string id=lss.ID;
            Data.docid = ob.getidfromnotifications(Data.pid, id);
            Response.Redirect("DoctorProfileVisit.aspx");
        }
    }
}