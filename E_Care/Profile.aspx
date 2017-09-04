 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="E_Care.Profile" %>

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
               height: 483px;
           }
    </style>
    </head>
      <body style="background-color:ghostwhite;height:570px">

    <form id="Form1" runat="server" >


                <h1 style="background-color: #333333; height: 129px; border-radius:15px;text-align:center;color:ghostwhite">E-CARE
                    <br />
                Send Message<asp:Button ID="Button2" runat="server" Text="Button" />
                </h1>
             
        <div class="style2" >
            <div style="display:inline-block;width:10%; height: 423px;vertical-align:top;border-style:ridge;margin-right:1px;border-radius:15px">
                <div style="height:25px;margin-bottom:30px;margin-left:20px;margin-right:20px">
                   <asp:Label ID="Label1" runat="server" Text="To:"></asp:Label><hr />  </div>
                <div style="height:25px;margin-top:30px;margin-bottom:30px;margin-left:20px;margin-right:20px">
                <asp:Label ID="Label3" runat="server" Text="Subject:"></asp:Label><hr />
              
                </div>
                <div style="height:280px; margin-top:30px;margin-bottom:30px;margin-left:20px;margin-right:20px">
                    
                <asp:Label ID="Label4" runat="server" Text="Message Body:"></asp:Label><hr />
               </div>
            </div>
                 <div style="display:inline-block; height: 423px;width:80%;vertical-align:top;border-style:ridge;margin-left:1px;border-radius:15px">
                <div style="height:25px;margin:30px">
                     <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
                     <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
                </div>
                <div style="height:25px;margin:30px">
                         <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
                </div>
                     
                <div style="height:280px; margin:30px">
                         <asp:TextBox ID="TextBox3" runat="server" Height="248px" Width="1011px" TextMode="multiline" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>  
                </div>
            </div>
            <div style="text-align:center">
                <br />
            <asp:Button ID="Button1" runat="server" Text="Send" Height="50px" Width="150px" BackColor="#339933" ForeColor="White" />
                <br />
                <br />
                </div>
        </div>
        <hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
    </form>
  
</body>
  
    
</html>
