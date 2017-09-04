<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="E_Care.test"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">


</script>




<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <style>
    .style1
{
margin-left:100px;
text-align:right;

}
 </style>
</head>
<body style="height:550px;background-color: #333333" runat="server" id="bbb">
    <%--<form id="form2" runat="server" style="margin: -10px; background-color: #008080; font-style: normal; height: 100px; ">--%>
<form id="form2" runat="server"  >
    <div id="stf" runat="server" style="text-align:center;background-color:ghostwhite;color:green;margin-left:200px;margin-right:200px" >
        <div style="background-color:crimson; margin-top:-10px;margin-left:-10px;margin-bottom:0px;margin-right:-10px;width:102%" >
            <div>
                <h1 style="margin:-10px;margin-right:20px;width:102%; font-style: normal;  text-align: center;color:ghostwhite">WELCOME TO E-Care
                </h1 >
            </div>
             
            <div style="background-color: crimson; font-style: normal;margin-right:20px; text-align: right; line-height: 25px; height: 112px;color:ghostwhite"> 
                      <div style="width:75%;display:inline-block;">

                      </div>
                        Username &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                     
                        <br />
                        Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" TextMode="Password" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                 
                        <br />
                        Account Type&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList2" runat="server" Width="155px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                          <asp:ListItem>Doctor</asp:ListItem>
                          <asp:ListItem>Patient</asp:ListItem>
                          <asp:ListItem>Assistant</asp:ListItem>
                      </asp:DropDownList>
                        <br />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <asp:Button ID="Button2" runat="server" Text="Log in" BackColor="#006699" ForeColor="#CCCCCC" OnClick="Button2_Click" Width="107px" />
            </div>
        </div>
       </div>
        <div runat="server" id="footers" style="text-align:center; background-color: #333333; color: #C0C0C0; margin-left:-10px;margin-right:-10px;width:102%">Copyright ©
                 2014 Team Underdog, All Rights Reserved</div>
        

   <div id="wwe" runat="server" style="margin-left:400px">

       <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

       <br />
       <asp:FileUpload ID="FileUploadControl" runat="server" />
       <asp:Button ID="UploadButton" runat="server" OnClick="UploadButton_Click" Text="Button" />
       <br />
       <asp:Label ID="StatusLabel" runat="server"></asp:Label>

             <asp:Label ID="Label11" runat="server" Text="Verified Doctor" Font-Size="Large" ForeColor="#006666"></asp:Label>

   </div>
</form>
</body>
</html>

