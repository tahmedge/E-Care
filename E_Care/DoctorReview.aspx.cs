using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Care
{
    public partial class DoctorReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
                protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox1.Text + " " + TextBox2.Text;
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
        
    
}
}