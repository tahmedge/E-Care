<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="PatientVerification.aspx.cs" Inherits="E_Care.PatientVerification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="heads" style="background-color:#C0C0C0; height:50px; ">
            <ul class="ull">
               <li class="lli"><a href="DoctorProfileOwn.aspx" style="color: #006699; text-decoration:none" >Home</a></li>
                <li class="lli"><a href="MessageInboxList.aspx" style="color: #006699;text-decoration:none">Inbox</a></li>
                <li class="lli"><a href="NotificationsListDoctor.aspx" style="color: #006699;text-decoration:none">Notifications</a></li>
                <li class="lli"><a href="PatientVerification.aspx" style="color: #006699;text-decoration:none">Verify Patient</a></li>
                <li class="lli"><a href="EditDoctorInformation.aspx" style="color: #006699;text-decoration:none">Edit Information</a></li>
                <li class="lli"><a href="AskQuestions.aspx" style="color: #006699;text-decoration:none">Ask Questions</a></li>
                <li class="lli"><a href="ArticleList.aspx" style="color: #006699;text-decoration:none">Articles</a></li>
            </ul>
        </div>
    </div>
    <hr />
    <div style="margin-left:250px;margin-right:250px;background-color:ghostwhite;width:auto">
        <div style="width:auto;height:auto;text-align:center;font-size:x-large">
            Patient List
            </div>
        <hr />
        <div style="text-align:center" runat="server" id="str">
            <asp:PlaceHolder ID="DoctorSearchResultPlaceHolder" runat="server"></asp:PlaceHolder>
        </div>
          <div style="text-align:center;margin-top:5px">
                <hr />
            </div>
        </div>

     <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
        </asp:Content>
