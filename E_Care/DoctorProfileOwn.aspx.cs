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
    public partial class DoctorProfileOwn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //911904128 - Copy.jpg
            Image1.ImageUrl = "~/"+Data.docid+".jpg";
            Data obs = new Data();
            int vv = obs.verifyuser(Data.docid, "0", 1);
            if (vv == 1) Label23.Text = "Verified Doctor";
            StatusLabel.Text = "";
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
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            Data ob = new Data();
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


            //    cmd.CommandText = "select saturday,sunday,monday,tuesday,wednesday,thursday,friday from ecare_doctor where id='" + Data.docid + "'";
            //       cmd.CommandType = CommandType.Text;
            //  OracleDataReader ds = cmd.ExecuteReader();

            cmd.CommandText = "select fullname,degree,speciality,workingon,chamberaddress,contactnumber from ecare_doctor where id='" + Data.docid + "'";
            //       cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            //

            int i = 0;
            while (dr.Read())
            {
                // if(i>0)
                //   stf.InnerHtml = "<hr>";
                i++;


                Labelname.Text = dr.GetString(0);
                Labeldegree.Text = dr.GetString(1);
                Labelspeciality.Text = dr.GetString(2);
                Labelworkingon.Text = dr.GetString(3);
                Labelchamberaddress.Text = dr.GetString(4);
                Labelcontactnumber.Text = dr.GetString(5);
              
            }
           
            cmd.CommandText = "select workingtimestart,workingtimeend from ecare_appointmentinfo where id='" + Data.docid + "'";
            OracleDataReader drr = cmd.ExecuteReader();
            drr.Read();
            Label1.Text = "(My Practice Hours: " + drr.GetString(0) + " to " + drr.GetString(1)+")";
            conn.Dispose();
        }
        protected void UploadButton_Click(object sender, System.EventArgs e)
        {
            if (FileUploadControl.HasFile)
            {
                try
                {
                    if (FileUploadControl.PostedFile.ContentType == "image/jpeg")
                    {
                        if (FileUploadControl.PostedFile.ContentLength < 100002400)
                        {
                            string filename = Data.docid + ".jpg";
                            FileUploadControl.SaveAs(Server.MapPath("~/") + filename);
                            StatusLabel.Text = "Upload status: File uploaded!";
                            this.Page_Load(null, null);

                        }
                        else
                            StatusLabel.Text = "Upload status: The file has to be less than 100 kb!";
                    }
                    else
                        StatusLabel.Text = "Upload status: Only JPG files are accepted!";
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("MessageInboxList.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
        Response.Redirect("PrescriptionSend.aspx");
            //Response.Redirect("ArticleList.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientVerification.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Data.day = Button1.Text;
            Response.Redirect("AppointmentRequestList.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Data.day = Button2.Text;
            Response.Redirect("AppointmentRequestList.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Data.day = Button3.Text;
            Response.Redirect("AppointmentRequestList.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Data.day = Button4.Text;
            Response.Redirect("AppointmentRequestList.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Data.day = Button5.Text;
            Response.Redirect("AppointmentRequestList.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Data.day = Button6.Text;
            Response.Redirect("AppointmentRequestList.aspx");
        }

        protected void Button7_Click(object sender, System.EventArgs e)
        {
            Data.day = Button7.Text;
            Response.Redirect("AppointmentRequestList.aspx");
        }
    }
}