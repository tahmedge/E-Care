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
    public partial class AppointmentRequestList : System.Web.UI.Page
    {

        Data ob = new Data();
        protected void Page_Load(object sender, EventArgs e)
        {
            DoctorSearchResultPlaceHolder.Controls.Clear();
            str.Controls.Add(DoctorSearchResultPlaceHolder);
           //if (Page.IsPostBack == false)
            {
                Button1.Text = DateTime.Now.AddDays(0).DayOfWeek.ToString();
                Button2.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
                Button3.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
                Button4.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();
                Button5.Text = DateTime.Now.AddDays(4).DayOfWeek.ToString();
                Button6.Text = DateTime.Now.AddDays(5).DayOfWeek.ToString();
                Button7.Text = DateTime.Now.AddDays(6).DayOfWeek.ToString();
                Day1.Text = DateTime.Now.AddDays(0).ToString("m");
                Day2.Text = DateTime.Now.AddDays(1).ToString("m");
                Day3.Text = DateTime.Now.AddDays(2).ToString("m");
                Day4.Text = DateTime.Now.AddDays(3).ToString("m");
                Day5.Text = DateTime.Now.AddDays(4).ToString("m");
                Day6.Text = DateTime.Now.AddDays(5).ToString("m");
                Day7.Text = DateTime.Now.AddDays(6).ToString("m");

                int vals1 = 0, vals2 = 0, vals3 = 0, vals4 = 0, vals5 = 0, vals6 = 0, vals7 = 0;
                if (Button1.Text == "Saturday")
                {
                    vals1 = ob.saturday(Data.docid);

                }
                else if (Button1.Text == "Sunday")
                {
                    vals1 = ob.sunday(Data.docid);
                }
                else if (Button1.Text == "Monday")
                {
                    vals1 = ob.monday(Data.docid);
                }
                else if (Button1.Text == "Tuesday")
                {
                    vals1 = ob.tuesday(Data.docid);
                }
                else if (Button1.Text == "Wednesday")
                {
                    vals1 = ob.wednesday(Data.docid);
                }
                else if (Button1.Text == "Thursday")
                {
                    vals1 = ob.thursday(Data.docid);
                }
                else if (Button1.Text == "Friday")
                {
                    vals1 = ob.friday(Data.docid);
                }


                if (Button2.Text == "Saturday")
                {
                    vals2 = ob.saturday(Data.docid);
                }
                else if (Button2.Text == "Sunday")
                {
                    vals2 = ob.sunday(Data.docid);
                }
                else if (Button2.Text == "Monday")
                {
                    vals2 = ob.monday(Data.docid);
                }
                else if (Button2.Text == "Tuesday")
                {
                    vals2 = ob.tuesday(Data.docid);
                }
                else if (Button2.Text == "Wednesday")
                {
                    vals2 = ob.wednesday(Data.docid);
                }
                else if (Button2.Text == "Thursday")
                {
                    vals2 = ob.thursday(Data.docid);
                }
                else if (Button2.Text == "Friday")
                {
                    vals2 = ob.friday(Data.docid);
                }

                if (Button3.Text == "Saturday")
                {
                    vals3 = ob.saturday(Data.docid);
                }
                else if (Button3.Text == "Sunday")
                {
                    vals3 = ob.sunday(Data.docid);
                }
                else if (Button3.Text == "Monday")
                {
                    vals3 = ob.monday(Data.docid);
                }
                else if (Button3.Text == "Tuesday")
                {
                    vals3 = ob.tuesday(Data.docid);
                }
                else if (Button3.Text == "Wednesday")
                {
                    vals3 = ob.wednesday(Data.docid);


                }
                else if (Button3.Text == "Thursday")
                {
                    vals3 = ob.thursday(Data.docid);
                }
                else if (Button3.Text == "Friday")
                {
                    vals3 = ob.friday(Data.docid);
                }

                if (Button4.Text == "Saturday")
                {
                    vals4 = ob.saturday(Data.docid);
                }
                else if (Button4.Text == "Sunday")
                {
                    vals4 = ob.sunday(Data.docid);
                }
                else if (Button4.Text == "Monday")
                {
                    vals4 = ob.monday(Data.docid);
                }
                else if (Button4.Text == "Tuesday")
                {
                    vals4 = ob.tuesday(Data.docid);
                }
                else if (Button4.Text == "Wednesday")
                {
                    vals4 = ob.wednesday(Data.docid);
                }
                else if (Button4.Text == "Thursday")
                {
                    vals4 = ob.thursday(Data.docid);
                }
                else if (Button4.Text == "Friday")
                {
                    vals4 = ob.friday(Data.docid);
                }

                if (Button5.Text == "Saturday")
                {
                    vals5 = ob.saturday(Data.docid);
                }
                else if (Button5.Text == "Sunday")
                {
                    vals5 = ob.sunday(Data.docid);
                }
                else if (Button5.Text == "Monday")
                {
                    vals5 = ob.monday(Data.docid);


                }
                else if (Button5.Text == "Tuesday")
                {
                    vals5 = ob.tuesday(Data.docid);
                }
                else if (Button5.Text == "Wednesday")
                {
                    vals5 = ob.wednesday(Data.docid);
                }
                else if (Button5.Text == "Thursday")
                {
                    vals5 = ob.thursday(Data.docid);
                }
                else if (Button5.Text == "Friday")
                {
                    vals5 = ob.friday(Data.docid);
                }

                if (Button6.Text == "Saturday")
                {
                    vals6 = ob.saturday(Data.docid);
                }
                else if (Button6.Text == "Sunday")
                {
                    vals6 = ob.sunday(Data.docid);
                }
                else if (Button6.Text == "Monday")
                {
                    vals6 = ob.monday(Data.docid);
                }
                else if (Button6.Text == "Tuesday")
                {
                    vals6 = ob.tuesday(Data.docid);
                }
                else if (Button6.Text == "Wednesday")
                {
                    vals6 = ob.wednesday(Data.docid);
                }
                else if (Button6.Text == "Thursday")
                {
                    vals6 = ob.thursday(Data.docid);
                }
                else if (Button6.Text == "Friday")
                {
                    vals6 = ob.friday(Data.docid);
                }

                if (Button7.Text == "Saturday")
                {
                    vals7 = ob.saturday(Data.docid);
                }
                else if (Button7.Text == "Sunday")
                {
                    vals7 = ob.sunday(Data.docid);
                }
                else if (Button7.Text == "Monday")
                {
                    vals7 = ob.monday(Data.docid);
                }
                else if (Button7.Text == "Tuesday")
                {
                    vals7 = ob.tuesday(Data.docid);
                }
                else if (Button7.Text == "Wednesday")
                {
                    vals7 = ob.wednesday(Data.docid);
                }
                else if (Button7.Text == "Thursday")
                {
                    vals7 = ob.thursday(Data.docid);
                }
                else if (Button7.Text == "Friday")
                {
                    vals7 = ob.friday(Data.docid);
                }
                if (vals1 == 0)
                {
                    Button1.Text = Button1.Text + "(Closed)";
                    Button1.BackColor = Color.DarkGray;
                    Button1.Enabled = false;
                }
                else if (vals1 == 1)
                {

                }
                if (vals2 == 0)
                {
                    Button2.Text = Button2.Text + "(Closed)";
                    Button2.BackColor = Color.DarkGray;
                    Button2.Enabled = false;
                }
                else if (vals2 == 1)
                {

                }
                if (vals3 == 0)
                {
                    Button3.Text = Button3.Text + "(Closed)";
                    Button3.BackColor = Color.DarkGray;
                    Button3.Enabled = false;
                }
                else if (vals3 == 1)
                {

                }
                if (vals4 == 0)
                {
                    Button4.Text = Button4.Text + "(Closed)";
                    Button4.BackColor = Color.DarkGray;
                    Button4.Enabled = false;
                }
                else if (vals4 == 1)
                {

                }
                if (vals5 == 0)
                {
                    Button5.Text = Button5.Text + "(Closed)";
                    Button5.BackColor = Color.DarkGray;
                    Button5.Enabled = false;
                }
                else if (vals5 == 1)
                {

                }
                if (vals6 == 0)
                {
                    Button6.Text = Button6.Text + "(Closed)";
                    Button6.BackColor = Color.DarkGray;
                    Button6.Enabled = false;
                }
                else if (vals6 == 1)
                {
                }
                if (vals7 == 0)
                {
                    Button7.Text = Button7.Text + "(Closed)";
                    Button7.BackColor = Color.DarkGray;
                    Button7.Enabled = false;
                }
                else if (vals7 == 1)
                {

                }


                string oradb = "Data Source=localhost;User Id=system;Password=965720;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                //   Data ob = new Data();
              //  cmd.Connection = conn;
                cmd.CommandText = "select patientid from ECARE_APPOINTMENT where doctorid='" + Data.docid + "' and APPOINTMENTDATE='" + Data.day + "' and appointmentstatus=" + 0 + "";
                //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
                OracleDataReader dr = cmd.ExecuteReader(); int i = 0;
                while (dr.Read())
                {
                    string ids = dr.GetString(0);
                    string name = ob.getnamepatient(ids);
                    i++;

                    LinkButton Name = new LinkButton();
                    //  myLabel.Font.Size = FontUnit.XLarge;
                    Name.ForeColor = Color.BlueViolet;
                    Name.Text = name;
                    Name.ID = dr.GetString(0);
                    //      Name.Attributes.Add("runat", "server");
                    //   Name.C += new EventHandler(Dynamic_Click);
                    Name.Click += new EventHandler(Dynamic_Click);
                    Label Degree = new Label();
                    //  myLabels.CssClass = "style1";
                    Degree.Text = " has requested for an appointment on " + Data.day;
                    Degree.ID = dr.GetString(0) + i.ToString();
                    Degree.ForeColor = Color.Green;

                    Button Accept = new Button();
                    //  myLabels.CssClass = "style1";
                    Accept.Text = "Accept";
                    Accept.ID ="A"+ dr.GetString(0) ;
                    Accept.ForeColor = Color.ForestGreen;

                  
                    Button Ignore = new Button();
                    //  myLabels.CssClass = "style1";
                    Ignore.Text = "Ignore";
                    Ignore.ID ="I"+ dr.GetString(0);
                    Ignore.ForeColor = Color.Red;
                    Accept.Click += new EventHandler(Accept_Click);
                    Ignore.Click += new EventHandler(Ignore_Click);
                    DoctorSearchResultPlaceHolder.Controls.Add(Name);
                    DoctorSearchResultPlaceHolder.Controls.Add(Degree);
                    DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                    DoctorSearchResultPlaceHolder.Controls.Add(Accept);
                    DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("     "));
                    DoctorSearchResultPlaceHolder.Controls.Add(Ignore);
                    DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                    DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                    str.Controls.Add(DoctorSearchResultPlaceHolder);
                } conn.Dispose();
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientProfileView.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientProfileView.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientProfileView.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DoctorSearchResultPlaceHolder.Controls.Clear();
            str.Controls.Add(DoctorSearchResultPlaceHolder);
            Data.day = Button2.Text;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   Data ob = new Data();
            cmd.Connection = conn;
            cmd.CommandText = "select patientid from ECARE_APPOINTMENT where doctorid='" +Data.docid+ "' and APPOINTMENTDATE='" +Data.day+ "' and appointmentstatus=" +0+ "";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader(); int i = 0;
            while (dr.Read())
            {
                string ids = dr.GetString(0);
                string name = ob.getnamepatient(ids);
                i++;

                LinkButton Name = new LinkButton();
                //  myLabel.Font.Size = FontUnit.XLarge;
                Name.ForeColor = Color.BlueViolet;
                Name.Text = name;
                Name.ID = dr.GetString(0);
                //      Name.Attributes.Add("runat", "server");
                //   Name.C += new EventHandler(Dynamic_Click);
                Name.Click += new EventHandler(Dynamic_Click);
                Label Degree = new Label();
                //  myLabels.CssClass = "style1";
                Degree.Text = " has requested for an appointment on " + Data.day;
                Degree.ID = dr.GetString(0) + i.ToString()+"accept";
                Degree.ForeColor = Color.Green;

                Button Accept = new Button();
                //  myLabels.CssClass = "style1";
                Accept.Text = "Accept";
                Accept.ID = "A" + dr.GetString(0);
                Accept.BackColor = Color.ForestGreen;


                Button Ignore = new Button();
                //  myLabels.CssClass = "style1";
                Ignore.Text = "Ignore";
                Ignore.ID = "I" + dr.GetString(0);
                Ignore.BackColor = Color.Red;
                Accept.Click += new EventHandler(Accept_Click);
                Ignore.Click += new EventHandler(Ignore_Click);
                DoctorSearchResultPlaceHolder.Controls.Add(Name);
                DoctorSearchResultPlaceHolder.Controls.Add(Degree);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(Accept);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("     "));
                DoctorSearchResultPlaceHolder.Controls.Add(Ignore);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                str.Controls.Add(DoctorSearchResultPlaceHolder);
            } conn.Dispose();
        }

        protected void Button12_Click(object sender, EventArgs e)
        {

        }

        protected void Button13_Click(object sender, EventArgs e)
        {

        }

        protected void Button14_Click(object sender, EventArgs e)
        {

        }

        protected void Button15_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DoctorSearchResultPlaceHolder.Controls.Clear();
            str.Controls.Add(DoctorSearchResultPlaceHolder);
            Data.day = Button3.Text;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   Data ob = new Data();
            cmd.Connection = conn;
            cmd.CommandText = "select patientid from ECARE_APPOINTMENT where doctorid='" + Data.docid + "' and APPOINTMENTDATE='" + Data.day + "' and appointmentstatus=" + 0 + "";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader(); int i = 0;
            while (dr.Read())
            {
                string ids = dr.GetString(0);
                string name = ob.getnamepatient(ids);
                i++;

                LinkButton Name = new LinkButton();
                //  myLabel.Font.Size = FontUnit.XLarge;
                Name.ForeColor = Color.BlueViolet;
                Name.Text = name;
                Name.ID = dr.GetString(0);
                //      Name.Attributes.Add("runat", "server");
                //   Name.C += new EventHandler(Dynamic_Click);
                Name.Click += new EventHandler(Dynamic_Click);
                Label Degree = new Label();
                //  myLabels.CssClass = "style1";
                Degree.Text = " has requested for an appointment on " + Data.day;
                Degree.ID = dr.GetString(0) + i.ToString();
                Degree.ForeColor = Color.Green;
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
                DoctorSearchResultPlaceHolder.Controls.Add(Name);
                DoctorSearchResultPlaceHolder.Controls.Add(Degree);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(Accept);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("     "));
                DoctorSearchResultPlaceHolder.Controls.Add(Ignore);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                str.Controls.Add(DoctorSearchResultPlaceHolder);
            } conn.Dispose();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DoctorSearchResultPlaceHolder.Controls.Clear();
            str.Controls.Add(DoctorSearchResultPlaceHolder);
            Data.day = Button1.Text;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   Data ob = new Data();
            cmd.Connection = conn;
            cmd.CommandText = "select patientid from ECARE_APPOINTMENT where doctorid='" + Data.docid + "' and APPOINTMENTDATE='" + Data.day + "' and appointmentstatus=" + 0 + "";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader(); int i = 0;
            while (dr.Read())
            {
                string ids = dr.GetString(0);
                string name = ob.getnamepatient(ids);
                i++;

                LinkButton Name = new LinkButton();
                //  myLabel.Font.Size = FontUnit.XLarge;
                Name.ForeColor = Color.BlueViolet;
                Name.Text = name;
                Name.ID = dr.GetString(0);
                //      Name.Attributes.Add("runat", "server");
                //   Name.C += new EventHandler(Dynamic_Click);
                Name.Click += new EventHandler(Dynamic_Click);
                Label Degree = new Label();
                //  myLabels.CssClass = "style1";
                Degree.Text = " has requested for an appointment on " + Data.day;
                Degree.ID = dr.GetString(0) + i.ToString();
                Degree.ForeColor = Color.Green;

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
                DoctorSearchResultPlaceHolder.Controls.Add(Name);
                DoctorSearchResultPlaceHolder.Controls.Add(Degree);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(Accept);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("     "));
                DoctorSearchResultPlaceHolder.Controls.Add(Ignore);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                str.Controls.Add(DoctorSearchResultPlaceHolder);
            } //conn.Dispose();
          // Response.Redirect("PatientProfileView.aspx");
        }

       
        protected void Button5_Click(object sender, EventArgs e)
        {
            DoctorSearchResultPlaceHolder.Controls.Clear();
            str.Controls.Add(DoctorSearchResultPlaceHolder);
            Data.day = Button5.Text;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   Data ob = new Data();
            cmd.Connection = conn;
            cmd.CommandText = "select patientid from ECARE_APPOINTMENT where doctorid='" + Data.docid + "' and APPOINTMENTDATE='" + Data.day + "' and appointmentstatus=" + 0 + "";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader(); int i = 0;
            while (dr.Read())
            {
                string ids = dr.GetString(0);
                string name = ob.getnamepatient(ids);
                i++;

                LinkButton Name = new LinkButton();
                //  myLabel.Font.Size = FontUnit.XLarge;
                Name.ForeColor = Color.BlueViolet;
                Name.Text = name;
                Name.ID = dr.GetString(0);
                //      Name.Attributes.Add("runat", "server");
                //   Name.C += new EventHandler(Dynamic_Click);
                Name.Click += new EventHandler(Dynamic_Click);
                Label Degree = new Label();
                //  myLabels.CssClass = "style1";
                Degree.Text = " has requested for an appointment on " + Data.day;
                Degree.ID = dr.GetString(0) + i.ToString();
                Degree.ForeColor = Color.Green;

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
                DoctorSearchResultPlaceHolder.Controls.Add(Name);
                DoctorSearchResultPlaceHolder.Controls.Add(Degree);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(Accept);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("     "));
                DoctorSearchResultPlaceHolder.Controls.Add(Ignore);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                str.Controls.Add(DoctorSearchResultPlaceHolder);
            } conn.Dispose();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            DoctorSearchResultPlaceHolder.Controls.Clear();
            str.Controls.Add(DoctorSearchResultPlaceHolder);
            Data.day = Button6.Text;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   Data ob = new Data();
            cmd.Connection = conn;
            cmd.CommandText = "select patientid from ECARE_APPOINTMENT where doctorid='" + Data.docid + "' and APPOINTMENTDATE='" + Data.day + "' and appointmentstatus=" + 0 + "";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader(); int i = 0;
            while (dr.Read())
            {
                string ids = dr.GetString(0);
                string name = ob.getnamepatient(ids);
                i++;

                LinkButton Name = new LinkButton();
                //  myLabel.Font.Size = FontUnit.XLarge;
                Name.ForeColor = Color.BlueViolet;
                Name.Text = name;
                Name.ID = dr.GetString(0);
                //      Name.Attributes.Add("runat", "server");
                //   Name.C += new EventHandler(Dynamic_Click);
                Name.Click += new EventHandler(Dynamic_Click);
                Label Degree = new Label();
                //  myLabels.CssClass = "style1";
                Degree.Text = " has requested for an appointment on " + Data.day;
                Degree.ID = dr.GetString(0) + i.ToString();
                Degree.ForeColor = Color.Green;

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
                DoctorSearchResultPlaceHolder.Controls.Add(Name);
                DoctorSearchResultPlaceHolder.Controls.Add(Degree);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(Accept);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("     "));
                DoctorSearchResultPlaceHolder.Controls.Add(Ignore);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                str.Controls.Add(DoctorSearchResultPlaceHolder);
            }
            conn.Dispose();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            DoctorSearchResultPlaceHolder.Controls.Clear();
            str.Controls.Add(DoctorSearchResultPlaceHolder);
            Data.day = Button7.Text;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   Data ob = new Data();
            cmd.Connection = conn;
            cmd.CommandText = "select patientid from ECARE_APPOINTMENT where doctorid='" + Data.docid + "' and APPOINTMENTDATE='" + Data.day + "' and appointmentstatus=" + 0 + "";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader(); int i = 0;
            while (dr.Read())
            {
                string ids = dr.GetString(0);
                string name = ob.getnamepatient(ids);
                i++;

                LinkButton Name = new LinkButton();
                //  myLabel.Font.Size = FontUnit.XLarge;
                Name.ForeColor = Color.BlueViolet;
                Name.Text = name;
                Name.ID = dr.GetString(0);
                //      Name.Attributes.Add("runat", "server");
                //   Name.C += new EventHandler(Dynamic_Click);
                Name.Click += new EventHandler(Dynamic_Click);
                Label Degree = new Label();
                //  myLabels.CssClass = "style1";
                Degree.Text = " has requested for an appointment on " + Data.day;
                Degree.ID = dr.GetString(0) + i.ToString();
                Degree.ForeColor = Color.Green;

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
                DoctorSearchResultPlaceHolder.Controls.Add(Name);
                DoctorSearchResultPlaceHolder.Controls.Add(Degree);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(Accept);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("     "));
                DoctorSearchResultPlaceHolder.Controls.Add(Ignore);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                str.Controls.Add(DoctorSearchResultPlaceHolder);
            } conn.Dispose();
        }
        protected void Button4_Click(object sender, System.EventArgs e)
        {
            DoctorSearchResultPlaceHolder.Controls.Clear();
            str.Controls.Add(DoctorSearchResultPlaceHolder);
            Data.day = Button4.Text;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   Data ob = new Data();
            cmd.Connection = conn;
            cmd.CommandText = "select patientid from ECARE_APPOINTMENT where doctorid='" + Data.docid + "' and APPOINTMENTDATE='" + Data.day + "' and appointmentstatus=" + 0 + "";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader(); int i = 0;
            while (dr.Read())
            {
                string ids = dr.GetString(0);
                string name = ob.getnamepatient(ids);
                i++;

                LinkButton Name = new LinkButton();
                //  myLabel.Font.Size = FontUnit.XLarge;
                Name.ForeColor = Color.BlueViolet;
                Name.Text = name;
                Name.ID = dr.GetString(0);
                //      Name.Attributes.Add("runat", "server");
                //   Name.C += new EventHandler(Dynamic_Click);
                Name.Click += new EventHandler(Dynamic_Click);
                Label Degree = new Label();
                //  myLabels.CssClass = "style1";
                Degree.Text = " has requested for an appointment on " + DateTime.Now.AddDays(0).DayOfWeek.ToString(); ;
                Degree.ID = dr.GetString(0) + i.ToString();
                Degree.ForeColor = Color.Green;

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
                DoctorSearchResultPlaceHolder.Controls.Add(Name);
                DoctorSearchResultPlaceHolder.Controls.Add(Degree);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(Accept);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("     "));
                DoctorSearchResultPlaceHolder.Controls.Add(Ignore);
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                str.Controls.Add(DoctorSearchResultPlaceHolder);
            }
        }
        protected void Dynamic_Click(object sender, EventArgs e)
        {
            LinkButton lss = (LinkButton)sender;
            Data.pid = lss.ID;
           Response.Redirect("PatientProfileView.aspx");
        }
        
        protected void Accept_Click(object sender, EventArgs e)
        {
           Button lss = (Button)sender;
           string s;
           Data.pid = "";
           s = lss.ID; int j = 0;
            for(int i=1;i<s.Length;i++)
            {
                Data.pid += s[i];
            }
           

            lss.Text = "Blue";
            lss.BackColor = Color.Violet;
            lss.ForeColor = Color.Black;
            string cons = ob.countnotifications(Data.pid);
            string docname = ob.getdocname(Data.docid);
            string message = docname + " has accepted ur appointment on " + Data.day + "   \n" ;
            ob.insertnotifications(cons, Data.pid, Data.docid,message,DateTime.Now.AddDays(0).ToString("m"));
              ob.updateappointment(Data.day,Data.docid,Data.pid,1);
              this.Page_Load(null, null);

         //   Response.Redirect("PatientProfileView.aspx");
         //   Response.Redirect("PatientProfileView.aspx");
        }
        protected void Ignore_Click(object sender, EventArgs e)
        {
            Button lss = (Button)sender;
            string s;
            Data.pid = "";
            s = lss.ID; int j = 0;
            for (int i = 1; i < s.Length; i++)
            {
                Data.pid += s[i];
            }
           // Response.Redirect("PatientProfileView.aspx");
          //  Response.Redirect("PatientProfileView.aspx");
        }

        
        }
    }
