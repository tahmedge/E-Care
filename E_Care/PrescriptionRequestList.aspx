<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="PrescriptionRequestList.aspx.cs" Inherits="E_Care.PrescriptionRequestList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="heads" style="background-color:#C0C0C0; height:50px; ">
               <ul class="ull">
<li class="lli"><a href="BloodGroupSearchResult.aspx" style="color: #006699; text-decoration:none" >Blood Bank</a></li>
<li class="lli"><a href="MessageInboxList.aspx"style="color: #006699;text-decoration:none">Inbox</a></li>
<li class="lli"><a href="NotificationsList.aspx"style="color: #006699;text-decoration:none">Notifications</a></li>
<li class="lli"><a href="PrescriptionHistory.aspx"style="color: #006699;text-decoration:none">My Prescriptions</a></li>
               <li class="lli"><a href="PrescriptionRequestList.aspx"style="color: #006699;text-decoration:none">Prescription Request</a></li>
 <li class="lli"><a href="EditPatient.aspx"style="color: #006699;text-decoration:none">Edit Information</a></li>
<li class="lli"><a href="AskQuestionsList.aspx"style="color: #006699;text-decoration:none">Ask Questions</a></li>
<li class="lli"><a href="ArticleList.aspx"style="color: #006699;text-decoration:none">AArticles</a></li>
         
</ul>
        </div>
    <hr />
    <div style="margin-left:250px;margin-right:250px;background-color:ghostwhite;width:auto">
          <div style="text-align:center;margin-top:5px">
              <div style="display:inline-block;margin-left:10px;font-size:x-large" >
                  Prescription Requests</div>
            <br />
            </div>
        <div style="background-color:white">
        <hr />
        </div>
        </div>
    <div style="margin-left:250px;margin-right:250px;background-color:ghostwhite;width:auto">
        <div style="display:inline-block;width:auto;height:auto" runat="server" id="str">
            <asp:PlaceHolder ID="DoctorSearchResultPlaceHolder" runat="server"></asp:PlaceHolder>
            </div>
        <div style="background-color:white">
            <hr />
        </div>
        </div>
      <hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.v>
        </asp:Content>
