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
    public partial class EditDoctorInformation : System.Web.UI.Page
    {
        string password = "";
        int sun = 0, mon = 0, tue = 0, wed = 0, thurs = 0, fri = 0, sat = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //    Data.searchspeciality = DropDownList1.SelectedItem.Value;
            //    Data.searchdistrict = DropDownList2.SelectedItem.Value;
            cmd.CommandText = "select email,password from ecare_user where id='"+Data.docid+"'";
            //       cmd.CommandType = CommandType.Text;
            OracleDataReader user = cmd.ExecuteReader();
            user.Read();
            TextBox_Email.Text = user.GetString(0);
            TextBox_Password.Text = user.GetString(1);
            TextBox_Confirmpassword.Text = user.GetString(1);
            password = user.GetString(1);
         //   conn.Dispose();
            cmd.CommandText = "select fullname,speciality,workingon,workingas,degree,district,chamberaddress,contactnumber from ecare_doctor where id='" + Data.docid + "'";
            //       cmd.CommandType = CommandType.Text;
            OracleDataReader doc = cmd.ExecuteReader();
            doc.Read();
            TextBox_Fullname.Text = doc.GetString(0);
            TextBox_Workingon.Text = doc.GetString(2);
            TextBox_Workingas.Text = doc.GetString(3);
            TextBox_Degree.Text = doc.GetString(4);
            TextBox_Chamberaddress.Text = doc.GetString(6);
            TextBox_Contactnumber.Text = doc.GetString(7);
            DropDownListSpeciality.SelectedValue = doc.GetString(1);
            DropDownListDistrict.SelectedValue = doc.GetString(5);

           // conn.Dispose();
            /*
             * CREATE TABLE ECARE_APPOINTMENTINFO(
	ID VARCHAR2(36),
	WORKINGTIMESTART VARCHAR2(19),
     WORKINGTIMEEND VARCHAR2(19),
	APPOINTMENTLIMIT NUMBER(3),
	SATURDAY NUMBER(2),
	SUNDAY NUMBER(2),
	MONDAY NUMBER(2),
	TUESDAY NUMBER(2),
	WEDNESDAY NUMBER(2),
	THURSDAY NUMBER(2),
	FRIDAY NUMBER(2),
     APPOINTMENTSYSTEM NUMBER(2) */
            doc.Read();

               cmd.CommandText = "select monday,tuesday,wednesday,thursday,friday,saturday,sunday from ecare_appointmentinfo where id='" + Data.docid + "'";
               cmd.CommandType = CommandType.Text;
               OracleDataReader appointmentinfo = cmd.ExecuteReader();
               appointmentinfo.Read();
  
               if ((appointmentinfo.GetInt32(0)) == 1)
               {
                   mon = 1;
                   CheckBox_Monday.Checked = true;
               }
               else
               {
                   mon = 0;
                   CheckBox_Monday.Checked = false;
               }
               if ((appointmentinfo.GetInt32(1)) == 1)
               {
                   tue = 1;
                   CheckBox_Tuesday.Checked = true;
               }
               else
               { CheckBox_Tuesday.Checked = false; tue = 0; }
               if ((appointmentinfo.GetInt32(2)) == 1)
               {
                   wed = 1;
                   CheckBox_Wednesday.Checked = true;
               }
               else
               {
                   CheckBox_Wednesday.Checked = false;
                   wed = 0;
               }

               if ((appointmentinfo.GetInt32(3)) == 1)
               {
                   CheckBox_Thursday.Checked = true;
                   thurs = 1;
               }
               else
               {
                   CheckBox_Thursday.Checked = false;
                   thurs = 0;
               }
               if ((appointmentinfo.GetInt32(4)) == 1)
               {
                   fri = 1;
                   CheckBox_Friday.Checked = true;
               }
               else
               {
                   CheckBox_Friday.Checked = false;
                   fri = 0;
               }
               if ((appointmentinfo.GetInt32(5)) == 1)
               {
                   sat = 1;
                   CheckBox_Saturday.Checked = true;
               }
               else
               {
                   sat = 0;
                   CheckBox_Saturday.Checked = false;
               }
               if ((appointmentinfo.GetInt32(6)) == 1)
               {
                   sun = 1;
                   CheckBox_Sunday.Checked = true;
               }
               else
               {
                   CheckBox_Sunday.Checked = false;
                   sun = 0;
               }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox_Chamberaddress_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox_Timeend_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox_Timestart_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox_Wednesday_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox_Appointmentlimit_TextChanged(object sender, EventArgs e)
        {

        }



        protected void TextBox_14(object sender, EventArgs e)
        {

        }

        protected void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox_Emailnotifications_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox_Termsandcondition_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Data ob = new Data();
            int val = 1;
            if (RadioButton1.Checked == true) val = 1;
            else val = 0;
            if(TextBox_Password.Text==TextBox_Confirmpassword.Text)
            { 
            ob.updateappointmentinfo(Data.docid,mon,tue,wed,thurs,fri,sat,sun,val);
            ob.updatedoctor(Data.docid,TextBox_Fullname.Text,DropDownListSpeciality.SelectedValue,TextBox_Workingon.Text,TextBox_Workingas.Text,
            TextBox_Degree.Text,DropDownListDistrict.SelectedValue,TextBox_Chamberaddress.Text,TextBox_Contactnumber.Text);
            ob.updateuser(Data.docid,TextBox_Email.Text,TextBox_Password.Text);
            MessageBox.ShowMessage("Saved Changes Succesfully!", this.Page);
            Response.Redirect("DoctorProfileOwn.aspx");
            }
            else
            {
                MessageBox.ShowMessage("Password Filled did not match!", this.Page);
            }
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}