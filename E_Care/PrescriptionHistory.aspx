<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="PrescriptionHistory.aspx.cs" Inherits="E_Care.PrescriptionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="heads" style="background-color:#C0C0C0; height:50px; ">
        <ul class="ull">
<li class="lli"><a href="BloodGroup.aspx" style="color: #006699; text-decoration:none" >Blood Bank</a></li>
<li class="lli"><a href="MessageInboxList.aspx"style="color: #006699;text-decoration:none">Inbox</a></li>
<li class="lli"><a href="NotificationsList.aspx"style="color: #006699;text-decoration:none">Notifications</a></li>
<li class="lli"><a href="PrescriptionHistory.aspx"style="color: #006699;text-decoration:none">My Prescriptions</a></li>
               <li class="lli"><a href="PrescriptionRequestList.aspx"style="color: #006699;text-decoration:none">Prescription Request</a></li>
 <li class="lli"><a href="EditPatient.aspx"style="color: #006699;text-decoration:none">Edit Information</a></li>
<li class="lli"><a href="AskQuestionsList.aspx"style="color: #006699;text-decoration:none">Ask Questions</a></li>
<li class="lli"><a href="ArticleList.aspx"style="color: #006699;text-decoration:none">Articles</a></li>
         
</ul>
    </div>
    <div style="margin-bottom:10px"></div>
    <div style="margin-left:250px;margin-right:250px;background-color:ghostwhite;width:auto" aria-grabbed="true">
        <div style="font-size:x-large;text-align:center;color:darkgreen">
            Prescription History
            <hr />
        </div>
        <div style="background-color:white" runat="server" id="str">
            
            <asp:PlaceHolder ID="DoctorSearchResultPlaceHolder" runat="server"></asp:PlaceHolder>
            <hr />
        </div>

    </div>
 
   
    <hr />
    <div id="footer"
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
        Copyright ©
        2014 Team Underdog, All Rights Reserved.
    All Rights Reserved.
    </div>
</asp:Content>
