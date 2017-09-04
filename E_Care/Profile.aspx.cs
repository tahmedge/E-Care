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
    public partial class Profile : System.Web.UI.Page
    {
        
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            test ob = new test();
            TextBox4.Text = test.id;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, System.EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, System.EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, System.EventArgs e)
        {

        }

        protected void Button3_Click(object sender, System.EventArgs e)
        {
            test ob = new test();
            TextBox4.Text = test.id;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select sex from wwe where name='" + test.id + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            OracleString firstVariable;
            firstVariable = dr.GetOracleString(0);
            TextBox5.Text = firstVariable.ToString();
        }

        protected void Page_Load(object sender, System.EventArgs e)
        {
            test ob = new test();
            TextBox4.Text = test.id;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select sex from wwe where name='" + test.id + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            OracleString firstVariable;
            firstVariable = dr.GetOracleString(0);
            TextBox5.Text = firstVariable.ToString();
        }
    }
}