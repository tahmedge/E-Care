<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="HomePage.aspx.cs" Inherits="E_Care._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 1641px;
        }
        .style3
        {
            width: 857px;
            height: 580px;
        }
        .style4
        {
            height: 580px;
        }
        .auto-style1 {
            width: 1653px;
            height: 388px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h3 style="Height:376px;">
        <img alt="" class="auto-style1" src="../Photo/911904128.jpg" /><asp:Image ID="Image1" runat="server" Height="389px" Width="1648px" 
            style="margin-top: -10px; margin-left: 0px;" />
    </h3 >
   
    <h2 style="font-size:15px; background-color:#FFCC99; font-style: inherit; margin-top: 0px; font-family: 'Avenir LT W01 35 Light', 'Open Sans', Arial, Helvetica, sans-serif;">
    

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Search by Area &amp; Speciality<br />
        <br />
        <br />
   

        &nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; I need a PhysiciAn Specialize in&nbsp; 
        <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" 
            Width="198px" Font-Size="Medium">
            <asp:ListItem>Cardiology</asp:ListItem>
            <asp:ListItem>Medicine</asp:ListItem>
        </asp:DropDownList>
        &nbsp; near
        <asp:DropDownList ID="DropDownList2" runat="server" Height="30px" Width="198px" 
            Font-Size="Medium">
            <asp:ListItem>Sylhet</asp:ListItem>
            <asp:ListItem>Dhaka</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BackColor="#DD4619" Height="29px" 
            Text="Search" Width="105px" BorderStyle="Inset" onclick="Button1_Click" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 
        Search by Doctor Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox 
            ID="TextBox1" runat="server" Height="30px" Width="251px" Font-Size="Medium"></asp:TextBox>
        &nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" BackColor="#DD4619" Height="31px" 
            Text="Search" Width="115px" BorderStyle="Outset" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </h2>
    <h1 style="background-image: none; background-repeat: no-repeat; background-color: #333333; font-size: 24.3px; font-family: 'Times New Roman', Times, serif; width: 1650px;">
        &nbsp;&nbsp; 
        <br />
        <table>
    <tr>
    <td class="style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button 
        ID="Button20" runat="server" Text="My Inbox" Width="181px" Height="50px" 
                BackColor="#006666" BorderColor="#333333" ForeColor="White" />
&nbsp;&nbsp;&nbsp; 
            <asp:Button 
        ID="Button21" runat="server" Text="Notifications" Width="181px" Height="50px" 
                BackColor="#006666" BorderColor="#333333" ForeColor="White" />
&nbsp;&nbsp;&nbsp; 
            <asp:Button 
        ID="Button22" runat="server" Text="Ask Questions" Width="181px" Height="50px" 
                BackColor="#006666" BorderColor="#333333" ForeColor="White" />
&nbsp;&nbsp;&nbsp; 
            <asp:Button 
        ID="Button23" runat="server" Text="Articles" Width="181px" Height="50px" 
                BackColor="#006666" BorderColor="#333333" ForeColor="White" />
&nbsp;&nbsp;&nbsp; 
            <asp:Button 
        ID="Button24" runat="server" Text="Blood Group Info" Width="181px" Height="50px" 
                BackColor="#006666" BorderColor="#333333" ForeColor="White" />
&nbsp;&nbsp;&nbsp; 
            <asp:Button 
        ID="Button25" runat="server" Text="Edit Information" Width="181px" Height="50px" 
                BackColor="#006666" BorderColor="#333333" ForeColor="White" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
       
       
        </tr>     
        </table>
        <table style="width: 1647px">
        <td class="style3">
        </td>
        <td class="style4">
        </td>
        </table>
           </h1>

    <div id="footer" 
        style="background-color:#4a4a4a;clear:both;text-align:center; color: #FFFFFF; ">
        2013 All Rights Reserved to Tahmid Rahman, Araf Farayez and Nazmul Huda</div>
    
   

    </asp:Content>
