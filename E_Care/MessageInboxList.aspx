<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="MessageInboxList.aspx.cs" Inherits="E_Care.MessageInboxList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-bottom:10px;text-align:center;color:Black;color:lightgreen;font-size:x-large">
        Message Inbox List
        <hr />
    </div>
    <div style="margin-left:250px;margin-right:250px;background-color:antiquewhite;width:auto" aria-grabbed="true" >
  
              
        <div style="background-color:white" runat="server" id="str">
            <asp:PlaceHolder ID="DoctorSearchResultPlaceHolder" runat="server"></asp:PlaceHolder>
        </div>

    </div>
    <div style="margin-left:250px;margin-right:250px;background-color:ghostwhite;width:auto">
        <div style="background-color:white">
            <hr />
        </div>

    </div>
<hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
       </asp:Content>
