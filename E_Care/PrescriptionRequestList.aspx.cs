﻿using System;
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
    public partial class PrescriptionRequestList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id,doctorid,patientid,doctorname from ecare_prescription where patientid='" + Data.pid + "' and status="+0+"";
            OracleDataReader dr = cmd.ExecuteReader();
          //  conn.Dispose();
            while (dr.Read())
            {
           
                string id = dr.GetString(1);
                string name = dr.GetString(3);
     

                int i = 0;
           //     while (drr.Read())
                {
                    // if(i>0)
                    //   stf.InnerHtml = "<hr>";
                    i++;


                    LinkButton Name = new LinkButton();
                    //  myLabel.Font.Size = FontUnit.XLarge;
                    Name.ForeColor = Color.BlueViolet;
                    Name.Text = dr.GetString(3)+" "+"has sent you a new prescription";
                    Name.ID = dr.GetString(0);
                    //      Name.Attributes.Add("runat", "server");
                    //   Name.C += new EventHandler(Dynamic_Click);
                    Name.Click += new EventHandler(Dynamic_Click);
                    

                    //  myLabels.CssClass = "style1";
               
                    DoctorSearchResultPlaceHolder.Controls.Add(Name);
                 
                    DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<br/>"));
                    DoctorSearchResultPlaceHolder.Controls.Add(new LiteralControl("<hr>"));
                    str.Controls.Add(DoctorSearchResultPlaceHolder);

                }
            }           //
            conn.Dispose();
        }

        protected void Dynamic_Click(object sender, EventArgs e)
        {
            LinkButton lss = (LinkButton)sender;
            Data.presid = lss.ID;
            Response.Redirect("PrescriptionDetails.aspx");
        }
    }
}