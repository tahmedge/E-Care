<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="BloodGroupSearchResult.aspx.cs" Inherits="E_Care.BloodGroupSearchResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div></div>
       <div class="heads" style="background-color:#C0C0C0; height:50px; ">
        <ul class="ull">
<li class="lli"><a href="BloodGroupSearchResult.aspx" style="color: #006699; text-decoration:none" >Blood Bank</a></li>
<li class="lli"><a href="MessageInboxList.aspx"style="color: #006699;text-decoration:none">Inbox</a></li>
<li class="lli"><a href="NotificationsList.aspx"style="color: #006699;text-decoration:none">Notifications</a></li>
<li class="lli"><a href="PrescriptionHistory.aspx"style="color: #006699;text-decoration:none">My Prescriptions</a></li>
               <li class="lli"><a href="PrescriptionRequestList.aspx"style="color: #006699;text-decoration:none">Prescription Request</a></li>
 <li class="lli"><a href="EditPatient.aspx"style="color: #006699;text-decoration:none">Edit Information</a></li>
<li class="lli"><a href="AskQuestionsList.aspx"style="color: #006699;text-decoration:none">Ask Questions</a></li>
<li class="lli"><a href="ArticleList.aspx"style="color: #006699;text-decoration:none">Articles</a></li>
         
</ul>
    </div>
    
  <div style="text-align:center;background-color:#006699">
        <asp:Label ID="Label10" runat="server" Text="Blood Group" Font-Size="Large" Height="26px" Width="204px" ForeColor="White"></asp:Label>
        <asp:DropDownList ID="DropDownList5" runat="server" Width="250px" Height="26px" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged">
             <asp:ListItem>A+</asp:ListItem> 
             <asp:ListItem>A-</asp:ListItem>
             <asp:ListItem>B+</asp:ListItem>
             <asp:ListItem>B-</asp:ListItem>
             <asp:ListItem>O+</asp:ListItem>
             <asp:ListItem>O-</asp:ListItem>
             <asp:ListItem>AB+</asp:ListItem>
             <asp:ListItem>AB-</asp:ListItem>
        </asp:DropDownList>
           <asp:Label ID="Label11" runat="server" Text=" near " Font-Size="Large" Height="26px" Width="96px" ForeColor="White"></asp:Label>
          <asp:DropDownList ID="DropDownList6" runat="server" Width="250px" Height="26px">
          <asp:ListItem>Dhaka</asp:ListItem>
         <asp:ListItem>Rajshahi</asp:ListItem>
         <asp:ListItem>Barishal</asp:ListItem>
         <asp:ListItem>Chittagong</asp:ListItem>
         <asp:ListItem>Sylhet</asp:ListItem>
               <asp:ListItem>Rangpur</asp:ListItem>
        <asp:ListItem>Tangail</asp:ListItem>
	 <asp:ListItem>Sherpur</asp:ListItem>
	 <asp:ListItem>Shariatpur</asp:ListItem>
	 <asp:ListItem>Rajbari</asp:ListItem>
	 <asp:ListItem>Netrokona</asp:ListItem>
	 <asp:ListItem>Narsingdi</asp:ListItem>
	 <asp:ListItem>Narayanganj</asp:ListItem>
	 <asp:ListItem>Mymensingh</asp:ListItem>
	 <asp:ListItem>Munshiganj</asp:ListItem>
	 <asp:ListItem>Manikganj</asp:ListItem>
	 <asp:ListItem>Madaripur</asp:ListItem>
	 <asp:ListItem>Kishoreganj</asp:ListItem>
	 <asp:ListItem>Jamalpur</asp:ListItem>
	 <asp:ListItem>Gopalganj</asp:ListItem>
	 <asp:ListItem>Gazipur</asp:ListItem>
	 <asp:ListItem>Faridpur</asp:ListItem>
	<asp:ListItem>Barisal</asp:ListItem>
	 <asp:ListItem>Barguna</asp:ListItem>
	 <asp:ListItem>Bhola</asp:ListItem>
	 <asp:ListItem>Jhalokati</asp:ListItem>
	 <asp:ListItem>Patuakhali</asp:ListItem>
	 <asp:ListItem>Pirojpur</asp:ListItem>
	 <asp:ListItem>Bagerhat</asp:ListItem>
	 <asp:ListItem> Chuadanga </asp:ListItem>
	 <asp:ListItem> Jessore </asp:ListItem>
	 <asp:ListItem> Jhenaidah </asp:ListItem>
	 <asp:ListItem> Khulna </asp:ListItem>
	 <asp:ListItem> Kushtia </asp:ListItem>
	 <asp:ListItem> Magura </asp:ListItem>
	 <asp:ListItem> Meherpur </asp:ListItem>
	 <asp:ListItem> Narail </asp:ListItem>
	 <asp:ListItem> Satkira </asp:ListItem>
	<asp:ListItem> Dinajpur </asp:ListItem>
	 <asp:ListItem> Gaibandha </asp:ListItem>
	 <asp:ListItem> Kurigram </asp:ListItem>
	 <asp:ListItem> Lalmonirhat </asp:ListItem>
	 <asp:ListItem> Nilphamari</asp:ListItem>
	 <asp:ListItem> Panchagarh </asp:ListItem>
	 <asp:ListItem> Rangpur </asp:ListItem>
	 <asp:ListItem> Thakurgaon </asp:ListItem>
	<asp:ListItem>Rajshahi</asp:ListItem>
	 <asp:ListItem> Nawabganj </asp:ListItem>
	 <asp:ListItem> Naogaon </asp:ListItem>
	 <asp:ListItem> Bogra </asp:ListItem>
	 <asp:ListItem> Natore </asp:ListItem>
	 <asp:ListItem> Joypurhat </asp:ListItem>
	 <asp:ListItem> Sirajganj </asp:ListItem>
	 <asp:ListItem> Pabna </asp:ListItem>
	 <asp:ListItem> Habiganj </asp:ListItem>
	 <asp:ListItem> Moulovibazar </asp:ListItem>
	 <asp:ListItem> Sunamganj </asp:ListItem>
	 <asp:ListItem> Sylhet </asp:ListItem>
	 <asp:ListItem> Brahmanbaria </asp:ListItem>
	 <asp:ListItem> Noakhali </asp:ListItem>
	 <asp:ListItem> Chandpur </asp:ListItem>
	 <asp:ListItem> Laxmipur </asp:ListItem>
	 <asp:ListItem> Comilla </asp:ListItem>
	 <asp:ListItem> Feni </asp:ListItem>
	 <asp:ListItem> Khagrachori </asp:ListItem>
	 <asp:ListItem> Rangamati </asp:ListItem>
	 <asp:ListItem> Chittagong </asp:ListItem>
	 <asp:ListItem> Bandarban </asp:ListItem>
	 <asp:ListItem> Cox's Bazar </asp:ListItem>
          </asp:DropDownList>
         <asp:Label ID="Label12" runat="server" Text=" " Font-Size="Large" Height="26px" Width="30px" ForeColor="White"></asp:Label>
         <asp:Button ID="Button1" runat="server" Text="Search" Width="75px" Height="26px" BackColor="#666699" ForeColor="White" OnClick="Button4_Click" />
  </div>
    <div style="margin-left:250px;margin-right:250px;background-color:ghostwhite;width:auto">
        <div id="str" runat="server">
           <asp:PlaceHolder ID="BloodGroupSearchResultPlaceHolder" runat="server">

    </asp:PlaceHolder>
            </div>
    </div>
      
     <hr />
 
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
       </asp:Content>
