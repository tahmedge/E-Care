<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="AppointmentRequestList.aspx.cs" Inherits="E_Care.AppointmentRequestList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div style="background-color:ghostwhite; text-align:center; height: 229px; margin-top:0px;margin-left:129px;margin-right:129px;text-align:left;">
            <br />
            <div style="margin-top:0px;vertical-align:top;text-align:center;margin-left:20px;display:inline-block; width: 351px;">
                <asp:Label ID="Label23" runat="server" Font-Size="Large" ForeColor="#336699" Height="50px" Text="Check Appointment" Width="977px"></asp:Label>
            </div>
            <div style="margin-left:200px;display:inline-block">
                <div style="margin-left:20px;display:inline-block">
                </div>
                <div style="margin-left:20px;display:inline-block">
                </div>
                <div style="margin-left:20px;display:inline-block">
                </div>
            </div>
            <br />
            <br />
               <div class="days" style="margin-top:0px">
            <div style="margin-left:20px;display:inline-block;text-align:center">
                 <asp:Label ID="Day1" runat="server" Text=" April 1 " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
                   <asp:Label ID="Day2" runat="server" Text=" April 2 " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
                <asp:Label ID="Day3" runat="server" Text=" April 3 " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
           <asp:Label ID="Day4" runat="server" Text=" April 4 " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
                 <asp:Label ID="Day5" runat="server" Text=" April 5 " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
        <asp:Label ID="Day6" runat="server" Text=" April 6 " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
                  <asp:Label ID="Day7" runat="server" Text=" April 7 " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>

    </div>
             <div class="prescription";>
            <div style="margin-left:20px;display:inline-block;">
                <asp:Button ID="Button1" runat="server" Text="Saturday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" OnClick="Button1_Click" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button2" runat="server" Text="Sunday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" OnClick="Button2_Click" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button3" runat="server" Text="Monday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" OnClick="Button3_Click" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button4" runat="server" Text="Tuesday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" OnClick="Button4_Click" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button5" runat="server" Text="Wednesday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" OnClick="Button5_Click" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button6" runat="server" Text="Thursday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" OnClick="Button6_Click"/>
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button7" runat="server" Text="Friday(Closed)" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" OnClick="Button7_Click" />
            </div>

    </div>
        </div>
    </div>
    <hr />
    <div style="margin-left:250px;margin-right:250px;background-color:ghostwhite;width:auto">
        <div style="display:inline-block;width:auto;height:auto">
            </div>
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
