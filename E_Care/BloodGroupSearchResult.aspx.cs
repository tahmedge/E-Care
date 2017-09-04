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
    public partial class BloodGroupSearchResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // if (Page.IsPostBack)
            {
                string oradb = "Data Source=localhost;User Id=system;Password=965720;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                //    Data.searchspeciality = DropDownList1.SelectedItem.Value;
                //    Data.searchdistrict = DropDownList2.SelectedItem.Value;
                cmd.CommandText = "select fullname,bloodgroup,district,contactnumber,id from ecare_patient where bloodgroup='" + Data.searchbloodtype + "'and district='" + Data.searchblooddistrict + "'";
                //       cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                //

                int i = 0;
                while (dr.Read())
                {
                    // if(i>0)
                    //   stf.InnerHtml = "<hr>";
                    i++;


                    LinkButton Name = new LinkButton();
                    //  myLabel.Font.Size = FontUnit.XLarge;
                    Name.ForeColor = Color.BlueViolet;
                    Name.Text = dr.GetString(0);
                    Name.ID = dr.GetString(4);
                    //      Name.Attributes.Add("runat", "server");
                    //   Name.C += new EventHandler(Dynamic_Click);
                    Name.Click += new EventHandler(Dynamic_Click);
                    Name.Style.Add(HtmlTextWriterStyle.FontSize, "x-large");
                    Label Blood = new Label();
                    //  myLabels.CssClass = "style1";
                    Blood.Text = dr.GetString(1);
                    Blood.ID = dr.GetString(1) + i.ToString();
                    Blood.ForeColor = Color.Green;
                    Label Contactnumber = new Label();
                    //  myLabelss.Font.Size = FontUnit.XLarge;
                    Contactnumber.Text = dr.GetString(3);
                    Contactnumber.ID = dr.GetString(3) + i.ToString();
                    Contactnumber.ForeColor = Color.DarkOrange;
                    Label District = new Label();
                    //  myLabelsss.CssClass = "style1";
                    District.Text = dr.GetString(2);
                    District.ID = dr.GetString(2) + i.ToString();
                    District.ForeColor = Color.DarkRed;
                    BloodGroupSearchResultPlaceHolder.Controls.Add(Name);
                    BloodGroupSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                    BloodGroupSearchResultPlaceHolder.Controls.Add(Blood);
                    BloodGroupSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                    BloodGroupSearchResultPlaceHolder.Controls.Add(District);
                    BloodGroupSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                    BloodGroupSearchResultPlaceHolder.Controls.Add(Contactnumber);
                    BloodGroupSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                    BloodGroupSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                    str.Controls.Add(BloodGroupSearchResultPlaceHolder);

                }
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {

        }



        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientProfileView.aspx");
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("PatientProfileView.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            Data.searchbloodtype = DropDownList5.SelectedItem.Value;
            Data.searchblooddistrict = DropDownList6.SelectedItem.Value;
            cmd.CommandText = "select fullname,bloodgroup,district,contactnumber,id from ecare_patient where bloodgroup='" + Data.searchbloodtype + "'and district='" + Data.searchblooddistrict + "'";
            //       cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            //
            BloodGroupSearchResultPlaceHolder.Controls.Clear();
            str.Controls.Add(BloodGroupSearchResultPlaceHolder);
            int i = 0;
            while (dr.Read())
            {
                // if(i>0)
                //   stf.InnerHtml = "<hr>";
                i++;


                LinkButton Name = new LinkButton();
                //  myLabel.Font.Size = FontUnit.XLarge;
                Name.ForeColor = Color.BlueViolet;
                Name.Text = dr.GetString(0);
                Name.ID = dr.GetString(4);
                //      Name.Attributes.Add("runat", "server");
                //   Name.C += new EventHandler(Dynamic_Click);
                  Name.Click += new EventHandler(Dynamic_Click);

                Label Blood = new Label();
                //  myLabels.CssClass = "style1";
                Blood.Text = dr.GetString(1);
                Blood.ID = dr.GetString(1) + i.ToString();
                Blood.ForeColor = Color.Green;
                Label Contactnumber = new Label();
                //  myLabelss.Font.Size = FontUnit.XLarge;
                Contactnumber.Text = dr.GetString(3);
                Contactnumber.ID = dr.GetString(3) + i.ToString();
                Contactnumber.ForeColor = Color.DarkOrange;
                Label District = new Label();
                //  myLabelsss.CssClass = "style1";
                District.Text = dr.GetString(2);
                District.ID = dr.GetString(2) + i.ToString();
                District.ForeColor = Color.DarkRed;
                BloodGroupSearchResultPlaceHolder.Controls.Add(Name);
                BloodGroupSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                BloodGroupSearchResultPlaceHolder.Controls.Add(Blood);
                BloodGroupSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                BloodGroupSearchResultPlaceHolder.Controls.Add(District);
                BloodGroupSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                BloodGroupSearchResultPlaceHolder.Controls.Add(Contactnumber);
                BloodGroupSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                BloodGroupSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                str.Controls.Add(BloodGroupSearchResultPlaceHolder);
              //  Response.Redirect("PatientProfileView.aspx");
            }
        }
        protected void Dynamic_Click(object sender, EventArgs e)
        {
            LinkButton lss = (LinkButton)sender;

            Data.pid = lss.ID;
            Response.Redirect("PatientProfileView.aspx");
        }

        protected void DropDownList5_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}