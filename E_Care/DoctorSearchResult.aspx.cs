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
    public partial class DoctorSearchResult : System.Web.UI.Page
    {
    /*    protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.Load += Page_Load;
        } */
        protected void Page_Load(object sender, EventArgs e)
        {
             { 
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
          
            cmd.CommandText = "select fullname,degree,speciality,district,id from ecare_doctor where speciality='"+Data.searchspeciality+"'and district='"+Data.searchdistrict+"'";
            //       cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            //
            DoctorSearchResultPlaceHolder.Controls.Clear();
            str.Controls.Add(DoctorSearchResultPlaceHolder);
            int i = 0;
            while (dr.Read())
            {
                // if(i>0)
                //   stf.InnerHtml = "<hr>";
                i++;
                System.Web.UI.WebControls.Image img = new System.Web.UI.WebControls.Image();
                img.ImageUrl = "~/" + dr.GetString(4) + ".jpg";
                img.Width = 300;
                img.Height = 225;
                LinkButton Name = new LinkButton();
                //  myLabel.Font.Size = FontUnit.XLarge;
                Name.ForeColor = Color.BlueViolet;
                Name.Text = dr.GetString(0);
                Name.ID = dr.GetString(4);
                //      Name.Attributes.Add("runat", "server");
                //   Name.C += new EventHandler(Dynamic_Click);
                Name.Click += new EventHandler(Dynamic_Click);
                Label Degree = new Label();
                //  myLabels.CssClass = "style1";
                Degree.Text = dr.GetString(1);
                Degree.ID = dr.GetString(1) + i.ToString();
                Degree.ForeColor = Color.Green;
                Label Speciality = new Label();
                //  myLabelss.Font.Size = FontUnit.XLarge;
                Speciality.Text = dr.GetString(2);
                Speciality.ID = dr.GetString(2) + i.ToString();
                Speciality.ForeColor = Color.Crimson;
                Label District = new Label();
                //  myLabelsss.CssClass = "style1";
                District.Text = dr.GetString(3);
                District.ID = dr.GetString(3) + i.ToString();
                District.ForeColor = Color.DarkRed;
                DoctorSearchResultPlaceHolder.Controls.Add(img);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(Name);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(Degree);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(Speciality);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(District);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                str.Controls.Add(DoctorSearchResultPlaceHolder);
            }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DoctorSearchResultPlaceHolder.Controls.Clear();
            str.Controls.Add(DoctorSearchResultPlaceHolder);
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            Data.searchspeciality = DropDownList1.SelectedItem.Value;
            Data.searchdistrict = DropDownList2.SelectedItem.Value;
            cmd.CommandText = "select fullname,degree,speciality,district,id from ecare_doctor where speciality='" + Data.searchspeciality + "'and district='" + Data.searchdistrict + "'";
            //       cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            //

            int i = 0;
            while (dr.Read())
            {
                // if(i>0)
                //   stf.InnerHtml = "<hr>";
                i++;

                System.Web.UI.WebControls.Image img = new System.Web.UI.WebControls.Image();
                img.ImageUrl = "~/" + dr.GetString(4) + ".jpg";
                img.Width = 300;
                img.Height = 225;
                
                LinkButton Name = new LinkButton();
                //  myLabel.Font.Size = FontUnit.XLarge;
                Name.ForeColor = Color.BlueViolet;
                Name.Text = dr.GetString(0);
                Name.ID = dr.GetString(4) ;
                Name.Style.Add(HtmlTextWriterStyle.FontSize, "x-large");
         //      Name.Attributes.Add("runat", "server");
            //   Name.C += new EventHandler(Dynamic_Click);
                Name.Click += new EventHandler(Dynamic_Click);
                Label Degree = new Label();
                //  myLabels.CssClass = "style1";
                Degree.Text = dr.GetString(1);
                Degree.ID = dr.GetString(1) + i.ToString();
                Degree.ForeColor = Color.Green;
                Label Speciality = new Label();
                //  myLabelss.Font.Size = FontUnit.XLarge;
                Speciality.Text = dr.GetString(2);
                Speciality.ID = dr.GetString(2) + i.ToString();
                Speciality.ForeColor = Color.DarkRed;
                Label District = new Label();
                //  myLabelsss.CssClass = "style1";
                District.Text = dr.GetString(3);
                District.ID = dr.GetString(3) + i.ToString();
                District.ForeColor = Color.Crimson;
                DoctorSearchResultPlaceHolder.Controls.Add(img);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(Name);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(Degree);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(Speciality);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(District);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                str.Controls.Add(DoctorSearchResultPlaceHolder);

            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
          //  Response.Redirect("PatientProfileView.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
           // Response.Redirect("PatientProfileView.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
      //  Response.Redirect("PatientProfileView.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoctorProfileVisit.aspx");
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("DoctorProfileVisit.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("DoctorProfileUnregistered.aspx");
        }

        protected void LinkButton2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("DoctorProfileUnregistered.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoctorProfileVisit.aspx");
        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            Response.Redirect("DoctorProfileVisit.aspx");
        }


        protected void Dynamic_Click(object sender, EventArgs e)
        {
            LinkButton lss = (LinkButton)sender;
        
            Data.docid = lss.ID;
            Response.Redirect("DoctorProfileVisit.aspx");
        }


        }
        }
  