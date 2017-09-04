<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AskQuestions.aspx.cs" inherits="E_Care.AskQuestions" %>

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
                    ASK QUESTIONS</h1>
             
        <div class="style2" >
            <div style="display:inline-block;width:10%; height: 423px;vertical-align:top;border-style:ridge;">
                <div style="height:25px;margin:30px">
                   <asp:Label ID="Label1" runat="server" Text="Category"></asp:Label><hr />  </div>
                <div style="height:25px;margin:30px">
                <asp:Label ID="Label3" runat="server" Text="Subject"></asp:Label><hr />
              
                </div>
                <div style="height:280px; margin:30px">
                    
                <asp:Label ID="Label4" runat="server" Text="My Question"></asp:Label><hr />
               </div>
            </div>
                 <div style="display:inline-block; height: 423px;width:80%;vertical-align:top;border-style:ridge;">
                <div style="height:25px;margin:30px">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="300px">

                    </asp:DropDownList> 
                </div>
                <div style="height:25px;margin:30px">
                         <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="300px"></asp:TextBox>   
                </div>
                     
                <div style="height:280px; margin:30px">
                         <asp:TextBox ID="TextBox3" runat="server" Height="248px" Width="1011px" TextMode="multiline"></asp:TextBox>  
                </div>
            </div>
            <div style="text-align:center">
                <br />
            <asp:Button ID="Button1" runat="server" Text="Post" Height="50px" Width="150px" BackColor="#339933" ForeColor="White" />
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
