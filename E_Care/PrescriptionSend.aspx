<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="PrescriptionSend.aspx.cs" Inherits="E_Care.PrescriptionSend" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <div class="heads" style="background-color:#C0C0C0; height:50px; ">
        <ul class="ull">
<li class="lli"><a href="DoctorProfileOwn.aspx" style="color: #006699; text-decoration:none" >Home</a></li>
<li class="lli"><a href="MessageInboxList.aspx"style="color: #006699;text-decoration:none">Inbox</a></li>
<li class="lli"><a href="NotificationsListDoctor.aspx"style="color: #006699;text-decoration:none">Notifications</a></li>
 <li class="lli"><a href="EditDoctorInformation.aspx"style="color: #006699;text-decoration:none">Edit Information</a></li>
<li class="lli"><a href="AskQuestions.aspx"style="color: #006699;text-decoration:none">Ask Questions</a></li>
<li class="lli"><a href="ArticleList.aspx"style="color: #006699;text-decoration:none">Articles</a></li>
</ul>
    </div>

        <div class="style2" style="margin-left:129px;margin-right:129px;width:796px; height:927px;background-color:whitesmoke" >

            <div style="border-bottom-style:outset;border-radius:5px;border-color:ghostwhite">
                <div style="height:25px;margin:30px; width: 74px;display:inline-block">
                    <asp:Label ID="Label1" runat="server" Text="To:" ></asp:Label>
                </div>
            <div style="height:25px;width: 517px; display:inline-block; margin-left: 30px; margin-right: 30px; margin-top: 30px;">
                <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged" AutoPostBack="True"></asp:TextBox>
                </div>
            
           </div>
            <div style="border-bottom-style:outset;border-radius:10px;border-color:ghostwhite">
               <div style="height:25px;margin:30px; width: 74px;display:inline-block">
                    <asp:Label ID="Label2" runat="server" Text="Date:" ></asp:Label>
                </div>
                <div style="height:25px;margin:30px; width: 519px; display:inline-block">
                    <asp:Label ID="Label_Date" runat="server" Text="07/04/2014" ></asp:Label>
                </div>
                 </div>
                <div style="height:450px; margin:30px; width: 700px;">
                  <asp:Label ID="Label3" runat="server" Text="Suggetion" ></asp:Label>
                         <asp:TextBox ID="Textbox_Body" runat="server" Height="301px"  TextMode="multiline" Width="688px" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>  
                </div>
          
            <div style="text-align:center">
          
            <asp:Button ID="Button1" runat="server" Text="Send Prescription" Height="50px" Width="150px" BackColor="#003366" ForeColor="White" OnClick="Button1_Click" />
                <br />
              
                </div>
  </div>
<hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
   
</asp:Content>
