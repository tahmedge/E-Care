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
    public partial class NotificationsListDoctor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         //   if (Page.IsPostBack == false)
            {
                string oradb = "Data Source=localhost;User Id=system;Password=965720;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                //   Data ob = new Data();
                cmd.Connection = conn;
                cmd.CommandText = "select id from ECARE_userverification where status=" + 0 + " and VARIFICATIONID='" + Data.docid + "'  order by id desc";
                //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
                OracleDataReader dr = cmd.ExecuteReader(); int i = 0;
                Data ob = new Data();
                DoctorSearchResultPlaceHolder.Controls.Clear();
                str.Controls.Add(DoctorSearchResultPlaceHolder);
                while (dr.Read())
                {
                    string ids = dr.GetString(0);

                    i++;
                    string name = ob.getdocname(ids);
                    LinkButton Name = new LinkButton();
                    //  myLabel.Font.Size = FontUnit.XLarge;
                    Name.ForeColor = Color.BlueViolet;
                    Name.Text = name;
                    Name.ID = dr.GetString(0);
                    Label time = new Label();
                    //  myLabel.Font.Size = FontUnit.XLarge;
                    time.ForeColor = Color.Black;
                    time.Text = " to register with your reference";
                    time.ID = dr.GetString(0) + "Label";
                    //      Name.Attributes.Add("runat", "server");
                    Name.Click += new EventHandler(Dynamic_Click);
                    Button Accept = new Button();
                    //  myLabels.CssClass = "style1";
                    Accept.Text = "Accept";
                    Accept.ID = "A" + dr.GetString(0);
                    Accept.ForeColor = Color.ForestGreen;


                    Button Ignore = new Button();
                    //  myLabels.CssClass = "style1";
                    Ignore.Text = "Ignore";
                    Ignore.ID = "I" + dr.GetString(0);
                    Ignore.ForeColor = Color.Red;
                    Accept.Click += new EventHandler(Accept_Click);
                    Ignore.Click += new EventHandler(Ignore_Click);

                    //   Accept.Click += new EventHandler(Accept_Click);
                    //    Ignore.Click += new EventHandler(Ignore_Click);
                    DoctorSearchResultPlaceHolder.Controls.Add(Name);
                    DoctorSearchResultPlaceHolder.Controls.Add(time);
                    DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                    DoctorSearchResultPlaceHolder.Controls.Add(Accept);
                    DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                    DoctorSearchResultPlaceHolder.Controls.Add(Ignore);
                    DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                    DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                    str.Controls.Add(DoctorSearchResultPlaceHolder);
                } conn.Dispose();
            }
        }
             protected void Accept_Click(object sender, EventArgs e)
        {

           Button lss = (Button)sender;
           string s;
           Data.pid = "";
           s = lss.ID; int j = 0;
           Data.refid = "";
            for(int i=1;i<s.Length;i++)
            {
                Data.refid += s[i];
            }
            Data ob = new Data();
            ob.updateverification(Data.refid, Data.docid, 1);
            this.Page_Load(null, null);

         //   Response.Redirect("PatientProfileView.aspx");
         //   Response.Redirect("PatientProfileView.aspx");
        }
        protected void Ignore_Click(object sender, EventArgs e)
        {
            Button lss = (Button)sender;
            string s;
            Data.refid = "";
            s = lss.ID; int j = 0;
            for (int i = 1; i < s.Length; i++)
            {
                Data.refid += s[i];
            }
           // Response.Redirect("PatientProfileView.aspx");
          //  Response.Redirect("PatientProfileView.aspx");
        }
            //   Response.Redirect("PatientProfileView.aspx");
            //   Response.Redirect("PatientProfileView.aspx");
        

        protected void Dynamic_Click(object sender, EventArgs e)
        {
           
            LinkButton lss = (LinkButton)sender;
            Data.refid = lss.ID;
            Response.Redirect("DoctorProfileUnregistered.aspx");
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoctorProfileOwn.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
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
    }
}