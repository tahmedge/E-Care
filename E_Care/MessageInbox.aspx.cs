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
    public partial class MessageInbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
          if(IntroPage.usertype==1)
            cmd.CommandText = "select senderid,subject,body,messagetime from ecare_message where recieverid='" + Data.pid + "'";
          else
              cmd.CommandText = "select senderid,subject,body,messagetime from ecare_message where recieverid='" + Data.docid + "'";
            //       cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            try
            {
                //  string id = dr.GetString(0);
                //  cmd.CommandText = "select fullname from ecare_doctor where id='" + id + "'";
                //       cmd.CommandType = CommandType.Text;
                //   OracleDataReader drr = cmd.ExecuteReader();
                //

                string fullname;
                int i = 0;
                //  while (dr.Read())
                {
                    // if(i>0)
                    //   stf.InnerHtml = "<hr>";
                    i++;
                    Data ob = new Data();
                    if (IntroPage.usertype == 1)
                    {
                        Data.docid = dr.GetString(0);

                        fullname = ob.getdocname(dr.GetString(0));
                    }
                    else
                    {
                        Data.pid = dr.GetString(0);
                        fullname = ob.getnamepatient(dr.GetString(0));
                    }
                    //  Data.docid = id;
                    LinkButtonSender.Text = fullname;
                    Label4.Text = dr.GetString(3);
                    TextBoxBody.Text = dr.GetString(2);
                    LabelSubject.Text = dr.GetString(1);

                }
                conn.Dispose();
            }
            catch(Exception ex)
            {

            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (IntroPage.usertype == 0)
            {
           
                Response.Redirect("PatientProfileView.aspx");
            }
            else
                Response.Redirect("DoctorProfileVisit.aspx");
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            if (IntroPage.usertype == 0)
            {

                Response.Redirect("PatientProfileView.aspx");
            }
            else
                Response.Redirect("DoctorProfileVisit.aspx");
        }
    }
}