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
using System.IO;

namespace E_Care
{
    public partial class test : System.Web.UI.Page
    {
        string name;
        public static string id = "asd";
        protected void Page_Load(object sender, EventArgs e)
        {
      /*      Button2.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            Label1.Text = DateTime.Now.AddDays(1).ToString("m");
            //  cmd.CommandText = "select count(name) from wwe";
            //  cmd.CommandType = CommandType.Text;
            // OracleDataReader dr = cmd.ExecuteReader();
            // Int64 count = Convert.ToInt64(cmd.ExecuteScalar());
            //  OracleCommand cmd = new OracleCommand();
            //  cmd.CommandText = "select count(name) from wwe";
            //  cmd.CommandType = CommandType.Text;
            //  OracleDataReader dr = cmd.ExecuteReader();
            //  count++;
        //    try
          //  {
          /*      string oradb = "Data Source=localhost;User Id=system;Password=965720;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from ecare_user";
         //       cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                //

                int i = 0;
                while (dr.Read())
                {
                   // if(i>0)
                 //   stf.InnerHtml = "<hr>";
                    i++;
                    //  TextBox1.Text = firstVariable.ToString();
                    //  _items.Add(firstVariable.ToString());
                    /*   }
                       for (int i = 0; i < count; i++)
                       { */
                    /*
                    OracleString firstVariable;
                    firstVariable = dr.GetOracleString(0);
                    System.Web.UI.HtmlControls.HtmlGenericControl createDiv =
                     new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    createDiv.ID = "createDiv" + i.ToString();
                    createDiv.Style.Add(HtmlTextWriterStyle.BackgroundColor, "ghostwhite");
                    createDiv.Style.Add(HtmlTextWriterStyle.Color, "black");
                    createDiv.Style.Add(HtmlTextWriterStyle.TextAlign, "center");
                    createDiv.Style.Add(HtmlTextWriterStyle.VerticalAlign, "middle");
                    createDiv.Style.Add(HtmlTextWriterStyle.MarginLeft, "35%");
                    createDiv.Style.Add(HtmlTextWriterStyle.MarginRight, "25%");
                    createDiv.Style.Add(HtmlTextWriterStyle.VerticalAlign, "middle");
                    createDiv.Style.Add(HtmlTextWriterStyle.Height, "100px");
                    createDiv.Style.Add(HtmlTextWriterStyle.Width, "400px");
                   createDiv.InnerHtml = "Araf farayez is awesome<br>";
              //      createDiv.InnerHtml += "araf farayez is genius<hr/>";
                    LinkButton ls = new LinkButton();
                    //  ls.ForeColor = ;
                    ls.ForeColor = Color.Green;
                    ls.ID = firstVariable.ToString();
                    ls.Click += new EventHandler(this.btn_Click);
                    ls.Text = ls.ID;
                    createDiv.Controls.Add(ls);
                    stf.Controls.Add(createDiv);
                 //   stf.InnerHtml="<hr>";
                    TextBox3.Text = ls.ID;
                    */

         /*           Label myLabel = new Label();
                    myLabel.Font.Size = FontUnit.XLarge;  
                    // Set the label's Text and ID properties.
                    myLabel.Text = dr.GetString(0);
                    myLabel.ID = dr.GetString(0) +i.ToString();
                    Label myLabels = new Label();
                    myLabels.CssClass = "style1";
                    myLabels.Text = dr.GetString(1);
                    myLabels.ID = dr.GetString(1) +i.ToString();
                    Label myLabelss = new Label();
                    myLabelss.Font.Size = FontUnit.XLarge;
                    // Set the label's Text and ID properties.
                    myLabelss.Text = dr.GetString(2);
                    myLabelss.ID = dr.GetString(2) + i.ToString();
                    Label myLabelsss = new Label();
                    myLabelsss.CssClass = "style1";
                    myLabelsss.Text = dr.GetString(3);
                    myLabelsss.ID = dr.GetString(3) + i.ToString();
                    Label myLabelssss = new Label();
                    myLabelssss.Font.Size = FontUnit.XLarge;
                    // Set the label's Text and ID properties.
                  //  myLabelssss.Text = dr.GetString(4);
                  //  myLabelssss.ID = dr.GetString(4) + i.ToString();
                
               //     myLabels.Style("Position") = "100px";
                    PlaceHolder1.Controls.Add(myLabel);
                    PlaceHolder1.Controls.Add(new LiteralControl("<br/>"));
                    PlaceHolder1.Controls.Add(myLabels);
                    PlaceHolder1.Controls.Add(new LiteralControl("<br/>"));
                    PlaceHolder1.Controls.Add(myLabelss);
                    PlaceHolder1.Controls.Add(new LiteralControl("<br/>"));
                    PlaceHolder1.Controls.Add(myLabelsss);
                    PlaceHolder1.Controls.Add(new LiteralControl("<br/>"));
                  //  PlaceHolder1.Controls.Add(myLabelssss);
                    PlaceHolder1.Controls.Add(new LiteralControl("<br/>"));
              
                   // PlaceHolder1.Controls.AddAt
                    // Add a spacer in the form of an HTML <br /> element.
                    PlaceHolder1.Controls.Add(new LiteralControl("<hr>"));
                    stf.Controls.Add(PlaceHolder1);*/
                   // DoctorSearchResult ob = new DoctorSearchResult();
                 //   ob.DoctorSearchResultPlaceHolder.Controls.Add(myLabel);
           
           // catch (Exception ex)
            //{ }*
        }
      
        protected void btn_Click(object sender, EventArgs e)
        {
         /*   System.Web.UI.HtmlControls.HtmlGenericControl dynDiv =
            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
            dynDiv.ID = "dynDivCode";
            dynDiv.Style.Add(HtmlTextWriterStyle.BackgroundColor, "Gray");
            dynDiv.Style.Add(HtmlTextWriterStyle.Height, "20px");
            dynDiv.Style.Add(HtmlTextWriterStyle.Width, "300px");
            dynDiv.Controls.Add(Button);
            dynDiv.InnerHtml = "I was created using Code Behind";
          *
            this.Controls.Add(dynDiv); */
            
      //      name = this.ID;
            LinkButton lss = (LinkButton)sender ;
        //    ls.ID = i.ToString();
  //          TextBox3.Text = lss.ID;
            id = lss.ID;

          Response.Redirect("Profile.aspx"); // opening new page !!!!!

        }

 
        private void CreateDiv(string divId)
        {
          
        }

      
        protected void LinkButton1_Click1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          

        }

        protected void Button1_Click2(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Data ob = new Data();
          //  ob.insertuser("1", "tahmid", "tahmid rahman", "tahmedge@yahoocom", "01737847721","123213", 1);
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

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
                            string filename =Data.docid+".jpg";
                            FileUploadControl.SaveAs(Server.MapPath("~/") + filename);
                            StatusLabel.Text = "Upload status: File uploaded!";
                            
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
       
    }
}