<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="ArticleDetails.aspx.cs" Inherits="E_Care.ArticleDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="heads" style="background-color:#C0C0C0; height:50px; ">
        <ul class="ull">
<li class="lli"><a href="BloodGroup.aspx" style="color: #006699; text-decoration:none" >Blood Bank</a></li>
<li class="lli"><a href="MessageInboxList.aspx"style="color: #006699;text-decoration:none">Inbox</a></li>
<li class="lli"><a href="NotificationsList.aspx"style="color: #006699;text-decoration:none">Notifications</a></li>
<li class="lli"><a href="PrescriptionHistory.aspx"style="color: #006699;text-decoration:none">My Prescriptions</a></li>
               <li class="lli"><a href="PrescriptionRequestList.aspx"style="color: #006699;text-decoration:none">Prescription Request</a></li>
 <li class="lli"><a href="EditPatient.aspx"style="color: #006699;text-decoration:none">Edit Information</a></li>
<li class="lli"><a href="AskQuestions.aspx"style="color: #006699;text-decoration:none">Ask Questions</a></li>
<li class="lli"><a href="ArticleList.aspx"style="color: #006699;text-decoration:none">Articles</a></li>
         
</ul>
    </div>

        <div class="style2" style="margin-left:129px;margin-right:129px;width:796px; height:auto;background-color:whitesmoke;margin-top:10px" >

            <div style="border-bottom-style:outset;border-radius:5px;border-color:ghostwhite">
                <div style="height:25px;margin:30px; width: 92px; display:inline-block">
                    <asp:Label ID="Label1" runat="server" Text="Written By:" ></asp:Label>
                </div>
            <div style="height:25px;width: 517px; display:inline-block; margin-left: 30px; margin-right: 30px; margin-top: 30px;">
                   <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="#006666">Tahmid Rahman</asp:LinkButton></div>
            
           </div>
            <div style="border-bottom-style:outset;border-radius:10px;border-color:ghostwhite">
               <div style="height:25px;margin:30px; width: 92px; display:inline-block">
                    <asp:Label ID="Label2" runat="server" Text="Subject:" ></asp:Label>
                </div>
                   <div style="height:25px;margin:30px; width: 519px; display:inline-block">
                    <asp:Label ID="Label5" runat="server" Text="Health Issues" ></asp:Label>
                </div>
                 </div>
              <div style="border-bottom-style:outset;border-radius:10px;border-color:ghostwhite">
               <div style="height:25px;margin:30px; width: 92px; display:inline-block">
                    <asp:Label ID="Label7" runat="server" Text="Category:" ></asp:Label>
                </div>
                   <div style="height:25px;margin:30px; width: 519px; display:inline-block">
                    <asp:Label ID="Label8" runat="server" Text="Cardiology" ></asp:Label>
                </div>
                 </div>
                <div style="height:550px; margin:30px; width: 700px;">
                    <asp:Label ID="Label3" runat="server" Text="Body" ></asp:Label>
                         <asp:TextBox ID="TextBox3" runat="server" Height="500px"  TextMode="multiline" Width="688px" ></asp:TextBox>  
                </div>
          <div style="margin:30px">
              <div>
              <asp:Label ID="Label4" runat="server" Text="Comments" ></asp:Label>
                  </div>
              <asp:TextBox ID="TextBox1" runat="server" Height="305px" Width="410px"></asp:TextBox>
          </div>
              <div style="margin:30px">
                    <div>
              <asp:Label ID="Label6" runat="server" Text="Write a comment..." ></asp:Label>
                  </div>
              <asp:TextBox ID="TextBox2" runat="server" Height="105px" Width="350px"></asp:TextBox>
          </div>
            <div style="margin:30px;text-align:left">
          
            <asp:Button ID="Button1" runat="server" Text="Post Comment" Height="50px" Width="150px" BackColor="#003366" ForeColor="White" />
                <br />
              
                </div>
  </div>
    <hr />
   <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
</asp:Content>
