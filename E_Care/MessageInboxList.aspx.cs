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
    public partial class MessageInboxList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                string oradb = "Data Source=localhost;User Id=system;Password=965720;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                if (IntroPage.usertype == 1)
                {
                    cmd.CommandText = "select id,sender,messagetime,subject from ecare_message where recieverid='" + Data.pid + "'";
                }
                else if (IntroPage.usertype == 0)
                {
                    cmd.CommandText = "select id,sender,messagetime,subject from ecare_message where recieverid='" + Data.docid + "'";
                }
                OracleDataReader dr = cmd.ExecuteReader();
                //  conn.Dispose();

                while (dr.Read())
                {
                    try
                    {

                        string id = dr.GetString(0);
                        string name = dr.GetString(1);
                        string messagetime = dr.GetString(2);
                        string subject = dr.GetString(3);

                        int i = 0;
                        //     while (drr.Read())
                        {
                            // if(i>0)
                            //   stf.InnerHtml = "<hr>";
                            i++;


                            LinkButton Subject = new LinkButton();
                            //  myLabel.Font.Size = FontUnit.XLarge;
                            Subject.ForeColor = Color.BlueViolet;
                            Subject.Text = dr.GetString(3);
                            Subject.ID = dr.GetString(0);
                            //      Name.Attributes.Add("runat", "server");
                            //   Name.C += new EventHandler(Dynamic_Click);
                            Subject.Click += new EventHandler(Dynamic_Click);
                            Label Name = new Label();
                            //  myLabel.Font.Size = FontUnit.XLarge;
                            Name.ForeColor = Color.Gray;
                            Name.Text = dr.GetString(1);
                            Name.ID = dr.GetString(0) + " " + Name.Text + " " + i.ToString();
                            //      Name.Attributes.Add("runat", "server");
                            //   Name.C += new EventHandler(Dynamic_Click);
                            Subject.Click += new EventHandler(Dynamic_Click);
                            Label Date = new Label();
                            //  myLabel.Font.Size = FontUnit.XLarge;
                            Date.ForeColor = Color.Gray;
                            Date.Text = dr.GetString(2);
                            Date.ID = dr.GetString(0) + " " + Date.Text + " " + i.ToString();
                            //      Name.Attributes.Add("runat", "server");
                            //   Name.C += new EventHandler(Dynamic_Click);
                            Subject.Click += new EventHandler(Dynamic_Click);


                            //  myLabels.CssClass = "style1";

                            DoctorSearchResultPlaceHolder.Controls.Add(Subject);

                            DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));

                            DoctorSearchResultPlaceHolder.Controls.Add(Name);

                            DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));

                            DoctorSearchResultPlaceHolder.Controls.Add(Date);

                            DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                            DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                            str.Controls.Add(DoctorSearchResultPlaceHolder);
                        }
                  
                    }
                    catch (Exception ex)
                    {

                    }

                } conn.Dispose();           //
                //   c
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("MessageInbox.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("MessageInbox.aspx");
        }
        protected void Dynamic_Click(object sender, EventArgs e)
        {
            LinkButton lss = (LinkButton)sender;
            Data.msgid = lss.ID;
            Response.Redirect("MessageInbox.aspx");
        }
    }
}