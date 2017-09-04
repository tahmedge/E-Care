 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Message.aspx.cs" Inherits="E_Care.Message" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">


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
            .heads
{
border:2px solid #a1a1a1;

background:#333333;
width:100%;
border-radius:150px;
height:135px


}
    .content
    {


width:100%;

height:500px


}
    .ull
{
list-style-type:none;
margin:5px;
padding:5px;

}
.lli
{
display:inline;
padding:5px 20px 5px 20px;
float:left;
border-right:1px solid #42432d;
text-decoration:none;
font:bold 1em/1em Arial, Helvetica, sans-serif;
text-transform:uppercase;
color:white;
}
li:hover
{
    background-color:#333333;
    color:#333333;
    text-decoration:none;
}
    </style>
    </head>
      <body style="background-color:ghostwhite;height:570px">

    <form id="Form1" runat="server" >

        &nbsp;<div class="heads">
        <div style="height:135px;width:50%;display:inline-block;text-align:center;font-size:x-large;color:white">
            E-CARE<br /> SEND MESSAGE</div>
           <div style="height:135px; width:30%;display:inline-block;float:right; text-align:center;color: #808080;margin-top:5px">
         
              
               <asp:Button ID="Button2" runat="server" BackColor="#003366" ForeColor="#CCCCCC" Text="Home" Width="65px" OnClick="Button2_Click" />
               <asp:Label ID="Label5" runat="server" Width="20px"></asp:Label>
         
              
               <asp:Button ID="Button3" runat="server" Text="Settings" BackColor="#FFFF99" BorderStyle="Outset" OnClick="Button1_Click" Width="66px" />
                  <asp:Label ID="Label6" runat="server" Width="20px"></asp:Label>
         
              
               <asp:Button ID="Button4" runat="server" Text="Log out" BackColor="#009999" BorderStyle="Outset" Height="24px" OnClick="Button3_Click" Width="66px" />
                  <br />
               <br />
               <br />
               <br />
           
        </div>
     
    </div>
         
             <div style="text-align:right;width:953px">
                         <asp:Label ID="Label2" runat="server" Text="Date: "></asp:Label><asp:Label ID="LabelDate" runat="server" Text="Label"></asp:Label></div>
        <div class="style2" >
            <div style="display:inline-block;width:10%; height: 423px;vertical-align:top;border-style:ridge;margin-right:1px;border-radius:15px">
                <div style="height:25px;margin-top:30px;margin-bottom:30px;margin-left:20px;margin-right:20px">
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
                     <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="300px" Enabled="False">Dr.Aminur Rahman Laskar</asp:TextBox>   
                       
                </div>
                  
                <div style="height:25px;margin:30px">
                         <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="300px"></asp:TextBox>   
                </div>
                     
                <div style="height:280px; margin:30px; width: 985px;">
                         <asp:TextBox ID="TextBox3" runat="server" Height="248px" Width="1011px" TextMode="multiline"></asp:TextBox>  
                </div>
            </div>
            <div style="text-align:center">
                <br />
            <asp:Button ID="Button1" runat="server" Text="Send" Height="50px" Width="150px" BackColor="#339933" ForeColor="White" OnClick="Button1_Click" />
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
