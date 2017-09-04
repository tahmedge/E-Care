<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WriteArticle.aspx.cs" inherits="E_Care.WriteArticle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head id="Head1" runat="server">
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
       <style type="text/css">
        .style1
        {
            width: 955px;
            height: 204px;
            margin-top:-40px;
        }
        .style2
        {
           height:519px;
           width:100%;
        }
        .style3
        {
            width: 803px;
        }
           #Form1 {
               height: 920px;
           }
    </style>
    </head>
      <body style="background-color:ghostwhite;height:863px">

    <form id="Form1" runat="server" >


                <h1 style="background-color: #333333; height: 129px; border-radius:15px;text-align:center">E-CARE
                    <br />
                    Write Article</h1>
             
        <div class="style2" style="margin-left:129px;margin-right:129px;width:796px; height:827px;background-color:white" >
        
             
                <div style="height:25px;margin:30px; width: 382px;">
                    <asp:Label ID="Label1" runat="server" Text="Title" ></asp:Label>
                         <asp:TextBox ID="TextBox2" runat="server" Height="21px" Width="349px" Font-Bold="True" ></asp:TextBox>   
                </div>
               <div style="height:25px;margin:30px; width: 382px;">
                    <asp:Label ID="Label2" runat="server" Text="Category" ></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" Width="358px">
                    </asp:DropDownList>
                </div>
             
                <div style="height:550px; margin:30px; width: 700px;">
                    <asp:Label ID="Label3" runat="server" Text="Body" ></asp:Label>
                         <asp:TextBox ID="TextBox3" runat="server" Height="500px"  TextMode="multiline" Width="688px"></asp:TextBox>  
                </div>
           
            <div style="text-align:center">
          
            <asp:Button ID="Button1" runat="server" Text="Publish" Height="50px" Width="150px" BackColor="#003366" ForeColor="White" />
                <br />
              
                </div>
  </div>
<hr />
      <div id="footer" 
         style="background-color:ghostwhite; clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
    </form>
  
</body>
  

</html>
