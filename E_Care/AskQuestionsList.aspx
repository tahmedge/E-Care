﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="AskQuestionsList.aspx.cs" Inherits="E_Care.AskQuestionsList" %>
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
      
    <div style="margin-left:250px;margin-right:250px;background-color:ghostwhite;width:auto">
        
        <div style="display:inline-block;width:auto;margin-left:50px;margin-right:50px;margin-top:10px;margin-bottom:10px;text-align:center;height:auto;vertical-align:top">
        
       
                 <asp:Label ID="Label4" runat="server" Text="Want to ask a question on our forum? "></asp:Label>
                 <asp:LinkButton ID="LinkButton7" runat="server" ForeColor="#333333" Font-Bold="false" Font-Underline="true" OnClick="LinkButton7_Click">Click here</asp:LinkButton>
  
        </div>
        <div style="background-color:white">
        <hr />
        </div>

    </div>
    <div style="margin-left:250px;margin-right:250px;background-color:ghostwhite;width:auto">
        <div style="display:inline-block;width:auto;height:auto">
            </div>
        <div style="display:inline-block;width:auto;margin-left:50px;margin-right:50px;margin-top:10px;margin-bottom:50px;text-align:center;height:auto;vertical-align:top">
           <div style="text-align:left">
             <div style="font-size:x-large">
                 <asp:LinkButton ID="LinkButton4" runat="server" ForeColor="#333333" Font-Bold="True" Font-Underline="true">I am suffering from fever for 7 days</asp:LinkButton>
  
                </div>
   
            <div style="font-size:large;margin-top:0px">
                    <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="#666666" Font-Bold="True" Font-Underline="false">Samiul</asp:LinkButton>
                </div>
            <br />
             <br />
            <asp:Label ID="Label3" runat="server" Text="Category: Medicine" ForeColor="#006699"></asp:Label>
               </div>
        </div>
          <div style="text-align:right">
              <asp:Button ID="Button4" runat="server" BackColor="#006699" ForeColor="GhostWhite" Height="40px" Text="Reply Question" />
            <br />
            </div>
        <div style="background-color:white">
        <hr />
        </div>

    </div>
            <div style="margin-left:250px;margin-right:250px;background-color:ghostwhite;width:auto">
        <div style="display:inline-block;width:auto;height:auto">
            </div>
        <div style="display:inline-block;width:auto;margin-left:50px;margin-right:50px;margin-top:10px;margin-bottom:50px;text-align:center;height:auto;vertical-align:top">
           <div style="text-align:left">
             <div style="font-size:x-large">
                 <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="#333333" Font-Bold="True" Font-Underline="true">I have much extra weight</asp:LinkButton>
  
                </div>
   
            <div style="font-size:large;margin-top:0px">
                    <asp:LinkButton ID="LinkButton5" runat="server" ForeColor="#666666" Font-Bold="True" Font-Underline="false">Minhaz</asp:LinkButton>
                </div>
            <br />
             <br />
            <asp:Label ID="Label1" runat="server" Text="Category: Cardiology" ForeColor="#003366"></asp:Label>
               </div>
        </div>
          <div style="text-align:right">
              <asp:Button ID="Button1" runat="server" BackColor="#006699" ForeColor="GhostWhite" Height="40px" Text="Reply Question" />
            <br />
            </div>
        <div style="background-color:white">
        <hr />
        </div>

    </div>
        <div style="margin-left:250px;margin-right:250px;background-color:ghostwhite;width:auto">
        <div style="display:inline-block;width:auto;height:auto">
            </div>
        <div style="display:inline-block;width:auto;margin-left:50px;margin-right:50px;margin-top:10px;margin-bottom:50px;text-align:center;height:auto;vertical-align:top">
           <div style="text-align:left">
             <div style="font-size:x-large">
                 <asp:LinkButton ID="LinkButton3" runat="server" ForeColor="#333333" Font-Bold="True" Font-Underline="true">Tonsilities</asp:LinkButton>
  
                </div>
   
            <div style="font-size:large;margin-top:0px">
                    <asp:LinkButton ID="LinkButton6" runat="server" ForeColor="#666666" Font-Bold="True" Font-Underline="false">Faiyaz</asp:LinkButton>
                </div>
            <br />
             <br />
            <asp:Label ID="Label2" runat="server" Text="Category: Medicine" ForeColor="#003366"></asp:Label>
               </div>
        </div>
          <div style="text-align:right">
              <asp:Button ID="Button2" runat="server" BackColor="#006699" ForeColor="GhostWhite" Height="40px" Text="Reply Question" />
            <br />
            </div>
        <div style="background-color:white">
        <hr />
        </div>

    </div>
       </asp:Content>