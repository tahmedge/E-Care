<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IntroPage.aspx.cs" Inherits="E_Care.IntroPage"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">


</script>




<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body style="height:550px;background-color: #333333">
<%--<form id="form2" runat="server" style="margin: -10px; background-color: #008080; font-style: normal; height: 100px; ">--%>
<form id="form2" runat="server"  >
    <div>
        <div style="background-color:crimson; margin-top:-10px;margin-left:-10px;margin-bottom:0px;margin-right:-10px;width:102%" >
            <div>
                <h1 style="margin:-10px;margin-right:20px;width:102%; font-style: normal;  text-align: center;color:ghostwhite">WELCOME TO E-Care
                </h1 >
            </div>
             
            <div style="background-color: crimson; font-style: normal;margin-right:20px; text-align: right; line-height: 25px; height: 112px;color:ghostwhite"> 
                      <div style="width:75%;display:inline-block;">

                          Username</div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1_Username" runat="server"></asp:TextBox>
                     
                        <br />
                        Password&nbsp;&nbsp;&nbsp;     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2_Password" runat="server" TextMode="Password"></asp:TextBox>
                 
                        <br />
                        Account Type&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList2" runat="server" Width="155px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                          <asp:ListItem>Doctor</asp:ListItem>
                          <asp:ListItem>Patient</asp:ListItem>
                          <asp:ListItem>Assistant</asp:ListItem>
                      </asp:DropDownList>
                        <br />
                      <asp:Label ID="Label3" runat="server" ForeColor="Black"></asp:Label>
                      <asp:Label ID="Label2" runat="server"></asp:Label>
                <asp:Button ID="Button2" runat="server" Text="Log in" BackColor="#006699" ForeColor="#CCCCCC" OnClick="Button2_Click" />
            </div>
        </div>
        <div id="container" style="background-color:ivory;margin-left: -10px;margin-right:-10px;height:500px;width:102%;">
                            <div style="width:60%;display:inline-block;height:500px;text-align: center; font-size: large;" >
                     
                                <br />
                                <br />
                                <br />
              
                           <span style="font-weight: bold; font-size: xx-large">Welcome to Physician Directory</span>
                                <br />
                                <br />
                                Search for doctors, hospitals from our exclusive search engine 
                                <br />
                                <br />
                                Book appointement online,or send message to the doctors you 
                                <br />
                                want to get information that u need just by creating an account 
                                <br />
                                <br />
                                Search for needed blood groups near you, read exclusive article 
                                <br />
                                 of our doctors, or ask questions on forum by category
                                <br />
                                <br />
                                <br />
                                 <br />
                                <br />
                                 <br />
                                 <br />
                                <br />
                            </div>
                        <div style="width:488px; display:inline-block;height:500px;text-align:center;font-size:x-large">
                               <br />
                                <br />
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                                <br />
                                <br />
                   
                               Don&#39;t have any account?<br />
                                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Sign Up</asp:LinkButton>
                                &nbsp;now<br />   <br />             
                                
                                
                            Click on continue to access 
                                <br />
                            without logging in
                                <br />*
                            <asp:Button ID="Button1" runat="server" Text="Continue" Height="47px" BackColor="#006699" ForeColor="White" Font-Size="Large" Width="176px" OnClick="Button1_Click" />
                                <br />
                                 <br />
                                 <br />
                                <br />
                                <br />
                                <br />
                            </div>
                        </div>

        <div id="footer" style="text-align:center; background-color: #333333; color: #C0C0C0; margin-left:-10px;margin-right:-10px;width:102%">Copyright ©
                 2014 Team Underdog, All Rights Reserved</div>
        
    </div>
   
</form>
</body>
</html>

