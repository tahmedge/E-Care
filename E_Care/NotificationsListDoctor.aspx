<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="NotificationsListDoctor.aspx.cs" Inherits="E_Care.NotificationsListDoctor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="heads" style="background-color:#C0C0C0; height:50px; ">
            <ul class="ull">
               <li class="lli"><a href="DoctorProfileOwn.aspx" style="color: #006699; text-decoration:none" >Home</a></li>
                <li class="lli"><a href="MessageInboxList.aspx" style="color: #006699;text-decoration:none">Inbox</a></li>
                <li class="lli"><a href="NotificationsListDoctor.aspx" style="color: #006699;text-decoration:none">Notifications</a></li>
                <li class="lli"><a href="PatientVerification.aspx" style="color: #006699;text-decoration:none">Verify Patient</a></li>
                <li class="lli"><a href="EditPatient.aspx" style="color: #006699;text-decoration:none">Edit Information</a></li>
                <li class="lli"><a href="AskQuestions.aspx" style="color: #006699;text-decoration:none">Ask Questions</a></li>
                <li class="lli"><a href="ArticleList.aspx" style="color: #006699;text-decoration:none">Articles</a></li>
            </ul>
        </div>
    </div>
    <hr />
    <div style="margin-left:250px;margin-right:250px;background-color:ghostwhite;width:auto">
        <div style="display:inline-block;width:auto;height:auto">
            </div>
        <div style="display:inline-block;width:757px; margin-top:10px;margin-bottom:20px;text-align:center;height:auto;vertical-align:top">
           <div style="text-align:center">
             <div style="font-size:x-large;display:inline-block">
                 Notifications</div>
               </div>
        </div>
          <div style="background-color:white" runat="server" id="str">
            <asp:PlaceHolder ID="DoctorSearchResultPlaceHolder" runat="server"></asp:PlaceHolder>
        </div>
                    <hr />
        </div>
    <hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
        </asp:Content>
