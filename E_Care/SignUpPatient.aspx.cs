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
    public partial class SignUpPatient : System.Web.UI.Page
    {
        string uname, fullname, birthdate, contactnumber, email, password, confirmpassword, district, division, bloddgroup, yyyy,sex;
        int flag = 0;
        int terms = 0;
         
        protected void Page_Load(object sender, EventArgs e)
        {
            //yyyy = DropDownList1.SelectedValue;
       //     textbox_born_in.Text = yyyy;
        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
         
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
         //   yyyy = DropDownList1.SelectedValue;
        //    textbox_born_in.Text = yyyy;
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
         //   yyyy = DropDownList1.SelectedValue;
          //  textbox_born_in.Text = yyyy;
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, System.EventArgs e)
        {
            //string s = ;
            if(textbox_fullname.Text==""||textbox_username.Text==""||textbox_password.Text==""||textbox_confirmpassword.Text==""||
                textbox_contactnumber.Text==""||textbox_email.Text==""||textbox_born_in.Text=="")
            {
                MessageBox.ShowMessage("Please fill in all the boxes!", this.Page); 
            }
            else if (CheckBox3.Checked == false)
            {
                MessageBox.ShowMessage("U must agree terms and conditions of E-Care!", this.Page);
            }
            else if(textbox_password.Text!=textbox_confirmpassword.Text)
            {
                MessageBox.ShowMessage("Password did not match!", this.Page);
            }
            else
            {
                Data ob=new Data();
                int count=ob.getid();
                string id=count.ToString();
                ob.insertuser(id, textbox_email.Text, textbox_password.Text, textbox_username.Text, 1);
                int cntyp = 0;
                string sex="Male";
                if(RadioButton2.Checked==true)
                    sex="Female";
                string district=DropDownList2.SelectedItem.Value;
                string bloodgroup=DropDownList3.SelectedItem.Value;
                if(CheckBox1.Checked == true)
                    cntyp=1;
       //         insertpatient(string id, string bloodgroup, string district, string sex,string birthdate, string contactnumber)

                ob.insertpatient(id, textbox_fullname.Text, bloodgroup, district, sex, textbox_born_in.Text, textbox_contactnumber.Text, cntyp);
                MessageBox.ShowMessage("Account Created Succesfully!", this.Page);
                Response.Redirect("IntroPage.aspx");
            }
        }
    }
}