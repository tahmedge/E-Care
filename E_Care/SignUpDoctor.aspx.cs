using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Care
{
    public partial class SignUpDoctor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        protected void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox13_TextChanged(object sender, EventArgs e)
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

        protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
               Data ob = new Data();
           if (TextBox_Fullname.Text == "" || TextBox_Username.Text == "" || TextBox_Password.Text == "" || TextBox_Confirmpassword.Text == "" ||
              TextBox_Contactnumber.Text == "" || TextBox_Email.Text == "" || TextBox_Chamberaddress.Text == "" ||
              TextBox_Workingon.Text == "" || TextBox_Workingas.Text == "" || TextBox_Contactnumber.Text == ""
              || TextBox_Timestart.Text == "" || TextBox_Timeend.Text == "" || TextBox_Contactnumber.Text == "" ||TextBox_ReferenceBy.Text=="")
            {
                MessageBox.ShowMessage("Please fill in all the boxes!", this.Page);
            }
           else if(CheckBox_Assistant.Checked==true&&(TextBox_Assistantpassword.Text == "" || TextBox_Assistantconfirmpassword.Text == ""))
            {
            
                     MessageBox.ShowMessage("Please fill in all the boxes!", this.Page);
                
            }
            else if(CheckBox_Termsandcondition.Checked==false)
            {
                MessageBox.ShowMessage("You must agree terms and condition of E-Care!", this.Page);
            }
           else if (TextBox_Password.Text != TextBox_Confirmpassword.Text)
           {
               MessageBox.ShowMessage("User Password did not match!", this.Page);
           }
           else if (CheckBox_Assistant.Checked == true && (TextBox_Assistantpassword.Text != TextBox_Assistantconfirmpassword.Text))
           {

               MessageBox.ShowMessage("Assistant Password did not match!", this.Page);

           }
           else if(ob.checkuser(TextBox_Username.Text)==1)
           {
               MessageBox.ShowMessage("Username already exists!", this.Page);
           }
           else if (ob.checkemail(TextBox_Email.Text)==1)
           {
               MessageBox.ShowMessage("Email already exists!", this.Page);
           }
           else if(ob.checkuser(TextBox_ReferenceBy.Text)==0)
           {
               MessageBox.ShowMessage("There are no doctor in E-CARE to be referenced with that username!", this.Page);
           }
           else
           {
               string referenceid = ob.getdocidreference(TextBox_ReferenceBy.Text);
            
               int count = ob.getid();
               string id = count.ToString();
               ob.insertuser(id, TextBox_Email.Text, TextBox_Password.Text, TextBox_Username.Text,  0);
               ob.insertuserverification(id, referenceid, 0);
               int cntyp = 0;
               string sex = "Male";
               if (RadioButton4.Checked == true)
                   sex = "Female";
               string district = DropDownListDistrict.SelectedItem.Value;
               string fee = DropDownList3.SelectedItem.Value;
           //    if (CheckBox_Contactnumber.Checked == true)
                   cntyp = 1;
               
               string speciality=DropDownListSpeciality.SelectedItem.Value;
               string workingon=TextBox_Workingon.Text;
               string workingas=TextBox_Workingas.Text;
               string degree=TextBox_Degree.Text;
               string chamberaddress=TextBox_Chamberaddress.Text;
               string contactnumber=TextBox_Contactnumber.Text;
               string workingtimestart=TextBox_Timestart.Text;
               string workingtimeend=TextBox_Timeend.Text;
               //         insertpatient(string id, string bloodgroup, string district, string sex,string birthdate, string contactnumber)

              // ob.insertpatient(id, bloodgroup, district, sex, textbox_born_in.Text, textbox_contactnumber.Text, cntyp);
           //   district = DropDownListDistrict.SelectedItem.Value;
               ob.insertdoctor(id, TextBox_Fullname.Text, speciality, workingon, workingas, degree,district, chamberaddress, contactnumber, cntyp, sex);
               int sunday = 0, monday = 0, tuesday = 0, wednesday = 0, thursday = 0, friday = 0, saturday = 0;
               if (CheckBox_Saturday.Checked == true) saturday = 1;
               if (CheckBox_Sunday.Checked == true) saturday = 1;
               if (CheckBox_Monday.Checked == true) saturday = 1;
               if (CheckBox_Tuesday.Checked == true) saturday = 1;
               if (CheckBox_Wednesday.Checked == true) saturday = 1;
               if (CheckBox_Thursday.Checked == true) saturday = 1;
               if (CheckBox_Friday.Checked == true) saturday = 1;
               int limit = Convert.ToInt32(TextBox_Appointmentlimit.Text);
               if (CheckBox_Assistant.Checked == true)
               {
                   ob.insertassistant(id, TextBox_Assistantpassword.Text,TextBox_Email.Text);
               }
               int appointmentsystem=1;
               if (RadioButton1.Checked == true) appointmentsystem = 1;
               else appointmentsystem = 0;
               ob.insertappointmentinfo(id, workingtimestart, workingtimeend, limit, saturday, sunday, monday, tuesday, wednesday, thursday, friday,appointmentsystem);

               MessageBox.ShowMessage("Account Created Succesfully!", this.Page);
               Response.Redirect("IntroPage.aspx");
           }
            /* 
         else if (CheckBox3.Checked == false)
         {
             MessageBox.ShowMessage("U must agree terms and conditions of E-Care!", this.Page);
         }
         else if (textbox_password.Text != textbox_confirmpassword.Text)
         {
             MessageBox.ShowMessage("Password did not match!", this.Page);
         }
         else
         {
             Data ob = new Data();
             int count = ob.getid();
             string id = count.ToString();
             ob.insertuser(id, textbox_email.Text, textbox_password.Text, textbox_username.Text, textbox_fullname.Text, 0);
             int cntyp = 0;
             string sex = "Male";
             if (RadioButton2.Checked == true)
                 sex = "Female";
             string district = DropDownList2.SelectedItem.Value;
             string bloodgroup = DropDownList3.SelectedItem.Value;
             if (CheckBox1.Checked == true)
                 cntyp = 1;
             //         insertpatient(string id, string bloodgroup, string district, string sex,string birthdate, string contactnumber)

             ob.insertpatient(id, bloodgroup, district, sex, textbox_born_in.Text, textbox_contactnumber.Text, cntyp);
         }*/

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox_Chamberaddress_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox_Timestart_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox_Timeend_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox_Assistant_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox_Assistant.Checked==true)
            {
                Label20.Visible = true;
                Label21.Visible = true;
                TextBox_Assistantpassword.Visible = true;
                TextBox_Assistantconfirmpassword.Visible = true;
            }
            else
            {
                Label20.Visible = false;
                Label21.Visible = false;
                TextBox_Assistantpassword.Visible = false;
                TextBox_Assistantconfirmpassword.Visible = false;
            }

        }

        protected void TextBox_14(object sender, EventArgs e)
        {

        }

        protected void CheckBox_Contactnumber_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox_Emailnotifications_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox_Termsandcondition_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}